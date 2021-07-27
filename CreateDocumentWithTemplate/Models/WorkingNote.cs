
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateDocumentWithTemplate.Models
{
    public class WorkingNote: IEntity
    {
        public Guid id { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
