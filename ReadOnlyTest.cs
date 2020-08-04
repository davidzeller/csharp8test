using System;

namespace CSharp8Test
{
        public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public readonly double Distance => Math.Sqrt(X * X + Y * Y);

        public readonly override string ToString() =>
            $"({X}, {Y}) is {Distance} from the origin";
    }

    public class ReadOnlyTest
    {
        public static void Execute()
        {            
            var p = new Point { X=4, Y=8};
            Console.WriteLine(p.ToString());
            Console.ReadLine();
        }
    }
}
