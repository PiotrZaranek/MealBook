using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MealBook.Domain.Model;
using System.Reflection.Metadata.Ecma335;

namespace MealBook.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealDetalInformation> MealDetalInformations { get; set; }
        public DbSet<MealIngredniet> MealIngredniet { get; set; }
        public DbSet<MealTag> MealTag { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // 1:1 Meal - MealDetalInformation
            builder.Entity<MealDetalInformation>()
                .HasOne(a => a.Meal).WithOne(b => b.MealDetalInformation)
                .HasForeignKey<Meal>(e => e.MealDetalInformationsId);

            // n:m Meal - Tag
            builder.Entity<MealTag>()
                .HasKey(it => new { it.MealId, it.TagId });

            builder.Entity<MealTag>()
                .HasOne<Meal>(it => it.Meal)
                .WithMany(i => i.MealTag)
                .HasForeignKey(k => k.MealId);

            builder.Entity<MealTag>()
                .HasOne<Tag>(it => it.Tag)
                .WithMany(i => i.MealTag)
                .HasForeignKey(k => k.TagId);

            // n:m Meal - Ingredient
            builder.Entity<MealIngredniet>()
                .HasKey(k => new { k.MealId, k.IngredientId });

            builder.Entity<MealIngredniet>()
                .HasOne<Meal>(it => it.Meal)
                .WithMany(i => i.MealIngredniet)
                .HasForeignKey(k => k.MealId);

            builder.Entity<MealIngredniet>()
                .HasOne<Ingredient>(it => it.Ingredient)
                .WithMany(i => i.MealIngredniet)
                .HasForeignKey(k => k.IngredientId);
        }
    }
}
