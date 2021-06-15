using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nest;
using System;
using WebApplicationPFR.Domain.Entities;

namespace WebApplicationPFR.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employes> Employes { get; set; }
        public DbSet<Monitors> Monitors { get; set; }
        public DbSet<PC> PC { get; set; }
        public DbSet<Printers> Printers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //добаления пользователя в бд
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                //связываем пользователя
                RoleId = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                UserId = "3b62472e-4f66-49fa-a20f-e7685b9565d8"
            });

            modelBuilder.Entity<Employes>().HasData( new Employes
            {  
                Id = new Guid("05c60af4-516a-4d5b-963d-e72183fba66e"),
                FIO = "Морозлва О.В.",
                otdel = "ВП и СВ№4",
                Room = 203
            });
            modelBuilder.Entity<Employes>().HasData(new Employes
            {
                Id = new Guid("bc8ab3c9-0338-454b-99d1-8912027cdaec"),
                FIO = "Петухова Е.С.",
                otdel = "ВП и СВ№4",
                Room = 203
            });
            modelBuilder.Entity<Monitors>().HasData(new Monitors
            {
                Id = new Guid("d481c76f-ca9a-4ee2-9538-af77c3ee0fc5"),
                mon = "Acer",
                mon_ser = "7894AEWER54789",
                mon_inv = "1010430058"
            });
            modelBuilder.Entity<Monitors>().HasData(new Monitors
            {
                Id = new Guid("ce9cbd3a-4ebc-4e27-81f3-27fb0e3f0f2f"),
                mon = "Acer",
                mon_ser = "AGAW78455547122",
                mon_inv = "1010430059"
            });
            modelBuilder.Entity<PC>().HasData(new PC
            {
                Id = new Guid("38121c49-4fa7-44c5-a809-17b5c9226831"),
                pc = "aQvariys",
                pc_ser = "1345475849785454",
                pc_inv = "1010430058"
            });
            modelBuilder.Entity<PC>().HasData(new PC
            {
                Id = new Guid("aa3bf19b-2726-48e7-87df-941d86725620"),
                pc = "aQvariys",
                pc_ser = "7984568545754784",
                pc_inv = "1010430059"
            });
            modelBuilder.Entity<Printers>().HasData(new Printers
            {
                Id = new Guid("021d385d-c48f-45ff-9b59-01bba2dd52fe"),
                printer = "Oki 432",
                printer_ser = "B875461002",
                printer_inv = "1010430059"
            });
        }
    }
}