/*Задача 41: Пользователь вводит с клавиатуры 
M чисел. Посчитайте, сколько чисел больше 
0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int[] InitArray(int length)
{
    int[] myArray = new int[length];
    //int mass = int.Parse(Console.ReadLine());
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = int.Parse(Console.ReadLine());
    }
    return myArray;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int GetPositiv(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] > 0))
        {
            counter++;
        }
    }
    return counter;
}
Console.WriteLine("Введите размерность массива:");
int length = int.Parse(Console.ReadLine());
Console.WriteLine("Введите массив ");
int[] arr = InitArray(length);
Console.WriteLine();
PrintArray(arr);
int count = GetPositiv(arr);
Console.WriteLine($"Положительных чисел в массиве {count}");