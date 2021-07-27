using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreateDocumentWithTemplate.Contexts;

namespace CreateDocumentWithTemplate.contract
{
    public interface IReposityBase<T>
    {
        IEnumerable<T> FindAll();
        T FindByID(Guid id);

        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
