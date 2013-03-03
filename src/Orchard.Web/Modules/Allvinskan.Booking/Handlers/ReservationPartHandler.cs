using Allvinskan.Booking.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Allvinskan.Booking.Handlers
{
    public class ReservationPartHandler: ContentHandler
    {
        public ReservationPartHandler(IRepository<ReservationPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}