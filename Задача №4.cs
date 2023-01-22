internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите любой год нашей эры: ");
        double year = Convert.ToDouble(Console.ReadLine());

        switch ((year + 8) % 12)
        {
            case 0:
                Console.Write("Крыса, ");
                break;
            case 1:
                Console.Write("Корова, ");
                break;
            case 2:
                Console.Write("Тигр, ");
                break;
            case 3:
                Console.Write("Заяц, ");
                break;
            case 4:
                Console.Write("Дракон, ");
                break;
            case 5:
                Console.Write("Змея, ");
                break;
            case 6:
                Console.Write("Лошадь, ");
                break;
            case 7:
                Console.Write("Овца, ");
                break;
            case 8:
                Console.Write("Обезьяна, ");
                break;
            case 9:
                Console.Write("Петух, ");
                break;
            case 10:
                Console.Write("Собака, ");
                break;
            case 11:
                Console.WriteLine("Свинья, ");
                break;
        }

        switch (year % 10)
        {
            case 0:
                Console.Write("Белый");
                break;
            case 1:
                Console.Write("Белый");
                break;
            case 2:
                Console.Write("Черный");
                break;
            case 3:
                Console.Write("Черный");
                break;
            case 4:
                Console.Write("Зеленый");
                break;
            case 5:
                Console.Write("Зеленый");
                break;
            case 6:
                Console.Write("Красный");
                break;
            case 7:
                Console.Write("Красный");
                break;
            case 8:
                Console.Write("Желтый");
                break;
            case 9:
                Console.Write("Желтый");
                break;
        }
    }
}