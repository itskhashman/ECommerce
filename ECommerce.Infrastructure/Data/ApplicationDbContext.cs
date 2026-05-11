
using ECommerce.Domain.Entities.Base;
using ECommerce.Domain.Entities.Products;
using ECommerce.Domain.Entities.Products.Lookups;
using ECommerce.Domain.Entities.Sales;
using ECommerce.Domain.Entities.Sales.Lookups;
using ECommerce.Domain.Entities.Users;
using ECommerce.Domain.Entities.Users.Lookups;
using Microsoft.EntityFrameworkCore;
using System.Xml;

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
            modelBuilder.Entity<Review>()
                .Property(p => p.RatingValue)
                .HasPrecision(2, 1);

            modelBuilder.Entity<Product>()
                .Property(p => p.DiscountAmount)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Sku>()
                .Property(s => s.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Sku>()
                .Property(s => s.Weight)
                .HasPrecision(8, 3);

            modelBuilder.Entity<Order>()
                    .Property(o => o.TotalAmount)
                    .HasPrecision(10, 2);

            modelBuilder.Entity<Order>()
                    .Property(o => o.ShippingCost)
                    .HasPrecision(10, 2);

            modelBuilder.Entity<OrderItem>()
                .Property(oi => oi.SubTotal)
                .HasPrecision(10, 2);
            modelBuilder.Entity<OrderItem>()
                .Property(oi => oi.PriceAtPurchase)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OrderItem>()
                .Property(oi => oi.DiscountAmount)
                .HasPrecision(8, 2);

            modelBuilder.Entity<CartItem>()
                .Property(oi => oi.PriceAtAddTime)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SKUProductVariantOptions>()
                .HasKey(svo => new { svo.SkuId, svo.ProductVariantId, svo.ProductVariantOptionsId });

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.Entity<OrderStatus>().HasData(
                new OrderStatus { Id = 1, NameEn = "Pending" , NameAr = "قيد الانتظار" },
                new OrderStatus { Id = 2, NameEn = "Confirmed", NameAr = "تم التأكيد" },
                new OrderStatus { Id = 3, NameEn = "Shipped", NameAr = "تم الشحن" },
                new OrderStatus { Id = 4, NameEn = "Delivered", NameAr = "تم التسليم" }
            );

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, NameEn = "Admin", NameAr = "مشرف" },
                new Role { Id = 2, NameEn = "Customer", NameAr = "عميل" }
            );
            modelBuilder.Entity<Country>().HasData(
                new Country { Id = 1, NameEn = "Saudi Arabia", NameAr = "المملكة العربية السعودية" },
                new Country { Id = 2, NameEn = "United Arab Emirates", NameAr = "الإمارات العربية المتحدة" },
                new Country { Id = 3, NameEn = "Jordan", NameAr = "الأردن" }
            );

            modelBuilder.Entity<City>().HasData(
                new City { Id = 1, NameEn = "Amman", NameAr = "عمان", CountryId = 3 },
                new City { Id = 2, NameEn = "Zarqa", NameAr = "الزرقاء", CountryId = 3 },
                new City { Id = 3, NameEn = "Irbid", NameAr = "إربد", CountryId = 3 },
                new City { Id = 4, NameEn = "Russeifa", NameAr = "الرصيفة", CountryId = 3 },
                new City { Id = 5, NameEn = "Sahab", NameAr = "صاحب", CountryId = 3 },
                new City { Id = 6, NameEn = "As-Salt", NameAr = "السلط", CountryId = 3 },
                new City { Id = 7, NameEn = "Aqaba", NameAr = "العقبة", CountryId = 3 },
                new City { Id = 8, NameEn = "Madaba", NameAr = "مادبا", CountryId = 3 },
                new City { Id = 9, NameEn = "Jerash", NameAr = "جرش", CountryId = 3 },
                new City { Id = 10, NameEn = "Ma'an", NameAr = "معان", CountryId = 3 },
                new City { Id = 11, NameEn = "Al-Mafraq", NameAr = "المفرق", CountryId = 3 },
                new City { Id = 12, NameEn = "Tafilah", NameAr = "الطفيلة", CountryId = 3 },
                new City { Id = 13, NameEn = "Ajloun", NameAr = "عجلون", CountryId = 3 },

                new City { Id = 14, NameEn = "Riyadh", NameAr = "الرياض", CountryId = 1 },
                new City { Id = 15, NameEn = "Jeddah", NameAr = "جدة", CountryId = 1 },

                new City { Id = 16, NameEn = "Dubai", NameAr = "دبي", CountryId = 2 },
                new City { Id = 17, NameEn = "Abu Dhabi", NameAr = "أبو ظبي", CountryId = 2 }
            );

            modelBuilder.Entity<DiscountType>().HasData(
                new DiscountType { Id = 1, NameEn = "Percentage", NameAr = "نسبة مئوية" },
                new DiscountType { Id = 2, NameEn = "Fixed Amount", NameAr = "مبلغ ثابت" }
            );

            modelBuilder.Entity<PaymentMethod>().HasData(
                new PaymentMethod { Id = 1, NameEn = "Credit Card", NameAr = "بطاقة ائتمان" },
                new PaymentMethod { Id = 2, NameEn = "PayPal", NameAr = "باي بال" },
                new PaymentMethod { Id = 3, NameEn = "Cash on Delivery", NameAr = "الدفع عند الاستلام" }
            );

            modelBuilder.Entity<PaymentStatus>().HasData(
               new PaymentStatus { Id = 1, NameEn = "Pending", NameAr = "قيد الانتظار" },
               new PaymentStatus { Id = 2, NameEn = "Completed", NameAr = "مكتمل" },
               new PaymentStatus { Id = 3, NameEn = "Failed", NameAr = "فشل" }
           );




        }

        public DbSet<Product> Product { get; set; } = null!;
        public DbSet<Category> Category { get; set; } = null!;
        public DbSet<ProductImage> ProductImage { get; set; } = null!;
        public DbSet<ProductVariant> ProductVariant { get; set; } = null!;
        public DbSet<ProductVariantOptions> ProductVariantOption { get; set; } = null!;
        public DbSet<Sku> Sku { get; set; } = null!;
        public DbSet<SKUProductVariantOptions> SKUProductVariantOption { get; set; } = null!;
        public DbSet<Order> Order { get; set; } = null!;
        public DbSet<OrderItem> OrderItem { get; set; } = null!;
        public DbSet<User> User { get; set; } = null!;
        public DbSet<Address> Address { get; set; } = null!;
        public DbSet<Cart> Cart { get; set; } = null!;
        public DbSet<CartItem> CartItem { get; set; } = null!;
        public DbSet<Wishlist> Wishlist { get; set; } = null!;
        public DbSet<WishlistItem> WishlistItem { get; set; } = null!;
        public DbSet<OrderStatus> OrderStatus { get; set; } = null!;
        public DbSet<Role> Role { get; set; } = null!;
        public DbSet<Country> Country { get; set; } = null!;
        public DbSet<City> City { get; set; } = null!;
        public DbSet<DiscountType> DiscountType { get; set; } = null!;
        public DbSet<Review> Review { get; set; } = null!;
        public DbSet<Payment> Payment { get; set; } = null!;
        public DbSet<PaymentMethod> PaymentMethod { get; set; } = null!;
        public DbSet<PaymentStatus> PaymentStatus { get; set; } = null!;
    }

}
