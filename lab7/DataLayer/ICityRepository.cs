using System;
using System.Collections.Generic;

namespace DataLayer
{
    public interface ICityRepository
    {
        void Create(City city);
        IReadOnlyList<City> GetAll();
        City GetById(Guid id);
        void RemoveCityById(Guid id);
        void Update(City city);
    }
}