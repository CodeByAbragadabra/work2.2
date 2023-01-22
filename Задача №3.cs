internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число a (от 1 до 8): ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число b (от 1 до 8): ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число c (от 1 до 8): ");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число d (от 1 до 8): ");
        int d = Convert.ToInt32(Console.ReadLine());

        if (a <= 8 && a >= 1 && b <= 8 && b >= 1 && c <= 8 && c >= 1 && d <= 8 && d >= 1)
        {
            if (a % 2 == 0 && b % 2 == 0 && c % 2 == 0 && d % 2 == 0)
            {
                Console.WriteLine("Они одного цвета");
            }
            else
            {
                Console.WriteLine("Они разного цвета");
            }
        }
        else
        {
            Console.WriteLine("Посмотри на доску и посчитай клеточки");
        }
    }
}