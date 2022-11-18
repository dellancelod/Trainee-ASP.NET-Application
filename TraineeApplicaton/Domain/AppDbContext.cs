using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraineeApplication.Domain.Entities;

namespace TraineeApplication.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }
        public DbSet<NewsItem> NewsItems { get; set; }
        public DbSet<MessageItem> MessageItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "baa165f2-90a8-452b-afda-bd8f3dd382ae",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "410fd6fc-c0eb-4671-b6b9-f245d78a8516",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> {
                RoleId = "baa165f2-90a8-452b-afda-bd8f3dd382ae",
                UserId = "410fd6fc-c0eb-4671-b6b9-f245d78a8516"
            });

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "6f1c1164-3813-47b5-91f4-adac910e215b",
                UserName = "user",
                NormalizedUserName = "USER",
                Email = "user@email.com",
                NormalizedEmail = "USER@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "password"),
                SecurityStamp = string.Empty
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("b488f7aa-9ebf-4ee5-9e4b-fc22f0de4e1d"),
                CodeWord = "PageNews",
                Title = "Новини"
            });
            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("b6de0903-3ba8-44b2-a5d9-f03d315098be"),
                CodeWord = "PageIndex",
                Title = "Головна"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("673c93b2-866d-4885-bca2-3f66f184dff5"),
                CodeWord = "PageServices",
                Title = "Наші послуги"
            });
            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("a76456fb-9a51-40c8-812b-00921c81f38c"),
                CodeWord = "PageContacts",
                Title = "Контакти"
            });

        }
    }
}
