namespace H
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print(GetSquare(42));
        }
        public static void Main()
        {
            Print(GetSquare(42));
        }
        static int GetSquare(double number)
        {
            number = (int)Math.Round(number);
            return Math.Pow(number, 2);
        }

        static void Print(int v)
        {
            Console.WriteLine();
        }
    }
}
