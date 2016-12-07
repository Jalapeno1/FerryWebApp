using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Toolbox3_Library_Hundige;

namespace FerryFrontend.Controllers
{
    //STUB LOGIC
    public class FerryController : Toolbox3_Library_Hundige.CommonInterface
    {
        public List<Route> GetAllRoutes()
        {
            return new List<Route>()
            {
                new Route(
                    new Departure(
                        new Ferry("large ferry", 150, 70, 20000, true), DateTime.Now),
                    "destiantion 1", new TimeSpan(2,40,0)),
                new Route(
                    new Departure(
                        new Ferry("medium ferry", 120, 40, 15000, true), DateTime.Now),
                    "destiantion 1", new TimeSpan(1,30,0))
            };
        }

        public List<Departure> GetAllDepartures()
        {
            return new List<Departure>()
            {
                new Departure(
                        new Ferry("large ferry", 150, 70, 20000, true), DateTime.Now),
                new Departure(
                        new Ferry("medium ferry", 120, 40, 15000, true), DateTime.Now),
                new Departure(
                        new Ferry("small ferry", 80, 0, 10000, true), DateTime.Now)
            };
        }

        public List<Reservation> GetReservations(Departure departure)
        {
            var completelist = new List<Reservation>()
            {
                new Reservation(new Departure(
                        new Ferry("large ferry", 150, 70, 20000, true), DateTime.Now), 01, false),
                new Reservation(new Departure(
                        new Ferry("large ferry", 150, 70, 20000, true), DateTime.Now), 02, false),
                new Reservation(new Departure(
                        new Ferry("large ferry", 150, 70, 20000, true), DateTime.Now), 03, false),
                new Reservation(new Departure(
                        new Ferry("large ferry", 150, 70, 20000, true), DateTime.Now), 04, false),

                new Reservation(new Departure(
                        new Ferry("medium ferry", 120, 40, 15000, true), DateTime.Now), 01, false),
                new Reservation(new Departure(
                        new Ferry("medium ferry", 120, 40, 15000, true), DateTime.Now), 02, false),
                new Reservation(new Departure(
                        new Ferry("medium ferry", 120, 40, 15000, true), DateTime.Now), 03, false),
                new Reservation(new Departure(
                        new Ferry("medium ferry", 120, 40, 15000, true), DateTime.Now), 04, false),

                new Reservation(new Departure(
                        new Ferry("small ferry", 80, 0, 10000, true), DateTime.Now), 01, false),
                new Reservation(new Departure(
                        new Ferry("small ferry", 80, 0, 10000, true), DateTime.Now), 02, false),
                new Reservation(new Departure(
                        new Ferry("small ferry", 80, 0, 10000, true), DateTime.Now), 03, false),
                new Reservation(new Departure(
                        new Ferry("small ferry", 80, 0, 10000, true), DateTime.Now), 04, false),

            };

            return completelist.Where(
                r => r.RefDeparture.DateAndTime == departure.DateAndTime 
                || r.RefDeparture.SailingFerry.Name == departure.SailingFerry.Name)
                .ToList();
        }

        public List<Ferry> GetAllFerries()
        {
            return new List<Ferry>()
            {
                new Ferry("large ferry", 150, 70, 20000, true),
                new Ferry("medium ferry", 120, 40, 15000, true),
                new Ferry("small ferry", 80, 0, 10000, true)
            };
        }


        public bool CreateReservation(Departure departure)
        {
            return true;
        }

        public bool DeleteReservation(Reservation reservation)
        {
            return true;
        }

        public bool CreateFerry(string name, int peopleCapacity, int vehicleCapacity, int weightCapacityInKg, bool isReserve)
        {
            return true;
        }

        public bool DeleteFerry(Ferry ferry)
        {
            return true;
        }

        public List<Ferry> GetReserveFerries(int minimumPeopleCapacity, int minimumVehicleCapacity, int minimumWeightCapacity)
        {
            return new List<Ferry>()
            {
                new Ferry("large ferry", 150, 70, 20000, true),
                new Ferry("medium ferry", 120, 40, 15000, true),
                new Ferry("small ferry", 80, 0, 10000, true)
            };
        }

        public bool CheckOutReserveFerry(Ferry ferry)
        {
            return true;
        }

        public bool CreateRoute(Departure departure, string destination, TimeSpan duration)
        {
            return true;
        }

        public bool DeleteRoute(Route route)
        {
            return true;
        }

        public bool AddDeparture(Ferry ferry, DateTime DateAndTime)
        {
            return true;
        }

        public bool DeleteDeparture(Departure departure)
        {
            return true;
        }

        public bool ChangeFerryForDeparture(Departure departure, Ferry newFerry)
        {
            return true;
        }

        public bool CreateAccount(Customer.ForeignerOrLocal foreignerOrLocal, string username, string password, string email)
        {
            return true;
        }

        public bool DeleteAccount(Customer customer)
        {
            return true;
        }
    }
}