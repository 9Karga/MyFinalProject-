﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccsess

    //Core katmanı referans almaz.
{       
    //Generic constraint
    //class = referans tip olmalı.
    //IEntity : IEntity olmalı ya da iplamente etmeli.
    //new() : new' lenebilir olmalı.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {

            List<T> GetAll(Expression<Func<T, bool>> filter = null);
            T Get(Expression<Func<T, bool>> filter);
            void Add(T entity);
            void Update(T entity);
            void Delete(T entity);

    }
}
