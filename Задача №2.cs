internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите часы (от 0 до 23): ");
        int hours = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите минуты (от 0 до 59): ");
        int minutes = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите секунды (от 0 до 59): ");
        int seconds = Convert.ToInt32(Console.ReadLine());

        if (hours <= 23 && hours >= 0 && minutes <= 59 && minutes >= 0 && seconds <= 59 && seconds >= 0)
        {
            double angle = (hours + minutes / 60.0 + seconds / 3600.0) * 30.0;
            Console.WriteLine(angle);
        }
        else
        {
            Console.WriteLine("Почини часы свои, они чуть-чуть врут)))");
        }
    }
}