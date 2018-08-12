using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AdministracionUsuarios.WcfService
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        protected readonly DbContext context;

        public Repositorio(DbContext context)
        {
            if (context == null) throw new ArgumentNullException("context");
            this.context = context;
        }
        public T Get(int id)
        {
            return this.context.Set<T>().Find(id);
        }

        public List<T> GetAll()
        {
            return this.context.Set<T>().ToList();
        }

        public void Save(T entity)
        {
            try
            {
                this.context.Set<T>().Add(entity);
                this.context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        public void Edit(T entity)
        {
            try
            {
                this.context.Entry<T>(entity).State = EntityState.Modified;
                this.context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        public void Delete(T entity)
        {
            this.context.Set<T>().Remove(entity);
            this.context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = this.context.Set<T>().Find(id);
            if (entity != null)
            {
                Delete(entity);
            }
        }
    }
}
