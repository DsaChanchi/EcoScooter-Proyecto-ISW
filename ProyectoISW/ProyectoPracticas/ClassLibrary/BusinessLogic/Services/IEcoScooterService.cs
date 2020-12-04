using EcoScooter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Services
{
    public interface IEcoScooterService
    {
        void removeAllData();
        void saveChanges();
        User userLogged();
        Employee employeeLogged();
        bool loggedAsEmployee();
        bool loggedAsUser();
        void registerUser(User u1);
        User login(string login,string password);
        Employee login(string login, int password);
        void registerStation(Station s);
        void registerScooter( Scooter sc);
        void rentScooter(Rental renta1);
        decimal returnScooter(Rental rental, Station station);
        void addEcoScooter(EcoScooter.Entities.EcoScooter ecoScooter);
        void addIncident(Incident i);
        EcoScooter.Entities.EcoScooter getEcoScooter();
        IList<User> getAllUsers();
        IList<Station> getAllStations();
        IList<Scooter> getAllScooters();
        IList<Rental> getAllRentals();
        void logout();
        Station findStationById(String id);
        List<Rental> getRentalsByDate(User user, DateTime d1, DateTime d2);
    }
}