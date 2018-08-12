using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionUsuarios.WcfService
{
  public  interface IRepositorio<T> where T : class
    {
        T Get(int id);
        List<T> GetAll();
        void Save(T entity);
        void Delete(T entity);
        void Delete(int id);
    }
}
