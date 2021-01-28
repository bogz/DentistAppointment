using System;
using System.Data;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Xamarin.Essentials;
using SQLitePCL;

namespace DentistAppointment.Services
{
    class Context : DbContext
    {

        public DbSet<Cabinet> Cabinete { get; set; }
        public DbSet<Client> Clienti { get; set; }
        public DbSet<Programare> Programari { get; set; }

        public Context()
        {
            SQLitePCL.Batteries_V2.Init();

            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "programari.db3");

            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cabinet>().HasKey(b => b.CabinetId).HasName("PrimaryKey_CabinetId");
            modelBuilder.Entity<Client>().HasKey(b => b.ClientId).HasName("PrimaryKey_Client");
            modelBuilder.Entity<Programare>().HasKey(b => b.ProgramareId).HasName("PrimaryKey_ProgramareId");
        }
    }
}