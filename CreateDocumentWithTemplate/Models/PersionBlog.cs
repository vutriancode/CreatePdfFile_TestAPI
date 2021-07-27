using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateDocumentWithTemplate.Models
{
    public class PersionBlog: IEntity
    {
        public Guid id { get; set; }

        public string Title { get; set; }
        public string Contents { get; set; }
    }
}
