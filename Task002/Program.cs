// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

//Метод Получения числа от пользователя
int InputUser(string msg)
{
    Console.Write($"{msg}  --> ");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

//Метод заполнения массива случайными числами от -100 до 100
int[] FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-100, 100);
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

//Метод показывает сумму элементов стоящих на нечёных позициях
int ShowSumOddPositionNumberArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) result += array[i];
    }
    return result;
}

int userInput = InputUser("Введи количество элементов массива");
int[] myArray = new int[userInput];
FillArray(myArray);
ShowArray(myArray);
Console.WriteLine($"Сумма элементов массива стоящих на нечетных позициях = {ShowSumOddPositionNumberArray(myArray)}");