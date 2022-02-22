using System;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;

namespace Cocktails2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new KageDbCocktails())
            {
                var blend = new Blend("Screwdriver", new List<Ingredient> { new Liquor("Vodka", 3), new Soft("Orange Juice", 7) });
                var glass = new Glass("Normal Glass", blend);

                ctx.Glasses.Add(glass);
                ctx.SaveChanges();




                foreach (var ingredient in ctx.Glasses)
                {
                    ctx.Entry(ingredient).Reference("Blend").Load();
                    Console.WriteLine(ingredient.id + " " + ingredient.Blend?.Name);
                }
            }
        }

        public class KageDbCocktails : DbContext
        {
            public KageDbCocktails() : base()
            {
                this.Configuration.LazyLoadingEnabled = false;
            }

            public DbSet<Blend> Blends { get; set; }
            public DbSet<Soft> Softs { get; set; }
            public DbSet<Liquor> Liquors { get; set; }
            public DbSet<Garnish> Garnishes { get; set; }
            public DbSet<Glass> Glasses { get; set; }


        }
    }
}
