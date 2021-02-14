using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Interfaces
{
    public interface IWordHandler
    {
        ICollection<TParagraph> GetParagraphs<TParagraph>(string filepath) where TParagraph : class;

        void Write<TSection>(string filepath, IWordTemplate<TSection> template) where TSection : class;
    }
}
