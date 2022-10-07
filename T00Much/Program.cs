using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace T00Much
{
    internal class Program
    {
        static int upr1(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static void upr2(ref int left, ref int right)
        {
            int c = left;
            left = right;
            right = c;

        }


        static bool upr3(ref int a)
        {
            int ak = a;
            a = 1;
            for (int i = 1;i <= ak; i++)
            {
                try
                {
                    checked
                    {
                        a*=i;
                    }
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        static int upr4( int a)
        {
            if (a <= 1)
            {
                return 1;
            }
            else
            {
                return (a * upr4(a - 1));
            }
        }

        static int dz11(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -=a;
            }
            return a;
        }

        static int dz12(int a, int b, int c)
        {
            int ak = dz11(a,b);
            int bk = dz11(b,c);
            return dz11(ak, bk);
        }

        static int dz2(int a)
        {
            int cur = 1;
            if (a <= 2)
                cur = 1;
            if (a>2)
                cur = dz2(a-1) + dz2(a-2);
            return cur;
        }


        static void Main(string[] args)
        {
            
            Console.WriteLine("Задание 1. Наибольшее из 2");
            Console.WriteLine("Введите 1 число");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 число");
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine(upr1(a1,b1));
            


            Console.WriteLine("Задание 2. Поменять местами");
            Console.WriteLine("Введите 1 число");
            int a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 число");
            int b2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"1 число - {b2} 2 число - {a2}");
           


            Console.WriteLine("Задание 3. Найти факториал числа");
            Console.WriteLine("Введите число");
            int a3 = int.Parse(Console.ReadLine());
            bool b3 = upr3(ref a3);
            if (b3)
            {
                Console.WriteLine(b3);
                Console.WriteLine($"Факториал числа = {a3}");
            }
            else
            {
                Console.WriteLine(false);
            }
             

            Console.WriteLine("Задание 4. Найти факториал числа рекурсией");
            Console.WriteLine("Введите число");
            int a4 = int.Parse(Console.ReadLine());
            Console.WriteLine(upr4(a4));
            


            Console.WriteLine("Дом Задание 1. Нод 2 и 3 чисел");
            Console.WriteLine("Введите 1 число");
            int a11 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 число");
            int b11 = int.Parse(Console.ReadLine());
            Console.WriteLine(dz11(a11, b11));
            
            Console.WriteLine("Введите 1 число");
            int c11 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 число");
            int d11 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 3 число");
            int e11 = int.Parse(Console.ReadLine());
            Console.WriteLine(dz12(c11, d11,e11));
            
            Console.WriteLine("Дом Задание 2. Ряд фибоначи рекурсией");
            Console.WriteLine("Введите число");
            int a21 = int.Parse(Console.ReadLine());
            Console.WriteLine(dz2(a21));
        }
    }
}
