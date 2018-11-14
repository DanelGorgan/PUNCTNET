using System;

namespace DataLayer
{
    public class City
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public bool IsVisited { get; set; }

        public City(Guid Id, string Description)
        {
            this.Id = Id;
            this.Description = Description;
        }

        public City()
        {

        }
    }
}
