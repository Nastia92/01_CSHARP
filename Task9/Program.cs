// Вывести 1 и 3 число
// System.Console.Write("Введите трёхзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 99 && number < 1000)
// {
// int leftDigit = number / 100;
// int rightDigit = number % 10;
// System.Console.Write(leftDigit);
// System.Console.Write(rightDigit);
// }
// else
// {
//     System.Console.WriteLine("Введено не трехзначное число!");
// }
// 

// Тот же вывод но с добавлением числа в переменную 
// System.Console.Write("Введите трёхзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 99 && number < 1000)
// {
// int leftDigit = number / 100;
// int rightDigit = number % 10;
// int newNumber = leftDigit * 10 + rightDigit;
// System.Console.WriteLine(newNumber);
// }
// else
// {
// System.Console.WriteLine("Введено не трёхначное число!");
// }

// Программа, кот. принимает на вход трёхзначное число и возводит вторую цифру этого числа в степень,равную третьей цифре.



// 

// -----Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно
// второму, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1-----

// System.Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 % num2 == 0)
// System.Console.Write("Да");

// else
// System.Console.Write($"Нет, {num1 % num2}" );

// -----Программа кот. выводит 3 с конца цифру или сообщает что её нет.

// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number > 99)
// {
//     int resultNumber = number % 1000 /100;
//     System.Console.WriteLine(resultNumber);
// }
// else
// {
//     System.Console.Write("Третьей цифры нет");
// }

// -----Рассмотрим программу кот. выводит 3 число сначала.

// 
