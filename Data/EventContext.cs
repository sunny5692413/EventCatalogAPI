using EventCatalogAPI.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Data
{
    public class EventContext:DbContext
    {
        public EventContext(DbContextOptions options):base(options)//options for database
        {

        }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<EventLocation> EventLocations{ get; set; }
        public DbSet<EventPrice> EventPrices { get; set; }
        public DbSet<EventItem> EventItems{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventType>(ConfigureEventType);
            modelBuilder.Entity<EventLocation>(ConfigureEventLocation);
            modelBuilder.Entity<EventPrice>(ConfigureEventPrice);
            modelBuilder.Entity<EventItem>(ConfigureEventItem);
        }

        private void ConfigureEventItem(EntityTypeBuilder<EventItem> builder)
        {
            builder.ToTable("Events");
            builder.Property(e => e.Id)
                .IsRequired()
                .ForSqlServerUseSequenceHiLo("event_hilo");
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(e => e.Time)
                .IsRequired();
            builder.HasOne(e => e.EventType)
                .WithMany()
                .HasForeignKey(e => e.EventTypeId);
            builder.HasOne(e => e.EventLocation)
               .WithMany()
               .HasForeignKey(e => e.EventLocationId);
            builder.HasOne(e => e.EventPrice)
               .WithMany()
               .HasForeignKey(e => e.EventPriceId);
        }

        private void ConfigureEventPrice(EntityTypeBuilder<EventPrice> builder)
        {
            builder.ToTable("EventPrices");
            builder.Property(p => p.Id)
                .IsRequired()
                .ForSqlServerUseSequenceHiLo("event_Price_hilo");


            builder.Property(p => p.Price)
                 .IsRequired()
                 .HasMaxLength(100);
        }

        private void ConfigureEventLocation(EntityTypeBuilder<EventLocation> builder)
        {
            builder.ToTable("EventLocations");
            builder.Property(l => l.Id)
                .IsRequired()
                .ForSqlServerUseSequenceHiLo("event_Location_hilo");


            builder.Property(l => l.Location)
                 .IsRequired()
                 .HasMaxLength(100);
        }

        private void ConfigureEventType(EntityTypeBuilder<EventType> builder)
        {
            builder.ToTable("EventTypes");
            builder.Property(a => a.Id)
                .IsRequired()
                .ForSqlServerUseSequenceHiLo("event_type_hilo");


           builder.Property(a => a.Type)
                .IsRequired()
                .HasMaxLength(100);

        }
    }
}
