using WebApplication2_For_GraphQl.Data;
using WebApplication2_For_GraphQl.Model;

namespace WebApplication2_For_GraphQl.Query
{
    public class RecipesQuery
    {
        [UseFiltering]
        [UseSorting]
        public IQueryable<Recipe>? GetRecipes([Service] RecipesContext context, int test) => context.Recipes;
    }
}
