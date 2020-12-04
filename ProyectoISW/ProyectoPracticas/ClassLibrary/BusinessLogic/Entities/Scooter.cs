using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class Scooter
    {
        public Scooter()
        {
            Rentals = new List<Rental>();
            PlanningWork = new List<PlanningWork>();


        }
        public Scooter( DateTime registerDate, ScooterState state):this() 
        {
            RegisterDate = registerDate;
            State = state;
            Rentals = new List<Rental>();
            PlanningWork = new List<PlanningWork>();
        }
        public Rental lastRental()
        {
            return Rentals.Last<Rental>();
        }

    }
}
