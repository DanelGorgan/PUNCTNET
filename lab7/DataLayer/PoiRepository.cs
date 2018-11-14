using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
        public class PoiRepository : IPoiRepository
        {
            private readonly PoiContext _context;

            public PoiRepository(PoiContext context)
            {
                _context = context;
            }

            public void Create(Poi poi)
            {
                _context.Pois.Add(poi);
                _context.SaveChanges();
            }

            public IReadOnlyList<Poi> GetAll()
            {
                return _context.Pois.ToList();
            }

            public Poi GetById(Guid id)
            {
                return _context.Pois.Find(id);
            }

            public void RemovePoiById(Guid id)
            {
                _context.Remove(GetById(id));
            }

            public void Update(Poi poi)
            {
                _context.Update(poi);
            }
        }
}
