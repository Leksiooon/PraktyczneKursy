using PraktyczneKursy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PraktyczneKursy.DAL
{
    public class KursyContext : DbContext
    {
        public KursyContext() : base("KursyContext")
        {

        }

        public DbSet<Kurs> Kursy { get; set; }
        public DbSet<Kategoria> Kategorie { get; set; }
        public DbSet<Zamowienie> Zamówienia { get; set; }
        public DbSet<PozycjaZamowienia> PozycjaZamowienia { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //wyłącza konwencję, która automatycznie tworzy liczbę mnogą dla nazw tabel w bazie danych
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }
    }
}