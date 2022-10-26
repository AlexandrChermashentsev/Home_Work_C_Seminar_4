/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
пример из 5 элементов:
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

получить все 8 чисел за одно нажатие Enter от пользователя.
подсказка: использовать метод Split();
*/

void RandomArray(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++) 
    {
        collection[i] = new Random().Next(1, 100);
    }
}

int[] array = new int[8];
RandomArray(array);
Console.WriteLine(string.Join(", ", array));
