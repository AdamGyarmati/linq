using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Linq
{
    public class Account
    {
        [Key]
        [Column("user_id")]
        public long UserId { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("firstname")]
        public string FirstName { get; set; }

        [Column("hotel_id")]
        public long? HotelId { get; set; }

        [Column("is_enabled")]
        public bool? IsEnabled { get; set; }

        [Column("lastname")]
        public string LastName { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("registration_date")]
        public DateTime? RegistrationDate { get; set; }

        [Column("role")]
        public string Role { get; set; }

        [Column("username")]
        public string Username { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<ConfirmationToken> ConfirmationTokens { get; set; }

        public override string ToString()
        {
            return $"UserId: {UserId}, Address: {Address}, Email: {Email}, FirstName: {FirstName}, HotelId: {HotelId}, IsEnabled: {IsEnabled}, LastName: {LastName}, Password: {Password}, RegistrationDate: {RegistrationDate}, Role: {Role}, Username: {Username}";
        }
    }
}
