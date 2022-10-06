using System;

namespace pr2
{
    internal class Program
    {
        static void Main()
        {

            int vashVybor = 1;
            while (vashVybor != 4)
            {
                Console.WriteLine("У вас есть выбор из трех программ: \n1 - Угадайка\n2 - Делители числа\n3 - Таблица умножения\n4 - Выход из программы)");
                vashVybor = Convert.ToInt32(Console.ReadLine());
                if (vashVybor == 1) ygadayka();
                if (vashVybor == 2) deliteli();
                if (vashVybor == 3) tablizaumnojeniya();
            }
        }

        static void ygadayka()
        {
            Random rand = new Random();
            int i = rand.Next(100);
            int o = 1;
            Console.WriteLine("Компьютер загадал число от 0 до 100. у тебя есть 3 попытки.");
            Console.WriteLine("Введите первое число:");

            int k = Convert.ToInt32(Console.ReadLine());
            while (o <= 3)
            {
                if (i == k)
                {
                    Console.WriteLine("Да! Компьютер загадал число " + k + "!");
                    break;
                }
                else
                {
                    o++;
                    if (o == 4)
                    {
                        Console.WriteLine("Увы, вы не отгодали загаданное число. Это было число " + i + "!");
                        break;
                    }
                    Console.WriteLine("Нет, это не число " + k + "! Попытка № " + o + ":");
                    k = Convert.ToInt32(Console.ReadLine());
                }

            }
        }

        static void deliteli()
        {
            Console.Write("число? ");
            var n = int.Parse(Console.ReadLine());
            Console.Write("делители: ");
            for (var c = 2; c <= n / 2; ++c) if (n % c == 0) Console.Write(" {0}", c) ; Console.Write(" {0}", n / 1) ; Console.Write(" {0}" , n/n) ;
            Console.WriteLine();

        }

        static void tablizaumnojeniya()
        {
            Console.WriteLine("Это таблица умножения");
            Console.WriteLine("\ny/x |\t1\t2\t3\t4\t5\t6\t7\t8\t9");
            Console.Write("--------------------------------------------------------------------------");
            Console.WriteLine();
            for (int l = 1; l < 10; l++)
            {
                Console.WriteLine(l + " | ");
                for (int j = 1; j < 10; j++)
                {
                    int[,] Matrix = new int[10, 10];
                    Matrix[l, j] = l * j;
                    Console.Write("\t" + Matrix[l, j]);
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }
    }
}
