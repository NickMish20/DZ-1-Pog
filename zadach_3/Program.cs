﻿/*Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница
*/
    Console.Clear();
    Console.Write("Введите целое число от 1 до 7: ");
    int number = int.Parse(Console.ReadLine());
    if (number == 1) Console.Write(" Понедельник");
    if (number == 2) Console.Write(" Вторник");
    if (number == 3) Console.Write(" Среда");
    if (number == 4) Console.Write(" Четверг");
    if (number == 5) Console.Write(" Пятница");
    if (number == 6) Console.Write(" Суббота");
    if (number == 7) Console.Write(" Воскресенье");
    if (number<1 || number>7) Console.Write("Вы ввели число не от 1 до 7");