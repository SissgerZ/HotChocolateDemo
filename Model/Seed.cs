namespace WebApplication2_For_GraphQl.Model
{
    public static class Seed
    {
        public static ICollection<Recipe> GetRecipes()
        {
            return new List<Recipe>
            {
                new Recipe
                {
                    Id = Guid.NewGuid(),
                    Name = "Pancakes",
                    Description = "A fluffy and delicious breakfast classic.",
                    Steps = new List<Step>
                    {
                        new Step { Id = Guid.NewGuid(), Order = 1, Duration = TimeSpan.FromMinutes(5), Instructions = "Mix the dry ingredients in a bowl." },
                        new Step { Id = Guid.NewGuid(), Order = 2, Duration = TimeSpan.FromMinutes(3), Instructions = "Whisk the wet ingredients in another bowl." },
                        new Step { Id = Guid.NewGuid(), Order = 3, Duration = TimeSpan.FromMinutes(10), Instructions = "Combine the wet and dry ingredients, and stir until smooth." },
                        new Step { Id = Guid.NewGuid(), Order = 4, Duration = TimeSpan.FromMinutes(5), Instructions = "Pour batter onto a hot griddle and cook until golden brown on both sides." }
                    },
                    Ingredients = new List<Ingredients>
                    {
                        new Ingredients { Id = Guid.NewGuid(), Name = "Flour", WholeQty = 2, Measurement = "cups" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Sugar", WholeQty = 2, Measurement = "tablespoons" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Baking Powder", WholeQty = 2, Measurement = "teaspoons" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Salt", WholeQty = 0, Numerator = 1, Denominator = 4, Measurement = "teaspoon" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Milk", WholeQty = 1, Measurement = "cup" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Egg", WholeQty = 1, Measurement = "large" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Butter", WholeQty = 2, Measurement = "tablespoons" }
                    }
                },
                new Recipe
                {
                    Id = Guid.NewGuid(),
                    Name = "Scrambled Eggs",
                    Description = "A quick and easy recipe for fluffy scrambled eggs.",
                    Steps = new List<Step>
                    {
                        new Step { Id = Guid.NewGuid(), Order = 1, Duration = TimeSpan.FromMinutes(2), Instructions = "Crack the eggs into a bowl and whisk." },
                        new Step { Id = Guid.NewGuid(), Order = 2, Duration = TimeSpan.FromMinutes(3), Instructions = "Heat a non-stick skillet over medium heat." },
                        new Step { Id = Guid.NewGuid(), Order = 3, Duration = TimeSpan.FromMinutes(5), Instructions = "Pour the eggs into the skillet and gently stir until cooked to your liking." }
                    },
                    Ingredients = new List<Ingredients>
                    {
                        new Ingredients { Id = Guid.NewGuid(), Name = "Eggs", WholeQty = 3, Measurement = "large" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Salt", WholeQty = 0, Numerator = 1, Denominator = 4, Measurement = "teaspoon" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Butter", WholeQty = 1, Measurement = "tablespoon" }
                    }
                },
                new Recipe
                {
                    Id = Guid.NewGuid(),
                    Name = "Spaghetti Carbonara",
                    Description = "A creamy and flavorful pasta dish from Italy.",
                    Steps = new List<Step>
                    {
                        new Step { Id = Guid.NewGuid(), Order = 1, Duration = TimeSpan.FromMinutes(10), Instructions = "Boil spaghetti until al dente." },
                        new Step { Id = Guid.NewGuid(), Order = 2, Duration = TimeSpan.FromMinutes(5), Instructions = "Cook pancetta in a skillet until crispy." },
                        new Step { Id = Guid.NewGuid(), Order = 3, Duration = TimeSpan.FromMinutes(3), Instructions = "Mix eggs and cheese in a bowl, then combine with pasta and pancetta." }
                    },
                    Ingredients = new List<Ingredients>
                    {
                        new Ingredients { Id = Guid.NewGuid(), Name = "Spaghetti", WholeQty = 400, Measurement = "grams" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Eggs", WholeQty = 2, Measurement = "large" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Pancetta", WholeQty = 150, Measurement = "grams" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Parmesan Cheese", WholeQty = 50, Measurement = "grams" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Black Pepper", WholeQty = 0, Numerator = 1, Denominator = 2, Measurement = "teaspoon" }
                    }
                },
                new Recipe
                {
                    Id = Guid.NewGuid(),
                    Name = "Caesar Salad",
                    Description = "A crisp and fresh salad with a tangy dressing.",
                    Steps = new List<Step>
                    {
                        new Step { Id = Guid.NewGuid(), Order = 1, Duration = TimeSpan.FromMinutes(5), Instructions = "Chop lettuce and prepare the croutons." },
                        new Step { Id = Guid.NewGuid(), Order = 2, Duration = TimeSpan.FromMinutes(2), Instructions = "Mix Caesar dressing with grated Parmesan cheese." },
                        new Step { Id = Guid.NewGuid(), Order = 3, Duration = TimeSpan.FromMinutes(2), Instructions = "Combine lettuce, dressing, croutons, and sprinkle with Parmesan." }
                    },
                    Ingredients = new List<Ingredients>
                    {
                        new Ingredients { Id = Guid.NewGuid(), Name = "Romaine Lettuce", WholeQty = 1, Measurement = "head" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Croutons", WholeQty = 1, Measurement = "cup" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Parmesan Cheese", WholeQty = 50, Measurement = "grams" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Caesar Dressing", WholeQty = 0, Numerator = 1, Denominator = 2, Measurement = "cup" }
                    }
                },
                new Recipe
                {
                    Id = Guid.NewGuid(),
                    Name = "Chocolate Chip Cookies",
                    Description = "Chewy and delicious cookies with rich chocolate chips.",
                    Steps = new List<Step>
                    {
                        new Step { Id = Guid.NewGuid(), Order = 1, Duration = TimeSpan.FromMinutes(5), Instructions = "Preheat the oven to 180°C (350°F)." },
                        new Step { Id = Guid.NewGuid(), Order = 2, Duration = TimeSpan.FromMinutes(10), Instructions = "Cream butter and sugar, then add eggs and vanilla." },
                        new Step { Id = Guid.NewGuid(), Order = 3, Duration = TimeSpan.FromMinutes(5), Instructions = "Mix in dry ingredients and fold in chocolate chips." },
                        new Step { Id = Guid.NewGuid(), Order = 4, Duration = TimeSpan.FromMinutes(15), Instructions = "Scoop dough onto a baking sheet and bake until golden." }
                    },
                    Ingredients = new List<Ingredients>
                    {
                        new Ingredients { Id = Guid.NewGuid(), Name = "Butter", WholeQty = 1, Measurement = "cup" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Sugar", WholeQty = 1, Measurement = "cup" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Brown Sugar", WholeQty = 1, Measurement = "cup" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Eggs", WholeQty = 2, Measurement = "large" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Vanilla Extract", WholeQty = 1, Measurement = "teaspoon" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Flour", WholeQty = 2, Measurement = "cups" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Baking Soda", WholeQty = 1, Measurement = "teaspoon" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Chocolate Chips", WholeQty = 1, Measurement = "cup" }
                    }
                },
                    new Recipe
                {
                    Id = Guid.NewGuid(),
                    Name = "Mediterranean Quinoa Salad",
                    Description = "A protein-packed, vibrant salad with bold Mediterranean flavors.",
                    Steps = new List<Step>
                    {
                        new Step { Id = Guid.NewGuid(), Order = 1, Duration = TimeSpan.FromMinutes(15), Instructions = "Cook and cool the quinoa according to package instructions." },
                        new Step { Id = Guid.NewGuid(), Order = 2, Duration = TimeSpan.FromMinutes(5), Instructions = "Chop and prepare all vegetables and ingredients." },
                        new Step { Id = Guid.NewGuid(), Order = 3, Duration = TimeSpan.FromMinutes(5), Instructions = "Combine all the ingredients in a large bowl and toss with dressing." }
                    },
                    Ingredients = new List<Ingredients>
                    {
                        new Ingredients { Id = Guid.NewGuid(), Name = "Quinoa", WholeQty = 1, Measurement = "cup" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Cucumber", WholeQty = 1, Measurement = "large, diced" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Cherry Tomatoes", WholeQty = 1, Measurement = "cup, halved" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Kalamata Olives", WholeQty = 1, Measurement = "cup, sliced" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Red Onion", WholeQty = 0, Numerator = 1, Denominator = 2, Measurement = "cup, sliced" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Feta Cheese", WholeQty = 1, Measurement = "cup, crumbled" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Olive Oil", WholeQty = 2, Measurement = "tablespoons" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Lemon Juice", WholeQty = 1, Measurement = "tablespoon" }
                    }
                },
                new Recipe
                {
                    Id = Guid.NewGuid(),
                    Name = "Thai Mango Salad",
                    Description = "A refreshing and tangy salad with a balance of sweet and spicy flavors.",
                    Steps = new List<Step>
                    {
                        new Step { Id = Guid.NewGuid(), Order = 1, Duration = TimeSpan.FromMinutes(5), Instructions = "Julienne or thinly slice the mango and vegetables." },
                        new Step { Id = Guid.NewGuid(), Order = 2, Duration = TimeSpan.FromMinutes(3), Instructions = "Prepare the dressing by whisking lime juice, fish sauce, brown sugar, and sesame oil." },
                        new Step { Id = Guid.NewGuid(), Order = 3, Duration = TimeSpan.FromMinutes(2), Instructions = "Combine all ingredients in a bowl and toss with the dressing." }
                    },
                    Ingredients = new List<Ingredients>
                    {
                        new Ingredients { Id = Guid.NewGuid(), Name = "Mangoes", WholeQty = 2, Measurement = "large, julienned" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Red Bell Pepper", WholeQty = 1, Measurement = "large, julienned" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Carrots", WholeQty = 1, Measurement = "cup, shredded" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Cilantro", WholeQty = 0, Numerator = 1, Denominator = 4, Measurement = "cup, chopped" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Roasted Peanuts", WholeQty = 0, Numerator = 1, Denominator = 4, Measurement = "cup, chopped" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Red Chili", WholeQty = 1, Measurement = "small, finely sliced" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Lime Juice", WholeQty = 2, Measurement = "tablespoons" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Fish Sauce", WholeQty = 1, Measurement = "tablespoon" },
                        new Ingredients { Id = Guid.NewGuid(), Name = "Brown Sugar", WholeQty = 1, Measurement = "teaspoon" }
                    }
                }
            };
        }
    }
}



