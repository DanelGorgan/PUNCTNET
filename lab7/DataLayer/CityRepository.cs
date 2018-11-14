using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class CityRepository : ICityRepository
    {
        private readonly CityContext _context;

        public CityRepository(CityContext context)
        {
            _context = context;
        }

        public void Create(City city)
        {
            _context.Cities.Add(city);
            _context.SaveChanges();
        }

        public IReadOnlyList<City> GetAll()
        {
            return _context.Cities.ToList();
        }

        public City GetById(Guid id)
        {
            return _context.Cities.Find(id);
        }

        public void RemoveCityById(Guid id)
        {
            _context.Remove(GetById(id));
        }

        public void Update(City city)
        {
            _context.Update(city);
        }
    }
}
