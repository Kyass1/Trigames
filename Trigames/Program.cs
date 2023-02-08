namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                while (true)
                {
                    Console.WriteLine(@"Выбери действие которое хочешь выполнить:
                    1.Игра угадай число
                    2.Таблица умножения
                    3.Выйти из программы");
                    string a = Console.ReadLine();
                    if (a == "1")
                    {
                        Console.Write("Введите 1ое число: ");
                        int x = int.Parse(Console.ReadLine());
                        Console.Write("Введите 2ое число: ");
                        int y = int.Parse(Console.ReadLine());

                        Random random = new Random();
                        int k = random.Next(x, y);
                        int count = 0;
                        string str;

                        Console.WriteLine("Угадайте число в интервале от {0} до {1}\n", x, y);

                        do
                        {
                            Console.Write("Ваш вариант: ");
                            str = Console.ReadLine();

                            if (int.Parse(str) < k)
                                Console.WriteLine("Задуманное число больше");
                            if (int.Parse(str) > k)
                                Console.WriteLine("Задуманное число меньше");

                            count++;
                        }
                        while (int.Parse(str) != k);

                        Console.WriteLine("Вы угадали с {0} попытки", count);
                        Console.ReadLine();
                    }
                    if (a == "2")
                    {
                        for (int i = 1; i <= 10; i++)
                        {
                            for (int j = 1; j <= 10; j++)
                            {
                                Console.Write("{0}\t", i * j);
                            }
                            Console.Write("\n");
                        }
                    }
                    if (a == "3")
                    {
                        Environment.Exit(0);
                    };
                }
            }
        }
    }
}
            