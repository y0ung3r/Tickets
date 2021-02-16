using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Tickets.Extensions;
using Tickets.Interfaces;
using Tickets.Models;

namespace Tickets.Word
{
    public class TicketsWordTemplate : IWordTemplate<Section>
    {
        private readonly TicketsSettings ticketsSettings;
        private readonly ICollection<Question> questions;
        private readonly ICollection<Task> tasks;

        private Random random;

        private ICollection<Question> usedQuestions;
        private ICollection<Task> usedTasks;

        public TicketsWordTemplate(TicketsSettings ticketsSettings, ICollection<Question> questions, ICollection<Task> tasks)
        {
            this.ticketsSettings = ticketsSettings;
            this.questions = questions;
            this.tasks = tasks;

            random = new Random();

            usedQuestions = new List<Question>();
            usedTasks = new List<Task>();
        }

        private Question GetRandomQuestion()
        {
            if (questions.Count.Equals(0))
            {
                foreach (var usedQuestion in usedQuestions)
                {
                    questions.Add(usedQuestion);
                }

                usedQuestions.Clear();
            }

            var randomIndex = random.Next(0, questions.Count - 1);
            var randomQuestion = questions.ElementAt(randomIndex);

            questions.Remove(randomQuestion);
            usedQuestions.Add(randomQuestion);

            return randomQuestion;
        }

        private Task GetRandomTask()
        {
            if (tasks.Count.Equals(0))
            {
                foreach (var usedTask in usedTasks)
                {
                    tasks.Add(usedTask);
                }

                usedTasks.Clear();
            }

            var randomIndex = random.Next(0, tasks.Count - 1);
            var randomTask = tasks.ElementAt(randomIndex);

            tasks.Remove(randomTask);
            usedTasks.Add(randomTask);

            return randomTask;
        }

        public void Execute(Section section)
        {
            section.PageSetup.Margins.Left = 0.6f.ToCentimeters();
            section.PageSetup.Margins.Right = 0.6f.ToCentimeters();
            section.PageSetup.Margins.Top = 0.6f.ToCentimeters();
            section.PageSetup.Margins.Bottom = 0.6f.ToCentimeters();

            var ticketTable = section.AddTable(showBorder: false);

            for (var i = 0; i < ticketsSettings.TicketsCount; i++)
            {
                var row = ticketTable.AddRow(columnsNum: 1);
                var rowIndex = i + 1;

                row.Cells[0].AddParagraph();

                row.Cells[0].AddParagraph
                (
                   ticketsSettings.Header,
                   HorizontalAlignment.Center,
                   isBold: true
                );

                row.Cells[0].AddParagraph($"Факультет: {ticketsSettings.FacultyTitle}");
                row.Cells[0].AddParagraph($"Кафедра: {ticketsSettings.DepartmentTitle}");
                row.Cells[0].AddParagraph($"Предмет: {ticketsSettings.DisciplineTitle}");
                row.Cells[0].AddParagraph($"Учебный год: {ticketsSettings.StudyYear}");

                row.Cells[0].AddParagraph
                (
                    $"Экзаменационный билет №{rowIndex}",
                    HorizontalAlignment.Center
                );

                var listStyle = new ListStyle(section.Document, ListType.Numbered)
                {
                    Name = $"ticket-{Guid.NewGuid()}"
                };

                listStyle.Levels[0].PatternType = ListPatternType.Arabic;
                section.Document.ListStyles.Add(listStyle);

                for (var k = 0; k < ticketsSettings.QuestionsCount; k++)
                {
                    var question = GetRandomQuestion();
                    var questionContentParagraph = question.Content.Clone() as Paragraph;
                    row.Cells[0].Paragraphs.Add(questionContentParagraph);
                    questionContentParagraph.ListFormat.ApplyStyle(listStyle.Name);
                }

                if (ticketsSettings.CanUseTaskWord)
                {
                    var taskHeaderParagraph = row.Cells[0].AddParagraph();
                    taskHeaderParagraph.AppendText("Задача.");
                    taskHeaderParagraph.ListFormat.ApplyStyle(listStyle.Name);

                    if (ticketsSettings.CanIncludeTasks)
                    {
                        var task = GetRandomTask();

                        var taskConditionParagraph = task.Condition.Clone() as Paragraph;
                        row.Cells[0].Paragraphs.Add(taskConditionParagraph);

                        taskConditionParagraph.Format.LeftIndent = 53.5f;

                        foreach (var picture in task.Pictures)
                        {
                            var pictureParagraph = picture.Clone() as Paragraph;
                            row.Cells[0].Paragraphs.Add(pictureParagraph);
                        }
                    }
                }

                row.Cells[0].AddParagraph();

                row.Cells[0].AddParagraph
                (
                    $"И. о. зав. кафедрой                                                 {ticketsSettings.DepartmentChief}",
                    HorizontalAlignment.Center
                );

                row.Cells[0].AddParagraph();

                row.Cells[0].CellFormat.Borders.Bottom.BorderType = BorderStyle.DashLargeGap;
                row.Cells[0].CellFormat.Borders.Bottom.LineWidth = 0.5f;
                row.Cells[0].CellFormat.Borders.Bottom.Color = Color.Black;

                if (rowIndex % 3 == 0)
                {
                    section.AddParagraph()
                           .AppendBreak(BreakType.PageBreak);

                    ticketTable = section.AddTable(showBorder: false);
                }
            }

            section.Tables.AutoFit(AutoFitBehaviorType.AutoFitToWindow);
        }
    }
}
