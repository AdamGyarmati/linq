using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Linq
{
    public class HotelImageUrl
    {
        [Column("hotel_id")]
        public long HotelId { get; set; }

        [Column("hotel_image_urls")]
        public string ImageUrl { get; set; }

        public virtual Hotel Hotel { get; set; }

        public override string ToString()
        {
            return $"HotelId: {HotelId}, ImageUrl: {ImageUrl}";
        }
    }
}
