using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;
using Orchard.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Allvinskan.Booking.Models
{
    public class ReservationPartRecord : ContentPartRecord
    {
        public virtual int Duration { get; set; }
        public virtual DateTime? ReservationTime { get; set; }
        //public virtual UserPart Customer { get; set; }
        public virtual String CustomerDesires { get; set; }
        public virtual int Status { get; set; }
    }

    public class ReservationPart : ContentPart<ReservationPartRecord>
    {
        public int Duration
        {
            get { return Record.Duration; }
            set { Record.Duration = value; }
        }

        public DateTime? ReservationTime
        {
            get { return Record.ReservationTime; }
            set { Record.ReservationTime = value; }
        }

        //public UserPart Customer
        //{
        //    get { return Record.Customer; }
        //    set { Record.Customer = value; }
        //}

        public String CustomerDesires
        {
            get { return Record.CustomerDesires; }
            set { Record.CustomerDesires = value; }
        }

        public int Status
        {
            get { return Record.Status; }
            set { Record.Status = value; }
        }
    }
}