using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateDocumentWithTemplate.Models
{
    public class DocumentTemplate:IEntity
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
    }
}