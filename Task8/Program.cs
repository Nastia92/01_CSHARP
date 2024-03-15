// int a = 15.0;
// int b = 4;
// int result = a % b;
// System.Console.WriteLine(result); 

// double a = 15.0;
// int b = 4;

// System.Console.WriteLine(a/b); 


// Задача 3
// System.Console.Write(Введите трёхзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 99 && number < 1000)
// {
//     int leftDigit = number / 100;
//     int rightDigit = number % 10;
//     int sum = leftDigit + rightDigit;
//     System.Console.WriteLine($"{number} => {sum}");
// }
// else
// {
//     System.Console.WriteLine("Введено не трехзначное число!");
// }


// Укороченный вариант
System.Console.Write(Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

 if (number > 99 && number < 1000)
{
   System.Console.WriteLine($"{number} => {number / 100 + number % 10}");
}
else
{
    System.Console.WriteLine("Введено не трехзначное число!");
}



