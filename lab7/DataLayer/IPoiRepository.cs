﻿using DataLayer;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IPoiRepository
    {
        void Create(Poi poi);
        IReadOnlyList<Poi> GetAll();
        Poi GetById(Guid id);
        void RemovePoiById(Guid id);
        void Update(Poi poi);
    }
}
