//using HotChocolate.Language;
//using WebApplication2_For_GraphQl.Data;
//using WebApplication2_For_GraphQl.Model;

//namespace WebApplication2_For_GraphQl.Mutation
//{
//    public class RecipesMutation
//    {
//        public async Task<Recipe> AddRecipeAsync(
//            RecipeInput input, // Input for creating the recipe
//            [Service] RecipesContext context)
//        {
//            // Create a new recipe based on input
//            var newRecipe = new Recipe
//            {
//                Id = Guid.NewGuid(), // Generate a unique ID
//                Name = input.Name,
//                Description = input.Description,
//                Steps = input.Steps.Select(s => new Step
//                {
//                    Id = Guid.NewGuid(),
//                    Order = s.Order,
//                    Duration = s.Duration,
//                    Instructions = s.Instructions
//                }).ToList(),
//                Ingredients = input.Ingredients.Select(i => new Ingredients
//                {
//                    Id = Guid.NewGuid(),
//                    Name = i.Name,
//                    WholeQty = i.WholeQty,
//                    Numerator = i.Numerator,
//                    Denominator = i.Denominator,
//                    Measurement = i.Measurement
//                }).ToList()
//            };

//            context.Recipes!.Add(newRecipe);
//            await context.SaveChangesAsync();

//            return newRecipe;
//        }
//    }
//}


//public class RecipeInput
//{
//    public string Name { get; set; } = string.Empty;
//    public string Description { get; set; } = string.Empty;
//    public List<StepInput> Steps { get; set; } = new List<StepInput>();
//    public List<IngredientInput> Ingredients { get; set; } = new List<IngredientInput>();
//}

//public class StepInput
//{
//    public int Order { get; set; }
//    public TimeSpan Duration { get; set; }
//    public string Instructions { get; set; } = string.Empty;
//}

//public class IngredientInput
//{
//    public string Name { get; set; } = string.Empty;
//    public int WholeQty { get; set; }
//    public int Numerator { get; set; }
//    public int Denominator { get; set; }
//    public string Measurement { get; set; } = string.Empty;
//}

//using HotChocolate.Types;

//public class TimeSpanType : ScalarType<TimeSpan, StringValueNode>
//{
//    public TimeSpanType() : base("TimeSpan") { }

//    public override IValueNode ParseValue(TimeSpan runtimeValue) =>
//        new StringValueNode(runtimeValue.ToString(@"hh\:mm\:ss"));

//    public override TimeSpan ParseLiteral(IValueNode valueNode) =>
//        valueNode is StringValueNode stringValueNode
//            ? TimeSpan.Parse(stringValueNode.Value)
//            : throw new SerializationException("Invalid TimeSpan format", this);

//    public override TimeSpan Deserialize(object resultValue) =>
//        resultValue is string str ? TimeSpan.Parse(str) : base.Deserialize(resultValue);

//    public override object Serialize(TimeSpan runtimeValue) =>
//        runtimeValue.ToString(@"hh\:mm\:ss");
//}
