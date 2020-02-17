using MiApp.Eventos;
using MiApp.Mercados;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiApp.DataAccessLayer
{
    class DataBaseContext : DbContext
    {
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Mercado> Mercados { get; set; }

        private static readonly string conString = "SERVER=placemybet.cnejmndpnncg.us-east-2.rds.amazonaws.com;" +
                    "PORT=3306;" +
                    "DATABASE=placeMyBetEMInterfaces;" +
                    "UID=root;" +
                    "PASSWORD=456uni9.L;" +
                    "SSL Mode=none;";

        public DataBaseContext()
        {
        }

        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(conString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Evento>().HasData(new Evento(1, DateTime.Now , "Valencia", "Espanyol"));
            modelBuilder.Entity<Evento>().HasData(new Evento(2, DateTime.Now , "Barcelona", "Madrid"));
            modelBuilder.Entity<Mercado>().HasData(new Mercado(1, 1.5, 1.9, 2.5, 100, 100, 1));
            modelBuilder.Entity<Mercado>().HasData(new Mercado(2,2.5,2.5,1.9,100,100,1));
            modelBuilder.Entity<Mercado>().HasData(new Mercado(3,3.4,3.0,1.9,100,100,1));
            modelBuilder.Entity<Mercado>().HasData(new Mercado(4, 1.5, 1.9, 2.5, 100, 100, 2));
            modelBuilder.Entity<Mercado>().HasData(new Mercado(5,2.5,2.5,1.9,100,100,2));
            modelBuilder.Entity<Mercado>().HasData(new Mercado(6,3.4,3.0,1.9,100,100,2));


        }
    }
}
