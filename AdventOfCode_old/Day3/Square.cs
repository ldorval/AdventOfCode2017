namespace AdventOfCode.Day3
{
    public class Square
    {
        public int X { get; set; }
        public int Y { get; set; }
        public long Number { get; set; }

        public Square Clone()
        {
            return new Square {X = X, Y = Y, Number = Number};
        }
    }
}