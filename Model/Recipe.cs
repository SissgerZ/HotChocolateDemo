namespace WebApplication2_For_GraphQl.Model
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Ingredients> Ingredients { get; set; }
        public IEnumerable<Step> Steps { get; set; }
    }
}
