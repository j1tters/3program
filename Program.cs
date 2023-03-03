namespace myprograms
{
    class Program
    {
        static void Main()
        {
            bool w=true;
            while (w)
            {
                Console.WriteLine("Выберите программу написав её номер\n" +
    "1. Игра \"Угадай число\"\n" +
    "2. Таблица умножения\n" +
    "3. Вывод делителей числа\n");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        GuessTheNumber();
                        break;
                    case 2:
                        MultiplicationTable();
                        break;
                    case 3:
                        OutputOfNumberDivisors();
                        break;
                    case 4:
                        w= false;
                        break;
                    default:
                        Console.WriteLine("вы ввели не то число, вы линуксойд?");
                        break;
                }
            }
        }
        static void GuessTheNumber()
        {
            Random rand = new Random();
            int myNum;
            int secret = rand.Next(100) + 1;
            Console.WriteLine("Компьютер загадал число от 0 до 100. Попробуйте отгодать его.");

            while (true)
            {
                myNum = int.Parse(Console.ReadLine());
                if (myNum == secret)
                {
                    Console.WriteLine("Угадали");
                    break;
                }
                else if (myNum > secret)
                {
                    Console.WriteLine("Надо Меньше");
                }
                else
                {
                    Console.WriteLine("Надо Больше");
                }
            }
        }
        static void MultiplicationTable()
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.Write(i + "\t");
                for (int j = 1; j <= 3; j++)
                {
                    if (i > 0) Console.Write(i * j + "\t");
                    else Console.Write(j + "\t");
                }
                Console.Write("\n");
            }

        }

        static void OutputOfNumberDivisors()
        {
            while (true)
            {
                Console.Write("\nВведи число или напишите \"выйти\" ");
                string v = Console.ReadLine();
                if (v != "выйти")
                {
                    int i = Convert.ToInt32(v);
                    for (int a = 1; a <= i; a++)
                        if (i % a == 0)
                            Console.Write("{0} ", a);
                }
                else
                    return;
            }
        }

    }
        
}