using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnageAPI.Repositories.Impl
{
    using Models;
    public class ListRepository<T> : Repository<T> where T : class, Model
    {
        protected List<T> dataSource = new List<T>();
        public void Delete(int id)
        {
            this.dataSource[id] = null;
        }

        public IEnumerable<T> FindAll()
        {
            return this.dataSource;
        }

        public T FindById(int id)
        {
            return this.dataSource[id];
        }

        public T Save(T entity)
        {
            entity.Id = this.dataSource.Count();
            this.dataSource.Add(entity);
            return entity;
        }

        public T Update(T entity)
        {
            this.dataSource[entity.Id] = entity;
            return entity;
        }
    }
}
