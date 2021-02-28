using System;
using System.Collections.Generic;
using System.Text;

namespace ProAgil.Dominio.Interfaces
{
    public interface IBaseRepositorio<TEntity>: IDisposable where TEntity:class
    {
        void Add(TEntity entity);
        IEnumerable<TEntity> ToList();
        TEntity First(int id);
        void Update(TEntity entity);
        void Delete(int id);
       


    }
}
