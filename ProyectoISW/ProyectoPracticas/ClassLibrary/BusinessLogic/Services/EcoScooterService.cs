using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoScooter.Entities;
using EcoScooter.Persistence;

namespace EcoScooter.Services
{
    public class EcoScooterService : IEcoScooterService
    {
        private readonly IDAL dal;
        private User usuario = null;
        private Employee empleado = null;

        public EcoScooterService(IDAL dal)
        {
            this.dal = dal;
            usuario = null;
            empleado = null;
        }
        public void addIncident(Incident i) {

            if (dal.GetById<Incident>(i.Id) == null)
            {
                dal.Insert<Incident>(i);
                dal.Commit();
            }
            else throw new ServiceException("Este incidente ya existe. ");
        }
        public void addEcoScooter(EcoScooter.Entities.EcoScooter ecoScooter) {
            //if (dal.GetById<EcoScooter.Entities.EcoScooter>(ecoScooter.Id) == null)
            //{
                dal.Insert<EcoScooter.Entities.EcoScooter>(ecoScooter);
                dal.Commit();
           // }
           // else throw new ServiceException("Este EcoScooter ya existe.");

        }
        public bool loggedAsEmployee()
        {
            return empleado != null;
        }
        public bool loggedAsUser()
        {
            return usuario != null ;
        }
        public User userLogged()
        {
            return usuario;
        }
        public Employee employeeLogged()
        {
            return empleado;
        }
        public User login(string loginusuario, string password)
        {
              int cuenta = 0;
            bool ya = false;
              IEnumerable<User> listaUsuarios = dal.GetAll<User>();
             while (cuenta < listaUsuarios.Count() && ya == false)
             {
                if (listaUsuarios.ElementAt<User>(cuenta).Login.Equals(loginusuario))
                {
                    ya = true;
                }
                cuenta++;
               
                 /**
                    if (listaUsuarios.ElementAt<User>(cuenta).Login.Equals(login) && listaUsuarios.ElementAt<User>(cuenta).Password.Equals(password))
                 {
                     usuario = listaUsuarios.ElementAt<User>(cuenta);
                     lAU = true;
                     return usuario;
                     //Login Usuario
                 }
                 else {

                     usuario = null;
                     lAU = false;
                     return usuario;
                 }
                cuenta++;
                */
             }
             if(ya == false) throw new ServiceException("Usuario incorrecto");
             else
            {
                User usuario1 = listaUsuarios.ElementAt<User>(cuenta - 1);
                if (usuario1.Password.Equals(password)){
                    usuario = usuario1;
                    return usuario;
                } else {
                    throw new ServiceException("contraseña incorrecta");
                }
            }
            //throw new ServiceException("Usuario o contraseña incorrectos"); 

        }
        public Employee login(string dni, int pin)
        {
            IEnumerable<Employee> listaEmpleados = dal.GetAll<Employee>();
            int i = 0;
            bool ya = false;
            while(i < listaEmpleados.Count())
            {
                if (listaEmpleados.ElementAt<Employee>(i).Dni.Equals(dni))
                {
                    ya = true;
                }
                /**if (listaEmpleados.ElementAt<Employee>(i).Dni.Equals(dni) && listaEmpleados.ElementAt<Employee>(i).Pin.Equals(pin))
                {
                    empleado = listaEmpleados.ElementAt<Employee>(i);
                    lAE = true;
                    return empleado;
                    //Login empleado
                }
                else
                {
                   
                    empleado = null;
                    lAE = false;
                    return empleado;
                }*/
                i++;
            }
            if (ya == false) throw new ServiceException("Usuario detectado, no soy empleado");
            else
            {
                Employee empleado1 = listaEmpleados.ElementAt<Employee>(i - 1);
                if (empleado1.Pin.Equals(pin))
                {
                    empleado = empleado1;
                    return empleado;
                }
                else
                {
                    throw new ServiceException("pin incorrecto");
                }
            }

            //throw new ServiceException("Dni o pin incorrectos");
        }
        public void registerScooter(Scooter sc)
        {

               if (dal.Exists<Scooter>(sc.Id)) throw new ServiceException("Scooter registrado anteriormente"); 
               if (sc.State.Equals(ScooterState.inMaintenance)) throw new ServiceException("Scooter en reparacion");
               else
                {
                    dal.Insert<Scooter>(sc); //Inserción base de datos
                    dal.Commit();
                }

            }

            
        
