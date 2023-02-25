// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//Метод Получения числа от пользователя
int InputUser(string msg)
{
    System.Console.Write($"{msg}  --> ");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

//Метод заполнения массива случайными вещественными числами
double[] FillArray(double[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(random.Next(1, 1000) / 10.0);
    }
    return array;
}

//Метод вывода массива
double[] ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

//Метод показывает разницу между максимальным и минимальным элементов массива
double ShowDifferenceMaxMinArray(double[] array)
{
    double maxValue = array[0];
    double minValue = array[1];
    if (maxValue < minValue)
    {
        maxValue = minValue;
        minValue = array[0];
    }
    for (int i = 2; i < array.Length; i++)
    {
        if (maxValue < array[i]) maxValue = array[i];
        if (minValue > array[i]) minValue = array[i];
    }
    return Math.Round(maxValue - minValue, 2);
}

int userInput = InputUser("Введи количество элементов массива");
double[] myArray = new double[userInput];
FillArray(myArray);
ShowArray(myArray);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {ShowDifferenceMaxMinArray(myArray)}");