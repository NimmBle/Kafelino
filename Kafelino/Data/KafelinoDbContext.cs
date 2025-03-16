using Kafelino.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Kafelino.Data
{
    public class KafelinoDbContext : IdentityDbContext
    {
        public KafelinoDbContext(DbContextOptions<KafelinoDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Order> Orders { get; set; }
        
        public DbSet<OrderProduct> OrderProducts { get; set; }
        
        public DbSet<Product> Products { get; set; }
        
        public DbSet<TasteNote> TasteNotes { get; set; }
        
        public DbSet<Weight> Weights { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>()
                .HasMany(p => p.Weights)
                .WithMany(w => w.Products);
            
            builder.Entity<Product>()
                .HasMany(p => p.TasteNotes)
                .WithMany(ts => ts.Products);
            
            builder.Entity<Product>()
                .HasMany(p => p.OrderProducts)
                .WithOne(o => o.Product);
            
            
            builder.Entity<Order>()
                .HasMany(o => o.OrderProducts)
                .WithOne(o => o.Order);
            
            builder.Entity<Order>()
                .HasOne(p => p.User)
                .WithMany(u => u.Orders);
            
            
            var roleId = Guid.NewGuid().ToString();
            builder.Entity<IdentityRole>()
                .HasData(new IdentityRole
                {
                    Id = roleId,
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = roleId
                });
            
            var adminId = Guid.NewGuid().ToString();
            var admin = new User()
            {
                Id = adminId,
                Email = "admin@kafelino.com",
                NormalizedEmail = "ADMIN@KAFELINO.COM",
                EmailConfirmed = true,
                FirstName = "Иван",
                LastName = "Георгиев",
                UserName = "admin",
                NormalizedUserName = "ADMIN"
            };

            PasswordHasher<User> ph = new PasswordHasher<User>();
            
            admin.PasswordHash = ph.HashPassword(admin, "Admin_123");

            builder.Entity<User>()
                .HasData(admin);

            builder.Entity<IdentityUserRole<string>>()
                .HasData(new IdentityUserRole<string>
                {
                    RoleId = roleId,
                    UserId = adminId
                });

            var userId = Guid.NewGuid().ToString();
            var user = new User()
            {
                Id = userId,
                Email = "user@kafelino.com",
                NormalizedEmail = "USER@kafelino.COM",
                EmailConfirmed = true,
                FirstName = "Михаил",
                LastName = "Филипов",
                UserName = "user",
                NormalizedUserName = "USER"
            };

            user.PasswordHash = ph.HashPassword(user, "User_123");

            builder.Entity<User>()
                .HasData(user);

            builder.Entity<TasteNote>()
                .HasData(
                    new TasteNote { TasteNoteId = 1, Name = "Шоколад" },
                    new TasteNote { TasteNoteId = 2, Name = "Карамел" },
                    new TasteNote { TasteNoteId = 3, Name = "Ядки" },
                    new TasteNote { TasteNoteId = 4, Name = "Цитрус" },
                    new TasteNote { TasteNoteId = 5, Name = "Горски плодове" },
                    new TasteNote { TasteNoteId = 6, Name = "Цветен" },
                    new TasteNote { TasteNoteId = 7, Name = "Подправки" },
                    new TasteNote { TasteNoteId = 8, Name = "Меласа" },
                    new TasteNote { TasteNoteId = 9, Name = "Мед" },
                    new TasteNote { TasteNoteId = 10, Name = "Ванилия" },
                    new TasteNote { TasteNoteId = 11, Name = "Ябълка" },
                    new TasteNote { TasteNoteId = 12, Name = "Костилкови плодове" },
                    new TasteNote { TasteNoteId = 13, Name = "Кафява захар" },
                    new TasteNote { TasteNoteId = 14, Name = "Грейпфрут" },
                    new TasteNote { TasteNoteId = 15, Name = "Тофи" },
                    new TasteNote { TasteNoteId = 16, Name = "Лешник" },
                    new TasteNote { TasteNoteId = 17, Name = "Тропически плодове" },
                    new TasteNote { TasteNoteId = 18, Name = "Канела" },
                    new TasteNote { TasteNoteId = 19, Name = "Черен чай" },
                    new TasteNote { TasteNoteId = 20, Name = "Тъмен шоколад" }
                );
            
            base.OnModelCreating(builder);
        }
    }
}
