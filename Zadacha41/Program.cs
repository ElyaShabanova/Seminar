/* Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.*/


int[] InputNumbers(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-е (из {num}) число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}


int NumPositive(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ",");
    }
}

Console.Write("Укажите количество чисел для ввода: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] arr = InputNumbers(number);

Console.WriteLine($"Кол-во элементов > 0: {NumPositive(arr)}");

PrintArray(arr);

