namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int result;

            Calc.Triple(x, out result);
            Console.WriteLine(result);
        }
    }
}