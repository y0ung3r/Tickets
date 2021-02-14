using Spire.Doc;
using Spire.Doc.Documents;
using System.Collections.Generic;
using System.IO;
using Tickets.Extensions;
using Tickets.Interfaces;

namespace Tickets.Word
{
    public class WordHandler : IWordHandler
    {
        public ICollection<TParagraph> GetParagraphs<TParagraph>(string filepath) where TParagraph : class
        {
            if (!File.Exists(filepath))
            {
                throw new FileNotFoundException("Указанный файл не существует");
            }

            using (var document = new Document(filepath))
            {
                var paragraphs = new List<TParagraph>();
                var section = document.LastSection;

                for (var i = 0; i < section.Paragraphs.Count; i++)
                {
                    var paragraph = section.Paragraphs[i].Clone() as Paragraph;
                    paragraph.SetDefaultFormatting();

                    paragraphs.Add(paragraph as TParagraph);
                }

                document.Close();

                return paragraphs;
            }
        }

        public void Write<TSection>(string filepath, IWordTemplate<TSection> template) where TSection : class
        {
            var document = new Document();

            var section = document.AddSection();
            template.Execute(section as TSection);

            document.SaveToFile(filepath, FileFormat.Auto);

            document.Close();
            document.Dispose();
        }
    }
}
