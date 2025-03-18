using Kafelino.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Kafelino.Data
{
    public class KafelinoDbContext : IdentityDbContext<User>
    {
        public KafelinoDbContext(DbContextOptions<KafelinoDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Order> Orders { get; set; }
        
        public DbSet<OrderProduct> OrderProducts { get; set; }
        
        public DbSet<Product> Products { get; set; }
        
        public DbSet<Cart> Carts { get; set; }
        
        public DbSet<TasteNote> TasteNotes { get; set; }
        
        public DbSet<ProductTasteNote> ProductTasteNotes { get; set; }
        
        public DbSet<Weight> Weights { get; set; }
        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Конфигурация на product модела
            builder.Entity<Product>()
                .HasOne(p => p.Weight)
                .WithMany(w => w.Products);

            builder.Entity<Product>()
                .HasMany(p => p.TasteNotes)
                .WithMany(ts => ts.Products)
                .UsingEntity<ProductTasteNote>();

            builder.Entity<Product>()
                .HasMany(p => p.OrderProducts)
                .WithOne(o => o.Product);
            
            builder.Entity<Product>()
                .HasMany(p => p.Users)
                .WithMany(u => u.Products)
                .UsingEntity<Cart>();
            
            // Конфигурация на Order модела
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
                UserName = "admin@kafelino.com",
                NormalizedUserName = "ADMIN@KAFELINO.COM"
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
                NormalizedEmail = "USER@KAFELINO.COM",
                EmailConfirmed = true,
                FirstName = "Михаил",
                LastName = "Филипов",
                UserName = "user@kafelino.com",
                NormalizedUserName = "USER@KAFELINO.COM"
            };

            user.PasswordHash = ph.HashPassword(user, "User_123");

            builder.Entity<User>()
                .HasData(user);

            
            
            builder.Entity<Weight>().HasData(
                new Weight { WeightId = 1, Value = 250, Unit = "г" },
                new Weight { WeightId = 2, Value = 500, Unit = "г" },
                new Weight { WeightId = 3, Value = 1, Unit = "кг" },
                new Weight { WeightId = 4, Value = 2, Unit = "кг" }
            );
            
            var tasteNotes = new List<TasteNote>
            {
                new TasteNote { TasteNoteId = 1, Name = "Жасмин" },
                new TasteNote { TasteNoteId = 2, Name = "Папая" },
                new TasteNote { TasteNoteId = 3, Name = "Кафява захар" },
                new TasteNote { TasteNoteId = 4, Name = "Праскова" },
                new TasteNote { TasteNoteId = 5, Name = "Кокос" },
                new TasteNote { TasteNoteId = 6, Name = "Ванилия" },
                new TasteNote { TasteNoteId = 7, Name = "Боровинки" },
                new TasteNote { TasteNoteId = 8, Name = "Грозде" },
                new TasteNote { TasteNoteId = 9, Name = "Натурален шоколад" },
                new TasteNote { TasteNoteId = 10, Name = "Ягода" },
                new TasteNote { TasteNoteId = 11, Name = "Мед" },
                new TasteNote { TasteNoteId = 12, Name = "Червена ябълка" },
                new TasteNote { TasteNoteId = 13, Name = "Карамел" },
                new TasteNote { TasteNoteId = 14, Name = "Зряла череша" },
                new TasteNote { TasteNoteId = 15, Name = "Черен чай" },
                new TasteNote { TasteNoteId = 16, Name = "Касис" },
                new TasteNote { TasteNoteId = 17, Name = "Цитрусови плодове" },
                new TasteNote { TasteNoteId = 18, Name = "Какао" },
                new TasteNote { TasteNoteId = 19, Name = "Портокалова кора" },
                new TasteNote { TasteNoteId = 20, Name = "Шоколад" },
                new TasteNote { TasteNoteId = 21, Name = "Лешник" }
            };
            
            builder.Entity<TasteNote>()
                .HasData(tasteNotes);

            builder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "Вулкан Азул | Гейша",
                    Description = "Тази изключителна партида Гейша идва от прочутата ферма Volcán Azul, която редовно се отличава като победител в конкурса Cup of Excellence Costa Rica. Обработена чрез натурален метод, тази партида разкрива елегантността и сложността, които правят Гейша толкова ценен сорт. Ароматът е фин и цветен, водещ към живи вкусове на жасмин и сочна папая. Ябълково-цитрусова киселинност придава свеж баланс, докато естествената сладост се запазва дълго, оставяйки изтънчен и продължителен вкус на кафява захар.",
                    ImageUrl = "https://kometa.coffee/wp-content/uploads/2024/03/vulkan-azul-geisha.jpg",
                    Price = 26.00m,
                    Quantity = 95,
                    Brand = "KOMETA",
                    WeightId = 2
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Хайро Арсила | Плодова ферментация",
                    Description = "Тази уникална партида е резултат от иновативния подход на Хайро Арсила, който използва плодова ферментация за обогатяване на вкусовия профил. Кафето впечатлява с нотки на праскова, кокос и ванилия, създавайки комплексен и запомнящ се вкус.",
                    ImageUrl = "https://kometa.coffee/wp-content/uploads/2024/03/jairo-arsila-fruit-fermentation.jpg",
                    Price = 24.00m,
                    Quantity = 120,
                    Brand = "KOMETA",
                    WeightId = 4
                },
                new Product
                {
                    ProductId = 3,
                    Name = "Алонсо Бустос | Таби",
                    Description = "Отгледано в региона Уиля, Колумбия, това кафе от сорта Таби предлага богат вкус с изразени нотки на боровинки, грозде и натурален шоколад. Идеално за любителите на плодови и сладки профили.",
                    ImageUrl = "https://kometa.coffee/wp-content/uploads/2024/03/alonso-bustos-tabi.jpg",
                    Price = 32.00m,
                    Quantity = 75,
                    Brand = "KOMETA",
                    WeightId = 3
                },
                new Product
                {
                    ProductId = 4,
                    Name = "Хамбела Гуджи, Етиопия",
                    Description = "Тази партида от региона Гуджи в Етиопия се отличава с флорални аромати и вкусове на жасмин, праскова и карамел. Перфектен избор за тези, които търсят елегантно и балансирано кафе.",
                    ImageUrl = "https://kometa.coffee/wp-content/uploads/2024/03/hambela-guji-ethiopia.jpg",
                    Price = 28.00m,
                    Quantity = 105,
                    Brand = "KOMETA",
                    WeightId = 1
                },
                new Product
                {
                    ProductId = 5,
                    Name = "Финка Сан Исидро | Катуай",
                    Description = "Кафе от региона Матагалпа в Никарагуа, което впечатлява с плътно тяло и вкусови нотки на карамел, зряла череша и черен чай.",
                    ImageUrl = "https://kometa.coffee/wp-content/uploads/2024/03/finca-san-isidro-catuai.jpg",
                    Price = 19.00m,
                    Quantity = 85,
                    Brand = "KOMETA",
                    WeightId = 4
                },
                new Product
                {
                    ProductId = 6,
                    Name = "Кения Каримиру | SL28 & SL34",
                    Description = "Традиционно кенийско кафе с интензивен аромат и вкусове на касис, цитрусови плодове и черен чай. Отличен избор за филтърно приготвяне.",
                    ImageUrl = "https://kometa.coffee/wp-content/uploads/2024/03/kenya-karimiru-sl28-sl34.jpg",
                    Price = 28.00m,
                    Quantity = 95,
                    Brand = "KOMETA",
                    WeightId = 3
                },
                new Product
                {
                    ProductId = 7,
                    Name = "Гватемала Хунакан | Пакмара",
                    Description = "Кафе от планините на Гватемала с комплексен профил и вкусове на какао, карамел и портокалова кора.",
                    ImageUrl = "https://kometa.coffee/wp-content/uploads/2024/03/guatemala-junacan-pacamara.jpg",
                    Price = 25.00m,
                    Quantity = 110,
                    Brand = "KOMETA",
                    WeightId = 2
                },
                new Product
                {
                    ProductId = 8,
                    Name = "Бразилия Сантош | Натурален",
                    Description = "Традиционно бразилско кафе със сладък и балансиран вкус на шоколад, лешник и карамел. Перфектно за еспресо.",
                    ImageUrl = "https://kometa.coffee/wp-content/uploads/2024/03/brazil-santos-natural.jpg",
                    Price = 18.00m,
                    Quantity = 90,
                    Brand = "KOMETA",
                    WeightId = 1
                },
                new Product
                {
                    ProductId = 9,
                    Name = "Етиопия Сидамо | Yirgacheffe",
                    Description = "Легендарно кафе от региона Йиргачеф в Етиопия, което предлага флорални нотки, цитрусови плодове и медена сладост.",
                    ImageUrl = "https://kometa.coffee/wp-content/uploads/2024/03/ethiopia-sidamo-yirgacheffe.jpg",
                    Price = 26.00m,
                    Quantity = 80,
                    Brand = "KOMETA",
                    WeightId = 3
                },
                new Product
                {
                    ProductId = 10,
                    Name = "Руанда Гацизиро | Бърбън",
                    Description = "Плодово и сладко кафе с нотки на сушена слива, лешник и мед. Един от най-добрите примери за африканско кафе.",
                    ImageUrl = "https://kometa.coffee/wp-content/uploads/2024/03/rwanda-gaciziro-bourbon.jpg",
                    Price = 27.00m,
                    Quantity = 115,
                    Brand = "KOMETA",
                    WeightId = 4
                },
                new Product
                {
                    ProductId = 11,
                    Name = "Панама Бокете | Гейша",
                    Description = "Едно от най-изисканите кафета в света – Панамската Гейша от региона Бокете е известна със своите интензивни флорални аромати, цитрусови нотки и копринена текстура. Сладостта и продължителният послевкус правят това кафе истинско удоволствие.",
                    ImageUrl = "https://kometa.coffee/wp-content/uploads/2024/03/panama-boquete-geisha.jpg",
                    Price = 30.00m,
                    Quantity = 105,
                    Brand = "KOMETA",
                    WeightId = 1
                },
                new Product
                {
                    ProductId = 12,
                    Name = "Индонезия Суматра | Gayo",
                    Description = "Кафе от региона Гайо в Суматра, което предлага пикантни и земни нотки с намек за канела, тъмен шоколад и индийско орехче. Балансирано тяло и дълъг, сладък послевкус.",
                    ImageUrl = "https://kometa.coffee/wp-content/uploads/2024/03/indonesia-sumatra-gayo.jpg",
                    Price = 22.50m,
                    Quantity = 95,
                    Brand = "KOMETA",
                    WeightId = 3
                },
                new Product
                {
                    ProductId = 13,
                    Name = "Йемен Мокха Матари",
                    Description = "Класическо йеменско кафе с дълбок профил – нотки на тъмен шоколад, черен чай и сушени плодове. Истинско историческо кафе с автентичен вкус.",
                    ImageUrl = "https://kometa.coffee/wp-content/uploads/2024/03/yemen-mokha-matari.jpg",
                    Price = 32.00m,
                    Quantity = 85,
                    Brand = "KOMETA",
                    WeightId = 2
                },
                new Product
                {
                    ProductId = 14,
                    Name = "Уганда Бугису | SL14 & SL28",
                    Description = "Уникално кафе от планините на Уганда със сочен плодов профил и нотки на кайсия, шоколад и карамфил. Отличава се със свежа киселинност и кремообразно тяло.",
                    ImageUrl = "https://kometa.coffee/wp-content/uploads/2024/03/uganda-bugisu-sl14-sl28.jpg",
                    Price = 23.50m,
                    Quantity = 115,
                    Brand = "KOMETA",
                    WeightId = 4
                },
                new Product
                {
                    ProductId = 15,
                    Name = "Хондурас Маркала | Катуай",
                    Description = "Отгледано в региона Маркала, това кафе предлага приятен баланс между сладост и киселинност, с нотки на мед, орех и млечен шоколад.",
                    ImageUrl = "https://kometa.coffee/wp-content/uploads/2024/03/honduras-marcala-catuai.jpg",
                    Price = 21.50m,
                    Quantity = 100,
                    Brand = "KOMETA",
                    WeightId = 1
                },
                new Product
                {
                    ProductId = 16,
                    Name = "Бразилия Серрадо | Бурбон",
                    Description = "Кафе от региона Серрадо в Бразилия със сладък и плътен профил. Вкусове на лешник, шоколад и карамел правят това кафе отличен избор за еспресо.",
                    ImageUrl = "https://kometa.coffee/wp-content/uploads/2024/03/brazil-cerrado-bourbon.jpg",
                    Price = 19.00m,
                    Quantity = 110,
                    Brand = "KOMETA",
                    WeightId = 2
                },
                new Product
                {
                    ProductId = 17,
                    Name = "Перу Сан Игнасио | Катуай",
                    Description = "Средно изпечено перуанско кафе със сладък и мек вкус. Нотки на тъмен шоколад, бадем и сладка череша. Подходящо за всички методи на приготвяне.",
                    ImageUrl = "https://kometa.coffee/wp-content/uploads/2024/03/peru-san-ignacio-catuai.jpg",
                    Price = 23.00m,
                    Quantity = 90,
                    Brand = "KOMETA",
                    WeightId = 3
                },
                new Product
                {
                    ProductId = 18,
                    Name = "Коста Рика Тарразу | Катура",
                    Description = "Кафе от един от най-добрите райони в Коста Рика, отличаващо се с карамелена сладост, нотки на ванилия и цитрусово усещане. Перфектно за филтърно кафе.",
                    ImageUrl = "https://kometa.coffee/wp-content/uploads/2024/03/costa-rica-tarrazu-caturra.jpg",
                    Price = 24.50m,
                    Quantity = 120,
                    Brand = "KOMETA",
                    WeightId = 4
                },
                new Product
                {
                    ProductId = 19,
                    Name = "Ел Салвадор Санта Ана | Пакамаара",
                    Description = "Фина селекция от сорта Пакамаара, отличаваща се с плодова сладост и нотки на зелена ябълка, мед и лимон. Изключително комплексно и балансирано кафе.",
                    ImageUrl = "https://kometa.coffee/wp-content/uploads/2024/03/el-salvador-santa-ana-pacamara.jpg",
                    Price = 26.00m,
                    Quantity = 80,
                    Brand = "KOMETA",
                    WeightId = 2
                },
                new Product
                {
                    ProductId = 20,
                    Name = "Колумбия Толуима | Кастийо",
                    Description = "Високопланинско кафе с богата киселинност и сложен ароматен профил. Нотки на кайсия, мед и черен чай го правят предпочитан избор за филтърно кафе.",
                    ImageUrl = "https://kometa.coffee/wp-content/uploads/2024/03/colombia-tolima-castillo.jpg",
                    Price = 25.00m,
                    Quantity = 75,
                    Brand = "KOMETA",
                    WeightId = 1
                }
            );
            
            builder.Entity<ProductTasteNote>().HasData(
                // Вулкан Азул | Гейша
                new ProductTasteNote { ProductId = 1, TasteNoteId = 1 },
                new ProductTasteNote { ProductId = 1, TasteNoteId = 2 },
                new ProductTasteNote { ProductId = 1, TasteNoteId = 3 },

                // Хайро Арсила | Плодова ферментация
                new ProductTasteNote { ProductId = 2, TasteNoteId = 4 },
                new ProductTasteNote { ProductId = 2, TasteNoteId = 5 },
                new ProductTasteNote { ProductId = 2, TasteNoteId = 6 },

                // Алонсо Бустос | Таби
                new ProductTasteNote { ProductId = 3, TasteNoteId = 7 },
                new ProductTasteNote { ProductId = 3, TasteNoteId = 8 },
                new ProductTasteNote { ProductId = 3, TasteNoteId = 9 },

                // Хамбела Гуджи, Етиопия
                new ProductTasteNote { ProductId = 4, TasteNoteId = 1 },
                new ProductTasteNote { ProductId = 4, TasteNoteId = 4 },
                new ProductTasteNote { ProductId = 4, TasteNoteId = 13 },

                // Финка Сан Исидро | Катуай
                new ProductTasteNote { ProductId = 5, TasteNoteId = 13 },
                new ProductTasteNote { ProductId = 5, TasteNoteId = 14 },
                new ProductTasteNote { ProductId = 5, TasteNoteId = 15 },

                // Кения Каримиру | SL28 & SL34
                new ProductTasteNote { ProductId = 6, TasteNoteId = 16 },
                new ProductTasteNote { ProductId = 6, TasteNoteId = 17 },
                new ProductTasteNote { ProductId = 6, TasteNoteId = 15 },

                // Гватемала Хунакан | Пакмара
                new ProductTasteNote { ProductId = 7, TasteNoteId = 18 },
                new ProductTasteNote { ProductId = 7, TasteNoteId = 13 },
                new ProductTasteNote { ProductId = 7, TasteNoteId = 19 },

                // Бразилия Сантош | Натурален
                new ProductTasteNote { ProductId = 8, TasteNoteId = 20 },
                new ProductTasteNote { ProductId = 8, TasteNoteId = 21 },
                new ProductTasteNote { ProductId = 8, TasteNoteId = 13 },

                // Етиопия Сидамо | Yirgacheffe
                new ProductTasteNote { ProductId = 9, TasteNoteId = 1 },
                new ProductTasteNote { ProductId = 9, TasteNoteId = 17 },
                new ProductTasteNote { ProductId = 9, TasteNoteId = 11 },

                // Руанда Гацизиро | Бърбън
                new ProductTasteNote { ProductId = 10, TasteNoteId = 14 },
                new ProductTasteNote { ProductId = 10, TasteNoteId = 21 },
                new ProductTasteNote { ProductId = 10, TasteNoteId = 11 },

                // Панама Бокете | Гейша
                new ProductTasteNote { ProductId = 11, TasteNoteId = 1 },
                new ProductTasteNote { ProductId = 11, TasteNoteId = 17 },
                new ProductTasteNote { ProductId = 11, TasteNoteId = 11 },

                // Индонезия Суматра | Gayo
                new ProductTasteNote { ProductId = 12, TasteNoteId = 3 },
                new ProductTasteNote { ProductId = 12, TasteNoteId = 20 },
                new ProductTasteNote { ProductId = 12, TasteNoteId = 6 },

                // Йемен Мокха Матари
                new ProductTasteNote { ProductId = 13, TasteNoteId = 20 },
                new ProductTasteNote { ProductId = 13, TasteNoteId = 15 },
                new ProductTasteNote { ProductId = 13, TasteNoteId = 14 },

                // Уганда Бугису | SL14 & SL28
                new ProductTasteNote { ProductId = 14, TasteNoteId = 4 },
                new ProductTasteNote { ProductId = 14, TasteNoteId = 20 },
                new ProductTasteNote { ProductId = 14, TasteNoteId = 3 },

                // Хондурас Маркала | Катуай
                new ProductTasteNote { ProductId = 15, TasteNoteId = 11 },
                new ProductTasteNote { ProductId = 15, TasteNoteId = 21 },
                new ProductTasteNote { ProductId = 15, TasteNoteId = 20 },

                // Бразилия Серрадо | Бурбон
                new ProductTasteNote { ProductId = 16, TasteNoteId = 21 },
                new ProductTasteNote { ProductId = 16, TasteNoteId = 20 },
                new ProductTasteNote { ProductId = 16, TasteNoteId = 13 },

                // Перу Сан Игнасио | Катуай
                new ProductTasteNote { ProductId = 17, TasteNoteId = 20 },
                new ProductTasteNote { ProductId = 17, TasteNoteId = 21 },
                new ProductTasteNote { ProductId = 17, TasteNoteId = 14 },

                // Коста Рика Тарразу | Катура
                new ProductTasteNote { ProductId = 18, TasteNoteId = 13 },
                new ProductTasteNote { ProductId = 18, TasteNoteId = 6 },
                new ProductTasteNote { ProductId = 18, TasteNoteId = 19 },

                // Ел Салвадор Санта Ана | Пакамаара
                new ProductTasteNote { ProductId = 19, TasteNoteId = 12 },
                new ProductTasteNote { ProductId = 19, TasteNoteId = 11 },
                new ProductTasteNote { ProductId = 19, TasteNoteId = 17 },

                // Колумбия Толуима | Кастийо
                new ProductTasteNote { ProductId = 20, TasteNoteId = 4 },
                new ProductTasteNote { ProductId = 20, TasteNoteId = 11 },
                new ProductTasteNote { ProductId = 20, TasteNoteId = 15 }
            );
            
            base.OnModelCreating(builder);
        }
    }
}
