using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //T:class demek T referans tip olmalı demek (T yerine int yazamaz mesela, çünkü int değer tip)
        // filter = null demek filtre vermeyedebilirsin demek!
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //lamda expression ile filtreleyebilirim demek bura.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
