namespace N3__YP__Task_2_02._04._2025
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("enter num (5...10)");
            float.TryParse(Console.ReadLine() ,out float x );
            Console.WriteLine((x > 5 & x < 10) ? "да"  :"неизвестное число ");
        }
    }
}
