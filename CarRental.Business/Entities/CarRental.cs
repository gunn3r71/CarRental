using System;

namespace CarRental.Business.Entities
{
    public class CarRental
    {
        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null;
        }

        public DateTime Start { get; private set; }
        public DateTime Finish { get; private set; }

        public Vehicle Vehicle { get; private set; }
        public Invoice Invoice { get; private set; }
    }
}
