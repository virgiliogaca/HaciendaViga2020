using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Area;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Costs;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Guests;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Inventory;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Payment;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Payments;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Rents;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Reservations;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Taxes;
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

        /// <summary>
        /// Gets or sets the areas.
        /// </summary>
        /// <value>
        /// The areas.
        /// </value>
        private DbSet<AreaEntity> Areas { get; set; }

        /// <summary>
        /// Gets or sets the costs.
        /// </summary>
        /// <value>
        /// The costs.
        /// </value>
        private DbSet<CostEntity> Costs { get; set; }

        /// <summary>
        /// Gets or sets the external cost commissions.
        /// </summary>
        /// <value>
        /// The external cost commissions.
        /// </value>
        private DbSet<ExternalCostCommissionEntity> ExternalCostCommissions { get; set; }

        /// <summary>
        /// Gets or sets the guests.
        /// </summary>
        /// <value>
        /// The guests.
        /// </value>
        private DbSet<GuestEntity> Guests { get; set; }

        /// <summary>
        /// Gets or sets the guest reservations.
        /// </summary>
        /// <value>
        /// The guest reservations.
        /// </value>
        private DbSet<GuestReservationEntity> GuestReservations { get; set; }

        /// <summary>
        /// Gets or sets the area inventory items.
        /// </summary>
        /// <value>
        /// The area inventory items.
        /// </value>
        private DbSet<AreaInventoryItemEntity> AreaInventoryItems { get; set; }

        /// <summary>
        /// Gets or sets the inventories.
        /// </summary>
        /// <value>
        /// The inventories.
        /// </value>
        private DbSet<InventoryEntity> Inventories { get; set; }

        /// <summary>
        /// Gets or sets the inventory items.
        /// </summary>
        /// <value>
        /// The inventory items.
        /// </value>
        private DbSet<InventoryItemEntity> InventoryItems { get; set; }

        /// <summary>
        /// Gets or sets the inventory item inventories.
        /// </summary>
        /// <value>
        /// The inventory item inventories.
        /// </value>
        private DbSet<InventoryItemInventoryEntity> InventoryItemInventories { get; set; }

        /// <summary>
        /// Gets or sets the inventory types.
        /// </summary>
        /// <value>
        /// The inventory types.
        /// </value>
        private DbSet<InventoryTypeEntity> InventoryTypes { get; set; }

        /// <summary>
        /// Gets or sets the room inventory items.
        /// </summary>
        /// <value>
        /// The room inventory items.
        /// </value>
        private DbSet<RoomInventoryItemEntity> RoomInventoryItems { get; set; }

        /// <summary>
        /// Gets or sets the payment discounts.
        /// </summary>
        /// <value>
        /// The payment discounts.
        /// </value>
        private DbSet<PaymentDiscountEntity> PaymentDiscounts { get; set; }

        /// <summary>
        /// Gets or sets the payment discount types.
        /// </summary>
        /// <value>
        /// The payment discount types.
        /// </value>
        private DbSet<PaymentDiscountTypeEntity> PaymentDiscountTypes { get; set; }

        /// <summary>
        /// Gets or sets the payments.
        /// </summary>
        /// <value>
        /// The payments.
        /// </value>
        private DbSet<PaymentEntity> Payments { get; set; }

        /// <summary>
        /// Gets or sets the payment guests.
        /// </summary>
        /// <value>
        /// The payment guests.
        /// </value>
        private DbSet<PaymentGuestEntity> PaymentGuests { get; set; }

        /// <summary>
        /// Gets or sets the payment methods.
        /// </summary>
        /// <value>
        /// The payment methods.
        /// </value>
        private DbSet<PaymentMethodEntity> PaymentMethods { get; set; }

        /// <summary>
        /// Gets or sets the quarter engagements.
        /// </summary>
        /// <value>
        /// The quarter engagements.
        /// </value>
        private DbSet<QuarterEngagementEntity> QuarterEngagements { get; set; }

        /// <summary>
        /// Gets or sets the rent concepts.
        /// </summary>
        /// <value>
        /// The rent concepts.
        /// </value>
        private DbSet<RentConceptEntity> RentConcepts { get; set; }

        /// <summary>
        /// Gets or sets the rent types.
        /// </summary>
        /// <value>
        /// The rent types.
        /// </value>
        private DbSet<RentTypeEntity> RentTypes { get; set; }

        /// <summary>
        /// Gets or sets the book external client reservations.
        /// </summary>
        /// <value>
        /// The book external client reservations.
        /// </value>
        private DbSet<BookExternalClientReservationEntity> BookExternalClientReservations { get; set; }

        /// <summary>
        /// Gets or sets the external client catalogs.
        /// </summary>
        /// <value>
        /// The external client catalogs.
        /// </value>
        private DbSet<ExternalClientCatalogEntity> ExternalClientCatalogs { get; set; }

        /// <summary>
        /// Gets or sets the reservations.
        /// </summary>
        /// <value>
        /// The reservations.
        /// </value>
        private DbSet<ReservationEntity> Reservations { get; set; }

        /// <summary>
        /// Gets or sets the rooms.
        /// </summary>
        /// <value>
        /// The rooms.
        /// </value>
        private DbSet<RoomEntity> Rooms { get; set; }

        /// <summary>
        /// Gets or sets the room types.
        /// </summary>
        /// <value>
        /// The room types.
        /// </value>
        private DbSet<RoomTypeEntity> RoomTypes { get; set; }

        /// <summary>
        /// Gets or sets the tax costs.
        /// </summary>
        /// <value>
        /// The tax costs.
        /// </value>
        private DbSet<TaxCostEntity> TaxCosts { get; set; }

        /// <summary>
        /// Gets or sets the taxes.
        /// </summary>
        /// <value>
        /// The taxes.
        /// </value>
        private DbSet<TaxEntity> Taxes { get; set; }

        /// <summary>
        /// Called when [model creating].
        /// </summary>
        /// <param name="builder">The builder.</param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            if (builder != null)
            {
                // Multiple Keys
                builder.Entity<GuestReservationEntity>()
                    .HasKey(k => new
                    {
                        k.GuestId,
                        k.ReservationId
                    });

                builder.Entity<BookExternalClientReservationEntity>().HasKey(k => new { k.ReservationId, k.ExternalClientCatalogId });

                builder.Entity<CostEntity>().Foreign(k => new { k.RentTypeId});
            }
        }
    }
}
