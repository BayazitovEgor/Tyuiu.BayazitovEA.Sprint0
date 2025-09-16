using Tyuiu.BayazitovEA.Sprint0.Task5.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("A+B=" + DataService.Addition(1, 5));
        Console.WriteLine("A-B=" + DataService.Subtraction(1, 5));
        Console.WriteLine("A*B=" + DataService.Multiplication(1, 5));
        Console.WriteLine("A/B=" + DataService.Division(1, 5));
        Console.ReadKey();  
    }
}