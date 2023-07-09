
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

using System;

namespace Zadacha_2
{
    class program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("напишите первое число");
            int nam_A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("напишите второе число");
            int nam_B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("напишите третье число");
            int nam_f = Convert.ToInt32(Console.ReadLine());
            int namMax = 0;

            if ((nam_A > nam_B) & (nam_A > nam_f))
            {
                namMax = nam_A;
                Console.WriteLine("наибольшее число" + nam_A);
            }

            else if ((nam_B > nam_f) & (nam_B > nam_A))
            {
                namMax = nam_B;
                Console.WriteLine("наибольшее число" + nam_B);
            }

            else if ((nam_f > nam_A) & (nam_f > nam_B))
            {
                namMax = nam_f;
                Console.WriteLine("наибольшее число" + nam_f);
            }




        }
    }

}