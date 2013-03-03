using Allvinskan.Booking.Models;
using Orchard.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Allvinskan.Booking.ViewModels
{
    public class ReservationViewModel
    {
        public int Duration { get; set; }
        public DateTime? ReservationTime { get; set; }
        public UserPart Customer { get; set; }
        public String CustomerDesires { get; set; }

        public int StatusId {get;set;}
        public List<StatusEntry> Statuses { get; set; }
    }

    
}