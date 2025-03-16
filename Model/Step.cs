namespace WebApplication2_For_GraphQl
{
    public class Step
    {
        public Guid Id { get; set; }

        public int Order { get; set; } = 0;

        public TimeSpan Duration { get; set; } = TimeSpan.Zero;

        public string Instructions { get; set; } = string.Empty;

        public override string ToString() => $"Step #{Order}";
    }
}
