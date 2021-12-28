﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mercado.MVC.Interfaces.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void SaveChangesDb();
        Task<T> GetOneById(int? id);
        Task<IEnumerable<T>> GetAll();
    }
}