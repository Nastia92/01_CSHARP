System.Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

// ---------Реализация с циклом WHILE-----------
// int i = -number;
// while(i <= number)
// {
//  System.Console.Write(i + " ");   
//  i++;
// }

// ---------Реализация с циклом FOR-----------

for(int i = -number; i <= number; i++)
{
 System.Console.Write(i + " ");   
}