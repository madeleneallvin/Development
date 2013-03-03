using Allvinskan.Booking.Helpers;
using Allvinskan.Booking.Models;
using Allvinskan.Booking.Services;
using Allvinskan.Booking.ViewModels;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Allvinskan.Booking.Drivers
{
    public class ReservationDriver: ContentPartDriver<ReservationPart>
    {
        private readonly IStatusService _statusService;
        private readonly IReservationService _reservationService;

        public ReservationDriver(
            IStatusService statusService, 
            IReservationService reservationService)
        {
            _statusService = statusService;
            _reservationService = reservationService;
        }

        protected override string Prefix
        {
            get { return "Reservation"; }
        }

        protected override DriverResult Display(ReservationPart part, string displayType, dynamic shapeHelper)
        {
            return ContentShape("Parts_Reservation",
                     () => shapeHelper.Parts_Reservation(
                           Reservation: part.Record
                           
                     ));
        }

        // GET
        protected override DriverResult Editor(ReservationPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_Reservation_Edit", () => shapeHelper
                .EditorTemplate(TemplateName: "Parts/Reservation", Model: BuildViewModel(part), Prefix: Prefix));
        }

        // POST
        protected override DriverResult Editor(ReservationPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            ReservationViewModel rvm = new ReservationViewModel();

            updater.TryUpdateModel(rvm, Prefix, null, null);

            if (part.ContentItem.Id != 0)
            {
                _reservationService.UpdateReservation(part.ContentItem, rvm);
            }

            return Editor(part, shapeHelper);
        }

        private ReservationViewModel BuildViewModel(ReservationPart part) 
        {
            ReservationViewModel vm = new ReservationViewModel
            {
                Duration = part.Duration,
                ReservationTime = part.ReservationTime,
                //CustomerDesires = part.CustomerDesires,
                Statuses = _statusService.GetStatuses(),
                StatusId = part.Status
            };

            return vm;
        }
    }
}