// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//Метод Получения числа от пользователя
int InputUser(string msg)
{
    System.Console.Write($"{msg}  --> ");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

//Метод заполнения массива случайными положительными трехзначными числами 
int[] FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}

//Метод вывода массива
int[] ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

//Метод показывает количество чётных чисел в массиве
int ShowEvenNumberArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result++;
    }
    return result;
}

int userInput = InputUser("Введи количество элементов массива");
int[] myArray = new int[userInput];
FillArray(myArray);
ShowArray(myArray);
System.Console.WriteLine($"Количество четных чисел в массиве = {ShowEvenNumberArray(myArray)}");