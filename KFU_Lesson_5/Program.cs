using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU_Lesson_5
{
    struct dedinside
    {
        string name;
        byte angry;
        string[] fraz;
        byte sinyak;
        dedinside(string name1, byte angry1, string[] fraz1, byte sinyak1)
        {
            name = name1;
            angry = angry1;
            fraz = fraz1;
            sinyak = sinyak1;
        }

    }
    internal class Program
    {
        static void kvadrat(float a, float b, float c)
        {
            if (b * b - 4 * a * c > 0)
            {
                Console.WriteLine($"X1 = {(-b + Math.Sqrt(b * b - 4 * a * c)) / (a * 2)}");
                Console.WriteLine($"X2 = {(-b - Math.Sqrt(b * b - 4 * a * c)) / (a * 2)}");
            }
            if (b * b - 4 * a * c == 0)
            {
                Console.WriteLine($" Одно решение X = {(-b + Math.Sqrt(b * b - 4 * a * c)) / (a * 2)}");

            }
            if (b * b - 4 * a * c < 0)
            {
                Console.WriteLine("Нет решений :-/");
            }
        }


        static void massiv(int[] arr2, int a,int b)
        {
            int aa2 = 0, bb2 = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] == a)
                {
                    aa2 = i;
                }
                if (arr2[i] == b)
                {
                    bb2 = i;
                }
            }
            int [] arr22 = new int[20];
            for (int i = 0; i < arr2.Length; i++)
            {
                if (i == aa2)
                {
                    arr22[i] = b;
                }
                else if (i == bb2)
                {
                    arr22[i] = a;
                }
                else
                {
                    arr22[i] = arr2[i];
                }
            }
            Console.WriteLine(string.Join(" ", arr22));
        }


        static int[] sortir(int[] arr)
        {
            int c;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1;j< arr.Length; j++)
                {
                    c = arr[j];
                    arr[j] = arr[i];
                    arr[i] = c;
                }
            }
            return arr;
        }


        static int massa(ref int proiz, out double srznach,params int[] arr)
        {
            int summ = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                summ += arr[i];
                proiz *= arr[i];
            }
            srznach = summ / arr.Length;
            return summ;
            
        }

        static void cifra()
        {

            var numbers = new Dictionary<int, string>()
            {
                [0] = "####" + "\n" + "#  #" + "\n" + "#  #" + "\n" + "#  #" + "\n" + "#  #" + "\n" + "####",
                [1] = " # " + "\n" + "## " + "\n" + " # " + "\n" + " # " + "\n" + " # " + "\n" + "###",
                [2] = " # " + "\n" + "# #" + "\n" + "  #" + "\n" + " # " + "\n" + "#  " + "\n" + "###",
                [3] = "###" + "\n" + "  #" + "\n" + " # " + "\n" + "  #" + "\n" + "###",
                [4] = "# #" + "\n" + "# #" + "\n" + "###" + "\n" + "  #" + "\n" + "  #",
                [5] = "###" + "\n" + "#  " + "\n" + "###" + "\n" + "  #" + "\n" + "## ",
                [6] = " ##" + "\n" + "#  " + "\n" + "###" + "\n" + "# #" + "\n" + "###",
                [7] = "####" + "\n" + "   #" + "\n" + "  # " + "\n" + " #  " + "\n" + "#  ",
                [8] = "####" + "\n" + "#  #" + "\n" + " ## " + "\n" + "#  #" + "\n" + "####",
                [9] = "####" + "\n" + "#  #" + "\n" + "####" + "\n" + "   #" + "\n" + "####",
            };
            Console.WriteLine("ввести число либо завершить работу. нажмите: (0 // 1)");
            int input = int.Parse(Console.ReadLine());
            if (input == 0)
            {
                try
                {
                    Console.WriteLine("введите число");
                    int vvod = int.Parse(Console.ReadLine());
                    if (vvod >= 0 && vvod <= 9)
                    {
                        Console.WriteLine(numbers[vvod]);
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вы ввели не цифру!!!");
                        System.Threading.Thread.Sleep(3000);
                        Console.ResetColor();
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("напишите закрыть или exit...");
                string exit = Console.ReadLine();
                if (exit == "exit" || exit == "Exit" || exit == "закрыть" || exit == "Закрыть")
                {
                    Environment.Exit(0);
                }
            }
        }







        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Задание 1. Найти корни квадратного уравнения");
            Console.WriteLine("Введите коэфицент а");
            float a1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэфицент b");
            float b1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэфицент c");
            float c1 = float.Parse(Console.ReadLine());
            kvadrat(a1, b1, c1);
            
            

            Console.WriteLine("Задание 2. Поменять местами случайные элементы массива");
            int[] arr2 = new int[20];
            Random rand2 = new Random();
            bool podhod = true;
            for (int i = 0; i < arr2.Length; i++)
            {
                int k = rand2.Next(-10, 15);
                for (int j = 0; j < i; j++)
                {
                    podhod = true;
                    if (arr2[j] == k)
                    {
                        podhod = false;
                        break;
                    }
                }
                if (podhod)
                {
                    arr2[i] = k;

                }
                else
                {
                    i--;
                }
            }
            Console.WriteLine(string.Join(" ", arr2));
            Console.WriteLine("Введите 1 число из масива");
            int a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 число из масива");
            int b2 = int.Parse(Console.ReadLine());
            massiv(arr2, a2, b2);
            


            Console.WriteLine("Задание 3. Сортировка пузырьком");
            int[] arr3 = {4,6,2,3,5,1,-1,0,-2,-3};
            Console.WriteLine(string.Join(", ",sortir(arr3)));
            


            Console.WriteLine("Задание 4. Изучение массива");
            int[] arr4 = { 4, 6, 2, 3, 5, 1, -1, 100, -2, -3 };
            int proiz = 1;
            double srznach = 1; 
            int a4  = massa(ref proiz, out srznach, arr4);
            Console.WriteLine($"Сумма масива = {a4}");
            Console.WriteLine($"Произведение массива = {proiz}");
            Console.WriteLine($"Среднее значение = {srznach}");
            */


            Console.WriteLine("Задание 5");
            cifra();



            /*
            Console.WriteLine("Задание 7. Быстрая сортировка массива");
            int[] arr7 = { 4, 6, 2, 3, 5, 1, -1, 100, -2, -3 };
            int[] sortedArr7 = quicksort(0, arr7.Length - 1,arr7);
            Console.WriteLine(String.Join(", ", sortedArr7));
            */
        }


        static int[] quicksort(int minim,int maxim,params int[] arr)
        {
            if(minim >= maxim)
            {
                return arr;
            }
            int pivoindex = findpivoindex(minim, maxim, arr);
            quicksort(minim, pivoindex-1, arr);
            quicksort(pivoindex+1, maxim, arr);

            return arr;
        }
        static int findpivoindex(int minim,int maxim, params int[] arr)
        {
            int pivo = minim - 1;
            for (int i = minim; i <= maxim; i++)
            {
                if (arr[i] < arr[maxim])
                {
                    pivo++;
                    swap(ref arr[pivo], ref arr[i]);
                }
                
                    
            }
            pivo++;
            swap(ref arr[pivo], ref arr[maxim]);

            return pivo;
        }
        static void swap(ref int left, ref int right)
        {
            int a = left;
            left = right;
            right = a;
        }
    }
}
