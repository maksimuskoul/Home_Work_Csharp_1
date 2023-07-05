/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
using System;

namespace Zadacha_4 
    {
        class program
        {
            static void Main(string[]args)
            {
                Console.WriteLine("Введите число");

                int nam_A = Convert.ToInt32(Console.ReadLine());
                
                int count = 1;
                while(count<=nam_A)
                {
                    if(count/2==0)
                    {
                        count++;
                        Console.Write(count+" ");
                    }
                    

                    
                }
                
                    
                    
                    
                    
               
            }
        }
        
    }   



    /*Console.WriteLine("Введите число");
    int nam_A = Convert.ToInt32(Console.ReadLine());
    int array[Console.ReadLine()]*/
