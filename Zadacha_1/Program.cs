// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

using System;

namespace Zadacha_1 
    {
        class program
        {
            static void Main(string[]args)
            {
                Console.WriteLine("напишите первое число");
                int nam_A = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("напишите второе число");
                int nam_B = Convert.ToInt32(Console.ReadLine());

                int max = 0;

                    if (nam_A > nam_B)
                    {
                        max = nam_A;
                        Console.WriteLine("первое  число больше");
                    }
                        else 
                        {
                            max = nam_B;
                            Console.WriteLine("второе  число больше");
                        }
                    

            }
        }
        
    }   