
using ECommerce.Application.Interfaces;
using ECommerce.Domain.Entities.Base;
using ECommerce.Domain.Entities.Products;
using ECommerce.Domain.Entities.Sales;
using ECommerce.Domain.Entities.Sales.Lookups;
using ECommerce.Domain.Entities.Users;
using ECommerce.Domain.Entities.Users.Lookups;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries<BaseEntity>()
                .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);
            foreach (var entry in entries)
            {
                var entity = entry.Entity;

                entity.ModifiedAt = DateTime.UtcNow;
                entity.ModifiedBy = 0;

                if (entry.State == EntityState.Added)
                {
                    entity.CreatedAt = DateTime.UtcNow;
                    entity.CreatedBy = 0;
                }

            }
            return base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.Rating)
                .HasPrecision(3, 2);

            modelBuilder.Entity<Product>()
                .Property(p => p.DiscountAmount)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Sku>()
                .Property(s => s.Price)
                .HasPrecision(18, 2);

                modelBuilder.Entity<Order>()
                    .Property(o => o.TotalAmount)
                    .HasPrecision(18, 2);

            modelBuilder.Entity<OrderItem>()
                .Property(oi => oi.PriceAtPurchase)
                .HasPrecision(18, 2);

            modelBuilder.Entity<OrderItem>()
                .Property(oi => oi.Rating)
                .HasPrecision(18, 2);

                modelBuilder.Entity<Order>()
                    .HasOne(o => o.Address)
                    .WithMany()
                    .HasForeignKey(o => o.AddressId)
                    .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Cart)
                .WithOne(c => c.User)
                .HasForeignKey<Cart>(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict);

                modelBuilder.Entity<Order>()
                    .HasOne(o => o.User)
                    .WithMany(u => u.Orders)
                    .HasForeignKey(o => o.UserId)
                    .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Wishlist)
                .WithOne(w => w.User)
                .HasForeignKey<Wishlist>(w => w.UserId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<SKUProductVariantOptions>()
                .HasKey(svo => new { svo.SkuId, svo.ProductVariantId, svo.ProductVariantOptionsId });

            modelBuilder.Entity<SKUProductVariantOptions>()
                .HasOne(svo => svo.Sku)
                .WithMany()
                .HasForeignKey(svo => svo.SkuId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SKUProductVariantOptions>()
                .HasOne(svo => svo.ProductVariant)
                .WithMany()
                .HasForeignKey(svo => svo.ProductVariantId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SKUProductVariantOptions>()
                .HasOne(svo => svo.ProductVariantOptions)
                .WithMany()
                .HasForeignKey(svo => svo.ProductVariantOptionsId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Sku>()
                .HasOne(s => s.Product)
                .WithMany(p => p.Skus)
                .HasForeignKey(s => s.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ProductVariant>()
                .HasOne(pv => pv.Product)
                .WithMany(p => p.ProductVariants)
                .HasForeignKey(pv => pv.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderStatus>().HasData(
                new OrderStatus { Id = 1, StatusName = "Pending" },
                new OrderStatus { Id = 2, StatusName = "Confirmed" },
                new OrderStatus { Id = 3, StatusName = "Shipped" },
                new OrderStatus { Id = 4, StatusName = "Delivered" }
            );

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, RoleName = "Admin" },
                new Role { Id = 2, RoleName = "Customer" }
            );
            modelBuilder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "Saudi Arabia"},
                new Country { Id = 2, Name = "United Arab Emirates" },
                new Country { Id = 3, Name = "Jordan" }
            );

            modelBuilder.Entity<City>().HasData(
                new City { Id = 1, Name = "Amman", CountryId = 3 },
                new City { Id = 2, Name = "Zarqa", CountryId = 3 },
                new City { Id = 3, Name = "Irbid", CountryId = 3 },
                new City { Id = 4, Name = "Russeifa", CountryId = 3 },
                new City { Id = 5, Name = "Sahab", CountryId = 3 },
                new City { Id = 6, Name = "As-Salt", CountryId = 3 },
                new City { Id = 7, Name = "Aqaba", CountryId = 3 },
                new City { Id = 8, Name = "Madaba", CountryId = 3 },
                new City { Id = 9, Name = "Jerash", CountryId = 3 },
                new City { Id = 10, Name = "Ma'an", CountryId = 3 },
                new City { Id = 11, Name = "Al-Mafraq", CountryId = 3 },
                new City { Id = 12, Name = "Tafilah", CountryId = 3 },
                new City { Id = 13, Name = "Ajloun", CountryId = 3 },

                new City { Id = 14, Name = "Riyadh", CountryId = 1 },
                new City { Id = 15, Name = "Jeddah", CountryId = 1 },

                new City { Id = 16, Name = "Dubai", CountryId = 2 },
                new City { Id = 17, Name = "Abu Dhabi", CountryId = 2 }
            );


        }

        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<ProductImage> ProductImages { get; set; } = null!;
        public DbSet<ProductVariant> ProductVariants { get; set; } = null!;
        public DbSet<ProductVariantOptions> ProductVariantOptions { get; set; } = null!;
        public DbSet<Sku> Skus { get; set; } = null!;
        public DbSet<SKUProductVariantOptions> SKUProductVariantOptions { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderItem> OrderItems { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<Cart> Carts { get; set; } = null!;
        public DbSet<CartItem> CartItems { get; set; } = null!;
        public DbSet<Wishlist> Wishlists { get; set; } = null!;
        public DbSet<WishlistItem> WishlistItems { get; set; } = null!;
        public DbSet<OrderStatus> OrderStatuses { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<City> Cities { get; set; } = null!;
    }

}
