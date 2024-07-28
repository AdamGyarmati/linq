using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Linq
{
    public class RoomReservation
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("end_date")]
        public DateTime? EndDate { get; set; }

        [Column("start_date")]
        public DateTime? StartDate { get; set; }

        [Column("booking_id")]
        public long? BookingId { get; set; }

        [Column("room_id")]
        public long? RoomId { get; set; }

        public virtual Booking Booking { get; set; }
        public virtual Room Room { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, EndDate: {EndDate}, StartDate: {StartDate}, BookingId: {BookingId}, RoomId: {RoomId}";
        }
    }
}
