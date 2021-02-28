using ProAgil.Dominio.Interfaces;
using ProAgil.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProAgil.Repositorio.Repositorio
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {

        protected readonly DataContext Context;


      

        public BaseRepositorio(DataContext context)
        {
            Context = context;
        }

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            Context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }      

        public TEntity First(int id)
        {
           return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ToList()
        {
           return Context.Set<TEntity>().ToList();
        }

        public void Update(TEntity entity)
        {
            Context.Set<TEntity>().Update(entity);
            Context.SaveChanges();

        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
