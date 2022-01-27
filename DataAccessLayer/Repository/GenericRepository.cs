using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Add(T t)
        {
            using var context = new Context();
            context.Add(t);
        }

        public void Delete(T t)
        {
            using var context = new Context();
            context.Remove(t);
        }

        public List<T> GetAll()
        {
            using var context = new Context();
            return context.Set<T>().ToList();
        }

        public void Update(T t)
        {
            using var context = new Context();
            context.Update(t);
        }
    }
}
