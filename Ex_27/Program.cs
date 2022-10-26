/*Задача 27: Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

Console.WriteLine("Enter the number");
int userNumber = int.Parse(Console.ReadLine());
int length = userNumber.ToString().Length;
int result = 0;
int number = userNumber;
for (int i = 0; i < length; i++)
{
    result = result + userNumber % 10;
    userNumber = userNumber / 10;
}
Console.WriteLine($"сумма цифр в числе {number} ровна {result}");
