//Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
//  4 -> да
// -3 -> нет
//  7 -> нет
using System;

namespace Zadacha_3 
{
        class program
        {
            static void Main(string[]args)
            {
                
                Console.WriteLine("напишите первое число");
                int nam_A = Convert.ToInt32(Console.ReadLine());
                int z = 2;
                
                if (nam_A >0 && nam_A/z==0) 
                {
                    Console.WriteLine("ваше число подходит");
                }
                else
                {
                    Console.WriteLine("ваше число НЕ подходит");
                }   

            }
        }
        
} 