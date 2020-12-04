using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class Rental
    {
        Incident lastIncident = null;
         public Rental()
        {
            TrackPoints = new List<TrackPoint>();
        }
        public Rental(DateTime startDate,  Station originStation, Scooter scooter, User user)
        {
            StartDate = startDate; 
            OriginStation = originStation;
            Scooter = scooter;
            User = user;

            TrackPoints = new List<TrackPoint>();
        }

        public void addIncident(Incident i)
        {
            lastIncident = i;
            this.Scooter.State = ScooterState.inMaintenance;
        }
    }
}
