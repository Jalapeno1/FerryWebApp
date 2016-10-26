using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FerryFrontend.Models;

namespace FerryFrontend.Interfaces
{
    public interface ICommonInterface
    {
        //Create reservation
        /// <summary>
        /// Creates a new reservation, which tickets can reference.
        /// </summary>
        /// <primaryActor>Customer</primaryActor>
        /// <precondition>Customer have created an account and is logged in to the system</precondition>
        /// <postcondition>The customer makes a successful ticket(s) reservation</postcondition>
        /// <param name="departure"></param>
        /// <returns>bool success</returns>
        bool CreateReservation(Departure departure);

        //Delete reservation
        /// <summary>
        /// Delete a targeted reservation
        /// </summary>
        /// <primaryActor>Customer</primaryActor>
        /// <precondition>Customer have created an account and is logged in to the system, and has a reservation</precondition>
        /// <postcondition>The customer deletes a ticket reservation</postcondition>
        /// <param name="reservation"></param>
        /// <returns>bool success</returns>
        bool DeleteReservation(Reservation reservation);

        //Create ferry
        /// <summary>
        /// Create a new ferry in the system, which departures can make use of.
        /// </summary>
        /// <primaryActor>Administrator</primaryActor>
        /// <precondition>User has access to Admin program</precondition>
        /// <postcondition>A new ferry has been created</postcondition>
        /// <param name="name"></param>
        /// <param name="peopleCapacity"></param>
        /// <param name="vehicleCapacity"></param>
        /// <param name="weightCapacityInKg"></param>
        /// <param name="isReserve"></param>
        /// <returns>bool success</returns>
        bool CreateFerry(string name, int peopleCapacity, int vehicleCapacity, int weightCapacityInKg, bool isReserve);

        //Delete ferry
        /// <summary>
        /// Delete a targeted ferry
        /// Also updates departures that use this ferry.
        /// </summary>
        /// <primaryActor>Administrator</primaryActor>
        /// <precondition>User has access to Admin program, a ferry exists</precondition>
        /// <postcondition>Targeted ferry has been deleted</postcondition>
        /// <param name="ferry"></param>
        /// <returns>bool success</returns>
        bool DeleteFerry(Ferry ferry);

        //Order reserve ferry
        /// <summary>
        /// Get A list of ferries that are reserve, so that admin can choose.
        /// If wanted, minimum requirements for the ferry can be entered (minimum capacity etc)
        /// </summary>
        /// <primaryActor>Administrator</primaryActor>
        /// <precondition>User has access to Admin program, a reserve ferry exists</precondition>
        /// <postcondition>A list of available reserve ferries are presented</postcondition>
        /// <param name="minimumPeopleCapacity"></param>
        /// <param name="minimumVehicleCapacity"></param>
        /// <param name="minimumWeightCapacity"></param>
        /// <returns>List of ferries that are reserve</returns>
        List<Ferry> GetReserveFerries(int minimumPeopleCapacity, int minimumVehicleCapacity, int minimumWeightCapacity);

        /// <summary>
        /// Set an existing reserve ferry as an actively used ferry, so departures can make use of it.
        /// </summary>
        /// <primaryActor>Administrator</primaryActor>
        /// <precondition>User has access to Admin program, a reserve ferry exists</precondition>
        /// <postcondition>Targeted ferry been changed from reserve to not being reserve</postcondition>
        /// <param name="ferry"></param>
        /// <returns></returns>
        bool CheckOutReserveFerry(Ferry ferry);

        //Create route
        /// <summary>
        /// Create a new route
        /// </summary>
        /// <primaryActor>Administrator</primaryActor>
        /// <precondition>User has access to Admin program, a departure exists</precondition>
        /// <postcondition>A new route has been created</postcondition>
        /// <param name="departure"></param>
        /// <param name="destination"></param>
        /// <param name="duration"></param>
        /// <returns>bool success</returns>
        bool CreateRoute(Departure departure, string destination, TimeSpan duration);

        //Delete route
        /// <summary>
        /// Delete a targeted route
        /// </summary>
        /// <primaryActor>Administrator</primaryActor>
        /// <precondition>User has access to Admin program, a route exists</precondition>
        /// <postcondition>Targeted route has been deleted</postcondition>
        /// <param name="route"></param>
        /// <returns>bool success</returns>
        bool DeleteRoute(Route route);

        //Add ferry to route
        /// <summary>
        /// Create a new departure, and assign existing ferry to it.
        /// </summary>
        /// <primaryActor>Administrator</primaryActor>
        /// <precondition>User has access to Admin program, a ferry exists</precondition>
        /// <postcondition>New departure with argument ferry is created</postcondition>
        /// <param name="ferry"></param>
        /// <param name="DateAndTime"></param>
        /// <returns>bool success</returns>
        bool AddDeparture(Ferry ferry, DateTime DateAndTime);

        //Delete ferry from route
        /// <summary>
        /// Delete targeted departure
        /// </summary>
        /// <primaryActor>Administrator</primaryActor>
        /// <precondition>User has access to Admin program, a departure exists</precondition>
        /// <postcondition>Targeted departure has been deleted</postcondition>
        /// <param name="departure"></param>
        /// <returns>bool success</returns>
        bool DeleteDeparture(Departure departure);

        /// <summary>
        /// Change the used ferry for an existing departure
        /// </summary>
        /// <primaryActor>Administrator</primaryActor>
        /// <precondition>User has access to Admin program, a departure exists</precondition>
        /// <postcondition>Targeted departure had assigned ferry changed to a different ferry</postcondition>
        /// <param name="departure"></param>
        /// <param name="newFerry"></param>
        /// <returns>bool success</returns>
        bool ChangeFerryForDeparture(Departure departure, Ferry newFerry);

        //Create account
        /// <summary>
        /// Create a new customer account
        /// </summary>
        /// <primaryActor>Customer</primaryActor>
        /// <precondition>User has an email which can be used to register account</precondition>
        /// <postcondition>A User Account has been created</postcondition>
        /// <param name="foreignerOrLocal"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <returns>bool success</returns>
        bool CreateAccount(Customer.ForeignerOrLocal foreignerOrLocal, string username, string password, string email);

        //Delete account
        /// <summary>
        /// Delete targeted account
        /// </summary>
        /// <primaryActor>Customer</primaryActor>
        /// <precondition>Customer has created an account and is logged in to the system</precondition>
        /// <postcondition>Customer Account has been deleted</postcondition>
        /// <param name="customer"></param>
        /// <returns>bool success</returns>
        bool DeleteAccount(Customer customer);
    }
}
