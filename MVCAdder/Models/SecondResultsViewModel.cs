namespace MVCAdder.Models
{
    public class SecondResultsViewModel
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Sum => X + Y;
        public double Difference => X - Y;
        public double Product => X * Y;
        public double Quotient => Y == 0 ? 0 : X / Y;
        public double Remainder => X % Y;
    }
}