        public void registerStation(Station s)
        {
           // if (loggedAsEmployee())
            //{
              //  if (s.Address == null || s.Id == null || s.Latitude.Equals(null) || s.Equals(null))
               // {
                 //   throw new ServiceException("Faltan datos de la estación");
               // }

                if (!dal.Exists<Station>(s.Id))
                {
                    dal.Insert<Station>(s); //Inserción base de datos
                    dal.Commit();
                }

                else throw new ServiceException("Ya existe la estación");
            }
          //  else throw new ServiceException("Empleado no ha iniciado sesion");
           // }

        public void registerUser(User u1)
        {

            IList<User> users = getAllUsers();
            
            DateTime fechaActual = DateTime.Now;
            int fechaNacimiento = u1.Birthdate.Year;
            int fechaHoy = fechaActual.Year;
            int edad = fechaHoy - fechaNacimiento;

            
            if (edad < 16)
            {
                throw new ServiceException("Usuario menor de 16 años, no puedes registrarte");  //Comprobación Edad
            }
            else if (Math.Floor(Math.Log10(u1.Number) + 1) != 8)
            {
                throw new ServiceException("Número de tarjeta incorrecto"); // Comprobación número de tarjeta
                
            }
            else if(fechaActual > u1.ExpirationDate)
            {
                throw new ServiceException("Tarjeta de credito caducada");//Comprobacion caducidad
            }
            else if (dal.Exists<User>(u1.Dni))
            {
                throw new ServiceException("Este usuario ya existe"); //Comprobación usuario existente
            }
            else if (users.Any<User>(x => x.Login == u1.Login))
            {
                throw new ServiceException("Nombre de usuario en uso, escoja otro");  //Comprobación login usuario
            }

            else {
              //  getEcoScooter().People.Add(u1);
                dal.Insert<User>(u1); //Inserción base de datos
                dal.Commit();
            }
        }
        public void removeAllData()
        {
            dal.RemoveAllData();

        }
        public void rentScooter(Rental renta1)
        {
           ICollection<Scooter> numeroScooters = renta1.OriginStation.Scooters;
            
           
            if (numeroScooters.Any<Scooter>() == false) //Comprobar si hay patinetes en la estacion
             {
                throw new ServiceException("No quedan patinetes en esa estacion");
             }

            for (int i = 0; i < renta1.User.Rentals.Count(); i++)
            {
                if (renta1.User.Rentals.ElementAt<Rental>(i).Scooter.State.Equals(ScooterState.inUse))
                    throw new ServiceException("Devuelva un patín antes de alquilar otro");
            }
            Scooter patin = renta1.Scooter;
            patin.State = ScooterState.inUse;
            Station estOrigen = renta1.OriginStation;
            estOrigen.removeScooter(patin);
            renta1.Scooter.Rentals.Add(renta1);
            dal.Insert<Rental>(renta1);
            dal.Commit();
            
                
        }
        public decimal returnScooter(Rental rental, Station station)
        {
            /*decimal precio = 0;
              if (rental.Equals(null))
              return precio;*/

            if (loggedAsUser())
            {
                if (dal.GetById<Station>(station.Id) != null)  //(station.Id != null) //Comprobacion de si existe o no la estacion
                {
                    if (rental.Scooter.State.Equals(ScooterState.available)) //Comprobacion que el ultimo alquiler no tenga una devolucion
                    {
                        throw new ServiceException("El patin ya tiene una devolución");

                    }
                    else {
                        /* int edad = (int)Math.Floor((DateTime.Now - rental.User.Birthdate).TotalDays / 365);
                         double tarifa = 0.015 * (DateTime.Now - rental.StartDate).TotalMinutes;
                         if (edad < 26)
                         {
                             precio = (decimal)(0.9 * tarifa);
                         }
                         else precio = (decimal)tarifa;

                         rental.EndDate = DateTime.Now; //Actualizar la fecha de entrega
                         rental.DestinationStation = station; //Actualiza la estacion 
                         rental.Scooter.State = ScooterState.available; //Cambia el estado a disponible   

                           dal.Commit();

                         return precio;*/

                        rental.DestinationStation = station;
                        rental.EndDate = DateTime.Now;
                        rental.Scooter.State = ScooterState.available;
                        rental.DestinationStation.assignScooter(rental.Scooter);

                        int edad = (int)Math.Floor((DateTime.Now - rental.User.Birthdate).TotalDays / 365); //calcular edad
                        double tarifa = getEcoScooter().Fare * (DateTime.Now - rental.StartDate).TotalMinutes;
                        if (edad < 26)
                        {
                            rental.Price = (decimal)(0.9 * tarifa);
                        }
                        else rental.Price = (decimal)tarifa;

                        double recargo = 1.0;
                        if (rental.TrackPoints != null)
                        {
                            foreach (TrackPoint gps in rental.TrackPoints)
                            {
                                if (gps.Speed > getEcoScooter().MaxSpeed)
                                {
                                    recargo = recargo + (recargo * 0.1);  // calcula el recargo
                                    rental.Price = rental.Price + (decimal)recargo;
                                }
                            }
                        }
                        dal.Commit();
                        return rental.Price;
                    }
                }
                else
                {
                    throw new ServiceException("No existe esa estacion");   
                }
            }
            else
            {
                throw new ServiceException("El usuario no ha iniciado sesion");  
            }
        }
        public void saveChanges()
        {
            dal.Commit(); //Guarda Cambios
        }
        public Entities.EcoScooter getEcoScooter()
        {
            IList<EcoScooter.Entities.EcoScooter> e = new List<EcoScooter.Entities.EcoScooter>(dal.GetAll<EcoScooter.Entities.EcoScooter>());
            return e.Last<EcoScooter.Entities.EcoScooter>();
        }
        public IList<User> getAllUsers()
        {
            IList<User> u = new List<User>(dal.GetAll<User>());
            return u;
        }
        public IList<Station> getAllStations()
        {
            IList<Station> s = new List<Station>(dal.GetAll<Station>());
            return s;
        }
        public IList<Scooter> getAllScooters()
        {
            IList<Scooter> sc = new List<Scooter>(dal.GetAll<Scooter>());
            return sc;
        }
        public IList<Rental> getAllRentals()
        {
            IList<Rental> r = new List<Rental>(dal.GetAll<Rental>());
            return r;
        }
        public void logout()
        {
            usuario = null;
            empleado = null;
            //Cierre de sesión
        }
        public Station findStationById(String id) {
            Station st = dal.GetById<Station>(id);
            return st;
        }
        public List<Rental> getRentalsByDate(User user, DateTime d1, DateTime d2)
        {
            /* Rental[] lR = user.Rentals.ToArray<Rental>();
             Rental[] aux = new Rental[lR.Length];

             int j = 0;
             for (int i = 0; i < lR.Length; i++) {
                 if (lR[i].EndDate >= d1 && lR[i].EndDate <= d2) {
                     aux[j] = lR[i];
                     j++;

                 }
                 else
                 {
                     throw new ServiceException("Intervalo de fechas incorrecto");
                 }
             }
             List<Rental> listRentals = aux.ToList<Rental>();
             return listRentals;*/

            List<Rental> ren = new List<Rental>();
            foreach (Rental rental in user.Rentals)
            {
                if (rental.StartDate >= d1 && rental.EndDate <= d2)
                {
                    ren.Add(rental);
                }
            }
            return ren;
        }
    }
}
