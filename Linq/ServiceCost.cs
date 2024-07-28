using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Linq
{
    public class ServiceCost
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("booking_id")]
        public long BookingId { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("price")]
        public double? Price { get; set; }

        [Column("volume")]
        public double? Volume { get; set; }

        public virtual Booking Booking { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, BookingId: {BookingId}, Description: {Description}, Price: {Price}, Volume: {Volume}";
        }
    }
}
