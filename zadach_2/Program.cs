    Console.Clear();
    Console.Write("Введите первое целое число: ");
    int number1 = int.Parse(Console.ReadLine());
    Console.Write("Введите второе целое число: ");
    int number2 = int.Parse(Console.ReadLine());
    if (number1>number2)
    {
      Console.Write($"Наибольшее число из введенных это: {number1}");
    }
    else
    {
      Console.Write($"Наибольшее число из введенных это: {number2}");
    }