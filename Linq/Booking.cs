using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Linq
{
    public class Booking
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("date_of_booking")]
        public DateTime? DateOfBooking { get; set; }

        [Column("number_of_guests")]
        public int? NumberOfGuests { get; set; }

        [Column("room_price")]
        public double? RoomPrice { get; set; }

        [Column("remark")]
        public string Remark { get; set; }

        [Column("guest")]
        public long? Guest { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<RoomReservation> RoomReservations { get; set; }
        public virtual ICollection<ServiceCost> ServiceCosts { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, DateOfBooking: {DateOfBooking}, NumberOfGuests: {NumberOfGuests}, RoomPrice: {RoomPrice}, Remark: {Remark}, Guest: {Guest}";
        }
    }
}
