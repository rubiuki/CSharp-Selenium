namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int outer = 0;

            while (outer < 3)
            {
                int inner = 10;
                while(inner > 5)
                {
                    Console.WriteLine($"Outer: {outer}\tInner: {inner}");
                    inner--;
                }
                outer++;
            }
        }
    }
}