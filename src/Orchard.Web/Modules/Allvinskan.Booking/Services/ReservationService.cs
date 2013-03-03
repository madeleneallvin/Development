using Allvinskan.Booking.Models;
using Allvinskan.Booking.ViewModels;
using Orchard;
using Orchard.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Allvinskan.Booking.Services
{
    public interface IReservationService : IDependency
    {
        void UpdateReservation(ContentItem item, ReservationViewModel model);
    }

    public class ReservationService : IReservationService
    {
        public void UpdateReservation(ContentItem item, ReservationViewModel model)
        {
            var sp = item.As<ReservationPart>();
            sp.Duration = model.Duration;
            sp.CustomerDesires = model.CustomerDesires;
            sp.ReservationTime = model.ReservationTime;
            sp.Status = model.StatusId;
            
        }
    }
}