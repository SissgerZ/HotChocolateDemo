using Microsoft.EntityFrameworkCore;
using WebApplication2_For_GraphQl.Model;

namespace WebApplication2_For_GraphQl.Data
{
    public class RecipesContext : DbContext
    {
        public DbSet<Recipe>? Recipes { get; set; }

        public RecipesContext()
        {
            // void
        }

        public RecipesContext(DbContextOptions<RecipesContext> options) : base(options)
        {
            // void
        }

        public static async Task CheckAndSeedDatabaseAsync(RecipesContext context)
        {
            if (await context.Database.EnsureCreatedAsync())
            {
                var recipes = Seed.GetRecipes();
                if (context.Recipes != null)
                {
                    context.Recipes.AddRange(recipes);
                    await context.SaveChangesAsync();
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().OwnsMany(r => r.Ingredients);

            modelBuilder.Entity<Recipe>().OwnsMany(r => r.Steps);

            base.OnModelCreating(modelBuilder);
        }
    }
}
