using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Linq
{
    public class RoomFeature
    {
        [Column("room_id")]
        public long RoomId { get; set; }

        [Column("room_room_features")]
        public string Feature { get; set; }

        public virtual Room Room { get; set; }

        public override string ToString()
        {
            return $"RoomId: {RoomId}, Feature: {Feature}";
        }
    }
}
