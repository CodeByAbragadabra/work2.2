internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите пятизначное ЦЕЛОЕ число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int character1 = number % 10;
        int character2 = number % 100 / 10;
        int character3 = number % 1000 / 100;
        int character4 = number % 10000 / 1000;
        int character5 = number % 100000 / 10000;

        Console.Write(character1);
        Console.Write(character2);
        Console.Write(character3);
        Console.Write(character4);
        Console.Write(character5);
    }
}