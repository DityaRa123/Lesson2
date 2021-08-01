using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;
namespace Lesson2
{


    class Program
    {

        ///// author: Андрей Коваленко
        ///// Написать метод, возвращающий минимальное из трёх чисел.
        //static int MinNum()
        //{
        //    WriteLine("Введите три целых числа: ");
        //    int a = Convert.ToInt32(Console.ReadLine());
        //    int b = Convert.ToInt32(Console.ReadLine());
        //    int c = Convert.ToInt32(Console.ReadLine());
        //    int min = a;
        //    if (b < min) min = b;
        //    if (c < min) min = c;
        //    return min;
        //}
        //static void Main(string[] args)
        //{
        //    WriteLine($"Наименьшее из трех введенных чисел равно {MinNum()}");
        //    ReadLine();
        //}




        // author: Андрей Коваленко
        // Написать метод подсчета количества цифр числа.
        static void Main(string[] args)
        {
            //do
            //{
            //    int num;
            //    do
            //    {
            //        Clear();
            //        Write("Введите целое число для подсчёта количества знаков: ");
            //    } while (!int.TryParse(ReadLine(), out num));

            //    num = Abs(num);

            //    var count = -1;
            //    if (num == 0) count = 1;
            //    else while ((num / Pow(10, ++count)) >= 1) ;

            //    WriteLine($"В ведённом числе {count} знаков");
            //    Write("Для выхода нажмите ESC");
            //} while (ReadKey().Key != ConsoleKey.Escape);




            // author: Андрей Коваленко
            // С клавиатуры вводятся числа, пока не будет введен 0. 
            // Подсчитать сумму всех нечетных положительных чисел.

            //WriteLine("Подсчитаем все введённые нечётные положительные числа. \n введите 0, чтобы прервать подсчёт");
            //int b = 0;
            //while (true)
            //{
            //    int a = Convert.ToInt16(ReadLine());

            //    if (a != 0)
            //    {
            //        if (a % 2 == 0)
            //        { }
            //        else
            //            b += a;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //WriteLine(b);
            //ReadKey();


            // author: Андрей Коваленко
            // Реализовать метод проверки пароля. Ограничить тремя попытками через do while. 
            String Login_true = "root";
            String Pass_true = "GeekBrains";
            var attempts = 0;
            bool pass_control = false;

            do
            {
                WriteLine("Введите логин: ");
                string Login = ReadLine();
                WriteLine("Введите пароль: ");
                string Pass = ReadLine();
                attempts++;
                if (Login == Login_true && Pass == Pass_true)
                { pass_control = true; break; }
                else
                if (attempts < 3)
                { WriteLine("Неверно, попробуйте ещё раз."); }
            }
            while (attempts < 3);
            if (pass_control) { WriteLine("Доступ разрешён, добро пожаловать."); }
            else { WriteLine("Доступ запрещён!"); }

        }
    }
}
