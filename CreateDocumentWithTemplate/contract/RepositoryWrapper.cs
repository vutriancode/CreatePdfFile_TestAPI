using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreateDocumentWithTemplate.Contexts;
namespace CreateDocumentWithTemplate.contract
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private DocumentContext _documentContext;
        private PersionBlogRepository _persion;
        public RepositoryWrapper(DocumentContext DcContext)
        {
            _documentContext = DcContext;
        }
        public IPersionBlogRepository PersionBlogRepository
        {
            get
            {
                if (_persion == null)
                {
                    _persion = new PersionBlogRepository(this._documentContext);
                }
                return _persion;
            }
        }

        public void Save()
        {
            this._documentContext.SaveChanges();
        }
    }
}
