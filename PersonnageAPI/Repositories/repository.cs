using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnageAPI.Repositories
{
    public interface Repository<T>
    {
        public IEnumerable<T> FindAll();
        public T save(T entity);
        public T Update(T entity);
        public T FindById(int id);
        public void Delete(int id);
    }
}