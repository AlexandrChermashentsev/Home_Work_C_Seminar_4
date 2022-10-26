/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int GetNumber (string message)
{
    int userNumber;
    while (true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out int number))
        {
            userNumber = number;
            break;
        }
        else Console.WriteLine("Давайте все таки введем целое число");
    }
    return userNumber;
}
int numberOne = GetNumber("Введите число");
int degree = GetNumber("Введите степень, в которую хотим возвести число");
int result = 1;
for (int i = 1; i <= degree; i++)
{
    result = result * numberOne;
}

Console.WriteLine($"{numberOne} в степени {degree} = {result}");
