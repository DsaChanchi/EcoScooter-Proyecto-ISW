using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class EcoScooter
    {
        public EcoScooter()
        {
            People = new List<Person>();
            Scooters = new List<Scooter>();
            Stations = new List<Station>();
            Employees = new List<Employee>();
        }
        public EcoScooter(Double discountYounger, Double fare, Double maxSpeed, Employee employees):this()
        {
            DiscountYounger = discountYounger;
            Fare = fare;
            MaxSpeed = maxSpeed;

            People = new List<Person>();
            Employees = new List<Employee>();
            Stations = new List<Station>();
            Scooters = new List<Scooter>();

            Employees.Add(employees);
        }
             
    }
}
