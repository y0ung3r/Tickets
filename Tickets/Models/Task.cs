using Spire.Doc.Documents;
using System.Collections.Generic;

namespace Tickets.Models
{
    public class Task
    {
        public Paragraph Condition { get; set; } 

        public ICollection<Paragraph> Pictures { get; set; }

        public Task()
        {
            Pictures = new List<Paragraph>();
        }
    }
}
