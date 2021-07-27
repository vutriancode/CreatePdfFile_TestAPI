using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreateDocumentWithTemplate.Contexts;
using CreateDocumentWithTemplate.Models;
namespace CreateDocumentWithTemplate.contract
{
    public abstract class RepositoryBase<T>:IReposityBase<T> where T :class,IEntity
    {
        protected DocumentContext DocumentContext { get; set; }
        public RepositoryBase(DocumentContext DcContext)
        {
            this.DocumentContext = DcContext;
        }
        public IEnumerable<T> FindAll()
        {
            return this.DocumentContext.Set<T>();
        }

        public T FindByID(Guid id)
        {
            return this.DocumentContext.Set<T>().FirstOrDefault(e=>e.id==id);

        }

        public void Create(T entity)
        {
            this.DocumentContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.DocumentContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.DocumentContext.Set<T>().Remove(entity);
        }
    }
}