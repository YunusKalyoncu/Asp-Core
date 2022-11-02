﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.DataAccessLayer.Abstract
{
    public interface IGenereicDal<T> where T:class
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();

    }
}