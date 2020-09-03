using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PraktyczneKursy.Models;
using PraktyczneKursy.Migrations;
using System.Data.Entity.Migrations;

namespace PraktyczneKursy.DAL
{
    //public class KursyInitializer : DropCreateDatabaseAlways<KursyContext>
    public class KursyInitializer : MigrateDatabaseToLatestVersion<KursyContext, Configuration>
    {
        //protected override void Seed(KursyContext context)
        //{
        //    SeedKursyData(context);
        //    base.Seed(context);
        //}

        public static void SeedKursyData(KursyContext context)
        {
            var kategorie = new List<Kategoria>
            {
                new Kategoria() { KategoriaId = 1, NazwaKategorii = "asp", NazwaPlikuIkony="asp.png", OpisKategorii = "Opis asp.net mvc" },
                new Kategoria() { KategoriaId = 2, NazwaKategorii = "java", NazwaPlikuIkony="java.png", OpisKategorii = "Opis java" },
                new Kategoria() { KategoriaId = 3, NazwaKategorii = "php", NazwaPlikuIkony="php.png", OpisKategorii = "Opis php" },
                new Kategoria() { KategoriaId = 4, NazwaKategorii = "html", NazwaPlikuIkony="html.png", OpisKategorii = "Opis html" },
                new Kategoria() { KategoriaId = 5, NazwaKategorii = "css", NazwaPlikuIkony="css.png", OpisKategorii = "Opis css" },
                new Kategoria() { KategoriaId = 6, NazwaKategorii = "xml", NazwaPlikuIkony="xml.png", OpisKategorii = "Opis xml" },
                new Kategoria() { KategoriaId = 7, NazwaKategorii = "c#", NazwaPlikuIkony="c#.png", OpisKategorii = "Opis c#" }
            };
            kategorie.ForEach(k => context.Kategorie.AddOrUpdate(k));
            context.SaveChanges();

            var kursy = new List<Kurs>
            {
                new Kurs() { AutorKursu = "tomek", TytulKursu = "asp.net mvc", KategoriaId = 1, CenaKursu = 99, Bestseller = true, NazwaPlikuObrazka = "asp.png", DataDodania = DateTime.Now, OpisKursu="opis kursu" },
                new Kurs() { AutorKursu = "jacek", TytulKursu = "asp.net mvc2", KategoriaId = 1, CenaKursu = 120, Bestseller = true, NazwaPlikuObrazka = "asp2.png", DataDodania = DateTime.Now, OpisKursu="opis kursu" },
                new Kurs() { AutorKursu = "irek", TytulKursu = "asp.net mvc3", KategoriaId = 1, CenaKursu = 120, Bestseller = true, NazwaPlikuObrazka = "asp3.png", DataDodania = DateTime.Now, OpisKursu="opis kursu" },
                new Kurs() { AutorKursu = "kuba", TytulKursu = "asp.net mvc4", KategoriaId = 1, CenaKursu = 140, Bestseller = true, NazwaPlikuObrazka = "asp4.png", DataDodania = DateTime.Now, OpisKursu="opis kursu" }
            };
            kursy.ForEach(k => context.Kursy.AddOrUpdate(k));
            context.SaveChanges();
        }
    }
}