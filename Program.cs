using Microsoft.EntityFrameworkCore;
using WebApplication2_For_GraphQl.Data;
using WebApplication2_For_GraphQl.Query;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextFactory<RecipesContext>(opt => opt.UseSqlite("Data Source=recipes.sqlite3"));
builder.Services.AddScoped(sp => sp.GetRequiredService<IDbContextFactory<RecipesContext>>()
                .CreateDbContext());

builder.Services.AddGraphQLServer()
                .AddQueryType<RecipesQuery>()
                .AddFiltering()
                .AddSorting();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<RecipesContext>();
    await RecipesContext.CheckAndSeedDatabaseAsync(dbContext);
}

app.MapGraphQL();

app.Run();
