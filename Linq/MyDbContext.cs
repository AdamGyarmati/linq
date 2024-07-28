using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class MyDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<ConfirmationToken> ConfirmationTokens { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelFeature> HotelFeatures { get; set; }
        public DbSet<HotelImageUrl> HotelImageUrls { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomReservation> RoomReservations { get; set; }
        public DbSet<RoomFeature> RoomFeatures { get; set; }
        public DbSet<ServiceCost> ServiceCosts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Database=hotel;User=root;Password=test1234;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Account configuration
            modelBuilder.Entity<Account>()
                .ToTable("account")
                .HasKey(a => a.UserId);
            modelBuilder.Entity<Account>()
                .Property(a => a.UserId).HasColumnName("user_id");
            modelBuilder.Entity<Account>()
                .Property(a => a.Address).HasColumnName("address");
            modelBuilder.Entity<Account>()
                .Property(a => a.Email).HasColumnName("email");
            modelBuilder.Entity<Account>()
                .Property(a => a.FirstName).HasColumnName("firstname");
            modelBuilder.Entity<Account>()
                .Property(a => a.HotelId).HasColumnName("hotel_id");
            modelBuilder.Entity<Account>()
                .Property(a => a.IsEnabled).HasColumnName("is_enabled");
            modelBuilder.Entity<Account>()
                .Property(a => a.LastName).HasColumnName("lastname");
            modelBuilder.Entity<Account>()
                .Property(a => a.Password).HasColumnName("password");
            modelBuilder.Entity<Account>()
                .Property(a => a.RegistrationDate).HasColumnName("registration_date");
            modelBuilder.Entity<Account>()
                .Property(a => a.Role).HasColumnName("role");
            modelBuilder.Entity<Account>()
                .Property(a => a.Username).HasColumnName("username");
            modelBuilder.Entity<Account>()
                .HasMany(a => a.Bookings)
                .WithOne(b => b.Account)
                .HasForeignKey(b => b.Guest);

            // Booking configuration
            modelBuilder.Entity<Booking>()
                .ToTable("booking")
                .HasKey(b => b.Id);
            modelBuilder.Entity<Booking>()
                .Property(b => b.Id).HasColumnName("id");
            modelBuilder.Entity<Booking>()
                .Property(b => b.DateOfBooking).HasColumnName("date_of_booking");
            modelBuilder.Entity<Booking>()
                .Property(b => b.NumberOfGuests).HasColumnName("number_of_guests");
            modelBuilder.Entity<Booking>()
                .Property(b => b.RoomPrice).HasColumnName("room_price");
            modelBuilder.Entity<Booking>()
                .Property(b => b.Remark).HasColumnName("remark");
            modelBuilder.Entity<Booking>()
                .Property(b => b.Guest).HasColumnName("guest");

            // ConfirmationToken configuration
            modelBuilder.Entity<ConfirmationToken>()
                .ToTable("confirmation_token")
                .HasKey(ct => ct.TokenId);
            modelBuilder.Entity<ConfirmationToken>()
                .Property(ct => ct.TokenId).HasColumnName("token_id");
            modelBuilder.Entity<ConfirmationToken>()
                .Property(ct => ct.ConfirmationTokenValue).HasColumnName("confirmation_token");
            modelBuilder.Entity<ConfirmationToken>()
                .Property(ct => ct.CreatedDate).HasColumnName("created_date");
            modelBuilder.Entity<ConfirmationToken>()
                .Property(ct => ct.UserId).HasColumnName("user_id");
            modelBuilder.Entity<ConfirmationToken>()
                .HasOne(ct => ct.Account)
                .WithMany(a => a.ConfirmationTokens)
                .HasForeignKey(ct => ct.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Hotel configuration
            modelBuilder.Entity<Hotel>()
                .ToTable("hotel")
                .HasKey(h => h.Id);
            modelBuilder.Entity<Hotel>()
                .Property(h => h.Id).HasColumnName("id");
            modelBuilder.Entity<Hotel>()
                .Property(h => h.AvgRate).HasColumnName("avg_rate");
            modelBuilder.Entity<Hotel>()
                .Property(h => h.City).HasColumnName("city");
            modelBuilder.Entity<Hotel>()
                .Property(h => h.Description).HasColumnName("description");
            modelBuilder.Entity<Hotel>()
                .Property(h => h.HotelType).HasColumnName("hotel_type");
            modelBuilder.Entity<Hotel>()
                .Property(h => h.Latitude).HasColumnName("latitude");
            modelBuilder.Entity<Hotel>()
                .Property(h => h.Longitude).HasColumnName("longitude");
            modelBuilder.Entity<Hotel>()
                .Property(h => h.Name).HasColumnName("name");
            modelBuilder.Entity<Hotel>()
                .Property(h => h.PostalCode).HasColumnName("postal_code");
            modelBuilder.Entity<Hotel>()
                .Property(h => h.StreetAddress).HasColumnName("street_address");
            modelBuilder.Entity<Hotel>()
                .HasMany(h => h.Rooms)
                .WithOne(r => r.Hotel)
                .HasForeignKey(r => r.HotelId);

            // HotelFeature configuration
            modelBuilder.Entity<HotelFeature>()
                .ToTable("hotel_features")
                .HasKey(hf => hf.HotelId);
            modelBuilder.Entity<HotelFeature>()
                .Property(hf => hf.HotelId).HasColumnName("hotel_id");
            modelBuilder.Entity<HotelFeature>()
                .Property(hf => hf.Feature).HasColumnName("hotel_features");
            modelBuilder.Entity<HotelFeature>()
                .HasOne(hf => hf.Hotel)
                .WithMany(h => h.HotelFeatures)
                .HasForeignKey(r => r.HotelId)
                .OnDelete(DeleteBehavior.Cascade);

            // HotelImageUrl configuration
            modelBuilder.Entity<HotelImageUrl>()
                .ToTable("hotel_hotel_image_urls")
                .HasKey(hiu => hiu.HotelId);
            modelBuilder.Entity<HotelImageUrl>()
                .Property(hiu => hiu.HotelId).HasColumnName("hotel_id");
            modelBuilder.Entity<HotelImageUrl>()
                .Property(hiu => hiu.ImageUrl).HasColumnName("hotel_image_urls");

            // Room configuration
            modelBuilder.Entity<Room>()
                .ToTable("room")
                .HasKey(r => r.Id);
            modelBuilder.Entity<Room>()
                .Property(r => r.Id).HasColumnName("id");
            modelBuilder.Entity<Room>()
                .Property(r => r.Description).HasColumnName("description");
            modelBuilder.Entity<Room>()
                .Property(r => r.NumberOfBeds).HasColumnName("number_of_beds");
            modelBuilder.Entity<Room>()
                .Property(r => r.PricePerNight).HasColumnName("price_per_night");
            modelBuilder.Entity<Room>()
                .Property(r => r.RoomArea).HasColumnName("room_area");
            modelBuilder.Entity<Room>()
                .Property(r => r.RoomImageUrl).HasColumnName("room_image_url");
            modelBuilder.Entity<Room>()
                .Property(r => r.RoomName).HasColumnName("room_name");
            modelBuilder.Entity<Room>()
                .Property(r => r.RoomType).HasColumnName("room_type");
            modelBuilder.Entity<Room>()
                .Property(r => r.HotelId).HasColumnName("hotel_id");
            modelBuilder.Entity<Room>()
                .HasOne(r => r.Hotel)
                .WithMany(h => h.Rooms)
                .HasForeignKey(r => r.HotelId)
                .OnDelete(DeleteBehavior.Cascade);

            // RoomReservation configuration
            modelBuilder.Entity<RoomReservation>()
                .ToTable("room_reservation")
                .HasKey(rr => rr.Id);
            modelBuilder.Entity<RoomReservation>()
                .Property(rr => rr.Id).HasColumnName("id");
            modelBuilder.Entity<RoomReservation>()
                .Property(rr => rr.EndDate).HasColumnName("end_date");
            modelBuilder.Entity<RoomReservation>()
                .Property(rr => rr.StartDate).HasColumnName("start_date");
            modelBuilder.Entity<RoomReservation>()
                .Property(rr => rr.BookingId).HasColumnName("booking_id");
            modelBuilder.Entity<RoomReservation>()
                .Property(rr => rr.RoomId).HasColumnName("room_id");

            // RoomFeature configuration
            modelBuilder.Entity<RoomFeature>()
                .ToTable("room_room_features")
                .HasKey(rf => rf.RoomId);
            modelBuilder.Entity<RoomFeature>()
                .Property(rf => rf.RoomId).HasColumnName("room_id");
            modelBuilder.Entity<RoomFeature>()
                .Property(rf => rf.Feature).HasColumnName("room_room_features");
            modelBuilder.Entity<RoomFeature>()
                .HasOne(rf => rf.Room)
                .WithMany(r => r.RoomFeatures)
                .HasForeignKey(rf => rf.RoomId)
                .OnDelete(DeleteBehavior.Cascade);

            // ServiceCost configuration
            modelBuilder.Entity<ServiceCost>()
                .ToTable("service_costs")
                .HasKey(sc => sc.Id);
            modelBuilder.Entity<ServiceCost>()
                .Property(sc => sc.Id).HasColumnName("id");
            modelBuilder.Entity<ServiceCost>()
                .Property(sc => sc.BookingId).HasColumnName("booking_id");
            modelBuilder.Entity<ServiceCost>()
                .Property(sc => sc.Description).HasColumnName("description");
            modelBuilder.Entity<ServiceCost>()
                .Property(sc => sc.Price).HasColumnName("price");
            modelBuilder.Entity<ServiceCost>()
                .Property(sc => sc.Volume).HasColumnName("volume");
        }
    }
}
