using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreateDocumentWithTemplate.Models;
using CreateDocumentWithTemplate.Contexts;

namespace CreateDocumentWithTemplate.contract
{
    public class PersionBlogRepository : RepositoryBase<PersionBlog>, IPersionBlogRepository
    {
        public PersionBlogRepository(DocumentContext DcContext) : base(DcContext)
        {
        }
    }
}