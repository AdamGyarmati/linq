using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Linq
{
    public class Hotel
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("avg_rate")]
        public double? AvgRate { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("hotel_type")]
        public string HotelType { get; set; }

        [Column("latitude")]
        public double? Latitude { get; set; }

        [Column("longitude")]
        public double? Longitude { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("postal_code")]
        public string PostalCode { get; set; }

        [Column("street_address")]
        public string StreetAddress { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<HotelFeature> HotelFeatures { get; set; }
        public virtual ICollection<HotelImageUrl> HotelImageUrls { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, AvgRate: {AvgRate}, City: {City}, Description: {Description}, HotelType: {HotelType}, Latitude: {Latitude}, Longitude: {Longitude}, Name: {Name}, PostalCode: {PostalCode}, StreetAddress: {StreetAddress}";
        }
    }
}
