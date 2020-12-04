using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class Station
    {
        public Station() 
        {
            DestinationRentals = new List<Rental>();
            OriginRentals = new List<Rental>();
            Scooters = new List<Scooter>();
        }
        public Station(String adress, String id, Double latitude, Double longitude) :this()
        {
            Id = id;           
            Address = adress;
            Latitude = latitude;
            Longitude = longitude;
            DestinationRentals = new List<Rental>();
            OriginRentals = new List<Rental>();
            Scooters = new List<Scooter>();
        }
        public void assignScooter(Scooter sc)
        {
            Scooters.Add(sc);
        }
        public Scooter chooseScooterToRent()
        {
            /* int i = 0;
             Scooter[] scooters = Scooters.ToArray<Scooter>();
             Scooter sc = null;
             do
             {
                 if (scooters[i].State == ScooterState.available)
                 {
                     sc = scooters[i];
                 }
                 else { i++; }
             } while (sc == null && i < scooters.Length);
             return sc;*/
            if (Scooters == null || Scooters.Count() == 0) return null;
            return Scooters.First();
        }
        public void removeScooter(Scooter sc)
        {
            Scooters.Remove(sc);
           
        }
    }
}
