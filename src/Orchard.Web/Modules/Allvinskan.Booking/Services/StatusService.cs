using Allvinskan.Booking.Helpers;
using Allvinskan.Booking.Models;
using Orchard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Allvinskan.Booking.Services
{
    public interface IStatusService : IDependency
    {
        List<StatusEntry> GetStatuses();
    }
    public class StatusService : IStatusService
    {
        public List<StatusEntry> GetStatuses()
        {
            return new List<StatusEntry>
                {
                    new StatusEntry{Id =1 , Label = "Låst för bokning", EnumObject = Constants.Status.LockedForBooking},
                    new StatusEntry{Id =2 , Label = "Öppen för bokning av kund", EnumObject = Constants.Status.OpenForBooking},
                    new StatusEntry{Id =3 , Label = "Kund har skickat en förfrågan", EnumObject = Constants.Status.CustomerSentRequest},
                    new StatusEntry{Id =4 , Label = "Bokningen bekräftad", EnumObject = Constants.Status.BookingConfirmed}
                };
        }
    }
}