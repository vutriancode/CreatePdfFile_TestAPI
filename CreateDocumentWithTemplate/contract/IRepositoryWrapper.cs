using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateDocumentWithTemplate.contract
{
    public interface IRepositoryWrapper
    {
        IPersionBlogRepository PersionBlogRepository { get; }
        void Save();
    }
}
