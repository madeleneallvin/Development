using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Allvinskan.Booking.Models
{
    public class Status
    {
    }

    public class StatusEntry
    {
        public int Id { get; set; }
        public String Label { get; set; }
        public Enum EnumObject { get; set; }
    }
}