﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ITSRunningDbRepository
{
    public interface IRepositoryBase<T, TKey>
        where T : new()
        where TKey : struct
    {
        IEnumerable<T> Get();

        T Get(int id);

        void Update(T value);

        void Insert(T value);

        void Delete(TKey id);

    }
}
