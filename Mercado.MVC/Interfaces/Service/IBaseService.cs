﻿using System.Collections.Generic;

namespace Mercado.MVC.Interfaces.Service
{
    public interface IBaseService<T> where T : class
    {
        public IEnumerable<T> GetAll();
        public T GetOneById(int? id);
        public bool Delet(int id);
    }
}
