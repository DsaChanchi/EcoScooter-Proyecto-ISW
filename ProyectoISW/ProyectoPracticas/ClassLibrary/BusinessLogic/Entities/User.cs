using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class User : Person
    {
        public User():base() {
            Rentals = new List<Rental>();

        }
        public User(DateTime birthDate, String dni, String email, String name, int telephon, int cvv, DateTime expirationDate, String login, int number, String password) : base(birthDate, dni, email, name, telephon)
        {
            Cvv = cvv;
            ExpirationDate = expirationDate;
            Login = login;
            Number = number;
            Password = password;
            Rentals = new List<Rental>();
        }
        public Rental lastRental()
        {
            return Rentals.Last<Rental>();
        }
    }
}
