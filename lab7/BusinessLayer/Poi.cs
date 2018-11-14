using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class Poi
    {
        public Poi()
        {
            
        }

        public int Id { set; get; }

        public string Name { set; get; }

        public string Description { set; get; }

        public int CityId { set; get; }
    }
}
