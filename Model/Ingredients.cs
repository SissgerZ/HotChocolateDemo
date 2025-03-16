namespace WebApplication2_For_GraphQl
{
    public class Ingredients
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int WholeQty { get; set; } = 1;
        public int Numerator { get; set; } = 0;
        public int Denominator { get; set; } = 0;
        public string Measurement { get; set; } = string.Empty;
        public override string ToString() => Numerator == 0 ?
        $"{WholeQty} {Measurement} {Name}" :
        (WholeQty > 0 ?
            $"{WholeQty} {Numerator}/{Denominator} {Measurement} {Name}" :
            $"{Numerator}/{Denominator} {Measurement} {Name}");
    }
}
