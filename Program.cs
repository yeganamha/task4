namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathHelper mathHelper = new MathHelper();

            Console.WriteLine(mathHelper.PrintValue(4, 5));
            Console.WriteLine(mathHelper.PrintValue(true));
            Console.WriteLine(mathHelper.PrintValue(4, 5, 2));

            mathHelper.PrintValue("Yegana", "Hasanova");


        }
    }
}