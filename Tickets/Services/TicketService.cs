using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using Tickets.Interfaces;
using Tickets.Models;
using Tickets.Word;

namespace Tickets.Services
{
    public sealed class TicketService : ITicketService
    {
        private readonly IWordHandler wordHandler;

        public TicketService(IWordHandler wordHandler)
        {
            this.wordHandler = wordHandler;
        }

        private ICollection<Question> GetQuestions(string filepathToQuestions)
        {
            var questions = new List<Question>();
            var paragraphs = wordHandler.GetParagraphs<Paragraph>(filepathToQuestions);

            foreach (var paragraph in paragraphs)
            {
                var question = new Question()
                {
                    Content = paragraph
                };

                questions.Add(question);
            }

            return questions;
        }

        private ICollection<Task> GetTasks(string filepathToTasks)
        {
            var tasks = new List<Task>();
            var paragraphs = wordHandler.GetParagraphs<Paragraph>(filepathToTasks);

            foreach (var paragraph in paragraphs)
            {
                // Если paragraph - это условие задачи, то...
                if (!string.IsNullOrWhiteSpace(paragraph.Text))
                {
                    // Из списка paragraphs, начиная с paragraph, берем все изображения, пока не встретится следующее условие задачи
                    var pictures = paragraphs.SkipWhile(item => !item.Equals(paragraph)) // Убираем элементы ДО paragraph
                                             .Skip(count: 1) // Убираем paragraph
                                             .TakeWhile(item => item.FirstChild is DocPicture) // Берем изображения до следующего условия задачи
                                             .ToList();

                    var task = new Task()
                    {
                        Condition = paragraph,
                        Pictures = pictures
                    };

                    tasks.Add(task);
                }
            }

            return tasks;
        }

        public void CreateTickets(TicketsSettings ticketsSettings)
        {
            if (string.IsNullOrWhiteSpace(ticketsSettings.PathToQuestions))
            {
                throw new InvalidOperationException("Не указан путь до файла с вопросами");
            }

            var questions = GetQuestions(ticketsSettings.PathToQuestions);

            if (questions.Count / ticketsSettings.QuestionsCount > ticketsSettings.TicketsCount)
            {
                throw new InvalidOperationException("Невозможно сформировать заданное количество экзаменационных билетов используя указанный список вопросов");
            }

            var tasks = new List<Task>() as ICollection<Task>;

            if (ticketsSettings.CanIncludeTasks)
            {
                if (string.IsNullOrWhiteSpace(ticketsSettings.PathToTasks))
                {
                    throw new InvalidOperationException("Не указан путь до файла с задачами\nЭто обязательно, если активирован режим \"Включать задачи в билеты\"");
                }
                else
                {
                    tasks = GetTasks(ticketsSettings.PathToTasks);
                }
            }

            var ticketsTemplate = new TicketsWordTemplate(ticketsSettings, questions, tasks);
            wordHandler.Write(ticketsSettings.DestinationFilepath, ticketsTemplate);
        }
    }
}
