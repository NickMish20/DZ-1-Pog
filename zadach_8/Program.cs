﻿/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
    */
    Console.Clear();    
    Console.Write("Введите целое число N от 1 до бесконечности: ");
    int number = int.Parse(Console.ReadLine());
    int count = 1;
    Console.WriteLine($"Все четные числа от 1 до {number}:");
    while(count<=number)
      {
        if (count%2==0)
          {
            Console.Write($" {count}");
          }
      count++;
      }