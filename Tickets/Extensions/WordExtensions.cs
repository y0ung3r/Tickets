using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

namespace Tickets.Extensions
{
    public static class WordExtensions
    {
        public static Paragraph AddParagraph(this Body body, string content, HorizontalAlignment horizontalAlignment = HorizontalAlignment.Left,
            float fontSize = 11.0f, bool isBold = false)
        {
            var paragraph = body.AddParagraph();
            paragraph.Format.HorizontalAlignment = horizontalAlignment;

            var paragraphText = paragraph.AppendText(content);
            paragraphText.CharacterFormat.Bold = isBold;
            paragraphText.CharacterFormat.FontName = "Times New Roman";
            paragraphText.CharacterFormat.FontSize = fontSize;

            return paragraph;
        }

        public static void AutoFit(this TableCollection tableCollection, AutoFitBehaviorType autoFitBehaviorType)
        {
            for (var i = 0; i < tableCollection.Count; i++)
            {
                if (tableCollection[i] is Table table)
                {
                    table.AutoFit(autoFitBehaviorType);
                }
            }
        }

        public static void SetDefaultFormatting(this Paragraph paragraph)
        {
            paragraph.ListFormat.ClearFormatting();

            if (paragraph.FirstChild is TextRange)
            {
                paragraph.Format.ClearFormatting();
            }

            for (var i = 0; i < paragraph.Items.Count; i++)
            {
                if (paragraph.Items[i] is TextRange textRange)
                {
                    textRange.CharacterFormat.ClearFormatting();
                    textRange.CharacterFormat.FontName = "Times New Roman";
                    textRange.CharacterFormat.FontSize = 11.0f;
                }
            }
        }
    }
}
