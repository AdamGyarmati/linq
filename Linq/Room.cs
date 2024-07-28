using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Linq
{
    public class Room
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("number_of_beds")]
        public int? NumberOfBeds { get; set; }

        [Column("price_per_night")]
        public double? PricePerNight { get; set; }

        [Column("room_area")]
        public int? RoomArea { get; set; }

        [Column("room_image_url")]
        public string RoomImageUrl { get; set; }

        [Column("room_name")]
        public string RoomName { get; set; }

        [Column("room_type")]
        public string RoomType { get; set; }

        [Column("hotel_id")]
        public long? HotelId { get; set; }

        public virtual Hotel Hotel { get; set; }
        public virtual ICollection<RoomReservation> RoomReservations { get; set; }
        public virtual ICollection<RoomFeature> RoomFeatures { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Description: {Description}, NumberOfBeds: {NumberOfBeds}, PricePerNight: {PricePerNight}, RoomArea: {RoomArea}, RoomImageUrl: {RoomImageUrl}, RoomName: {RoomName}, RoomType: {RoomType}, HotelId: {HotelId}";
        }
    }
}
