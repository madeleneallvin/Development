using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Allvinskan.Booking.ViewModels;

namespace Allvinskan.Booking.Helpers
{
    public static class Constants
    {
        public enum Status
        {
            LockedForBooking,
            OpenForBooking,
            CustomerSentRequest,
            BookingConfirmed
        }

        
    }
}