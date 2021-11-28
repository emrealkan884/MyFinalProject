using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Gnneric Constraint(Kısıt)
    //class = referans tip olabilir
    //IEntity = T ya IEntity olabilir ya da IEntity implemente eden bir nesne olabilir.
    //new = new lenebilir olmalı(interface new lenemez.Bu sayede T IEntity olamaz)
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null); //Expression bize filtrelemeyi sağlar. filter=null Filtre vermeyedebilirsin demektir.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
