using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkModule3
{
    internal class Program
    {
        /// <summary>
        /// ·	Напечатать весь массив целых чисел
        /// </summary>
        static void Exmpl1()
        {
            Random rand = new Random();
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 100);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }


        }
        /// <summary>
        /// ·	Найти индекс максимального значения в массиве (воспользоваться функцией)
        /// </summary>
        static void Exmpl2()
        {
            Random rand = new Random();
            int[] arr = new int[5];
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 100);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i]) max = arr[i];
            }
            Console.WriteLine("max:" + max);
        }
        /// <summary>
        /// ·	Найти индекс максимального четного значения в массиве
        /// </summary>
        static void Exmpl3()
        {
            Random rand = new Random();
            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 100);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            int[] arr2 = new int[arr.Length - 1];
            int RemoveIndex = 3;
            int newIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != RemoveIndex)
                {
                    arr2[newIndex] = arr[i];
                    newIndex++;

                }
            }
            Console.WriteLine("Removed:");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }


        }
        /// <summary>
        /// ·	Удалить элемент из массива по индексу.
        /// </summary>
        static void Exmpl4()
        {
            Random rand = new Random();
            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 100);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            int Remove = 3;
            int newIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != Remove)
                {

                    newIndex++;

                }
            }
            Console.WriteLine("Removed");
            int[] arr2 = new int[newIndex];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != Remove)
                {
                    arr2[index] = arr[i];
                    index++;
                }
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

        }
        /// <summary>
        /// ·	Удаление элементов из массива по значению
        /// </summary>
        static void Exmpl5()
        {
            Random rand = new Random();
            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 100);
                Console.Write(arr[i] + " ");
            }

            int[] arr2 = new int[arr.Length + 1];
            int index = 2;
            int val = 3;
            for (int i = 0; i < index; i++)
            {
                arr2[i] = arr[i];
            }
            arr2[index] = val;
            for (int i = index; i < arr.Length; i++)
            {
                arr2[i + 1] = arr[i];
            }
            Console.WriteLine("Vstavka");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
        }
        /// <summary>
        /// ·	Вставить элемент в массив по индексу
        /// </summary>
        static void Exmpl6()
        {
            string str = "apple long";
            string[] words = str.Split(' ');
            string res = "";
            foreach (string word in words)
            {
                if (!word.Contains('a'))
                {
                    res += word + " ";
                }
            }
            res = res.Trim();
            Console.WriteLine(res);
        }
        /// <summary>
        /// ·	Удалить те элементы массива, которые встречаются в нем ровно два раза
        /// </summary>
        static void Exmpl7()
        {
            string str = "brad long";
            string[] words = str.Split(' ');
            string Lastw = words[words.Length - 1];

            string res = "";
            foreach (string word in words)
            {
                if (!word.Contains(Lastw))
                {
                    res += word + " ";
                }
            }
            res = res.Trim();
            Console.WriteLine(res);

        }
        /// <summary>
        /// ·	Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка. 
        /// Программа должна сосчитать количество введенных пользователем пробелов. (Подсказка. IF, Length)
        /// </summary>
        static void Exmpl8()
        {
            int space = 0;
            while (true)
            {
                string str = Console.ReadLine();
                if (str == " ") space++;
                if (str == ".") break;

            }
            Console.WriteLine(space);
        }
        /// <summary>
        /// ·	Ввести с клавиатуры номер трамвайного билета (6-значное число) и проверить является 
        /// ли данный билет счастливым (если на билете напечатано шестизначное число,
        /// и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).
        /// </summary>
        static void Exmpl9()
        {

            Console.WriteLine("Введдите номер трамвайного билета (6-значное число): ");
            string str = Console.ReadLine();
            int[] arr = str.Select(x => x - '0').ToArray();
            int sum1 = arr[0] + arr[1] + arr[2];
            int sum2 = arr[5] + arr[4] + arr[3];
            if (sum1 == sum2)
            {
                Console.WriteLine("У вас счастливый билет");
            }
            else
            {
                Console.WriteLine("У вас несчастный билет");
            }
        }
        /// <summary>
        /// ·	Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100.
        /// Определить сумму элементов массива, расположенных между минимальным и максимальным элементами
        /// </summary>
        static void Exmpl10()
        {
            Random rand = new Random();
            int[,] arr = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = rand.Next(-100, 101);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr[i, j] + "\t");

                }
                Console.WriteLine();
            }
            int min = arr[0, 0];
            int max = arr[0, 0];
            int minRowIndex = 0;
            int minColIndex = 0;
            int maxRowIndex = 0;
            int maxColIndex = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        minRowIndex = i;
                        minColIndex = j;
                    }
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        maxRowIndex = i;
                        maxColIndex = j;
                    }
                }
            }
            int startRow = Math.Min(minRowIndex, maxRowIndex);
            int endRow = Math.Max(minRowIndex, maxRowIndex);
            int startCol = Math.Min(minColIndex, maxColIndex);
            int endCol = Math.Max(minColIndex, maxColIndex);


            int sum = 0;
            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startCol; j <= endCol; j++)
                {
                    sum += arr[i, j];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);

        }
        static void p()
        {
            string str = "python plu";
            int res = 0;
            foreach (char c in str)
            {
                if (c == 'p') res++;
            }
            Console.WriteLine(res);
        }
        static void one()
        {
            string str = "one two three";
            if (str.Contains("one")) Console.WriteLine("yes");
            else Console.WriteLine("no");
        }
        static void l3()
        {
            string str = "apple long444";
            int res = 0;
            foreach (char c in str)
            {
                if (Char.IsDigit(c)) res++;
            }
            Console.WriteLine(res);
        }
        static void l4()
        {
            int a = 365;
            int revers = 0;
            while (a > 0)
            {
                int d = a % 10;
                revers = revers * 10 + d;
                a /= 10;

            }
            Console.WriteLine(revers);
        }

        static void same()
        {
            string str = "класс";
            char[] l = str.ToCharArray();
            for (int i = 0; i < l.Length - 1; i++)
            {
                if (l[i] == l[i + 1])
                {
                    l[i + 1] = '1';
                }
            }
            string res = new string(l);
            Console.WriteLine(res);
        }



        static void Main(string[] args)
        {
            Exmpl1();
            Console.ReadKey();
        }
    }
}