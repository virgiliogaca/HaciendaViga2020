using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Area;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Costs;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Guests;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Inventory;
using Microsoft.EntityFrameworkCore;

namespace HaciendaViga2020Api.Core.Abstractions.DataContexts
{
    /// <summary>
    /// Hacienda Viga 20-20 DbContext.
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class HaciendaViga2020DbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HaciendaViga2020DbContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public HaciendaViga2020DbContext(DbContextOptions<HaciendaViga2020DbContext> options)
            : base(options)
        {
        }

        DbSet<AreaEntity> Areas { get; set; }


        DbSet<CostEntity> Costs { get; set; }


        DbSet<ExternalCostCommissionEntity> ExternalCostCommissions { get; set; }


        DbSet<GuestEntity> Guests { get; set; }


        DbSet<GuestReservationEntity> GuestReservations { get; set; }


        DbSet<AreaInventoryItemEntity> AreaInventoryItems { get; set; }


        DbSet<InventoryEntity> Inventories { get; set; }


        DbSet<InventoryItemEntity> InventoryItems { get; set; }


        DbSet<InventoryItemInventoryEntity> InventoryItemInventories { get; set; }


        DbSet<InventoryTypeEntity> InventoryTypes { get; set; }

        /// <summary>
        /// Called when [model creating].
        /// </summary>
        /// <param name="builder">The builder.</param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            if (builder != null)
            {
                // Multiple Keys
                builder.Entity<GuestReservationEntity>().HasKey(k => new { k.GuestId, k.ReservationId });
                //builder.Entity<BookExternalClientReservationEntity>().HasKey(k => new { k.ReservationId, k.ExternalClientCatalogId });
            }
        }
    }
}
