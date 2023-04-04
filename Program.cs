//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

/*
void CreateArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите { i + 1} элемент массива ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int QuantityPositiveNumbers(int[] array)
{
    int i = 0;
    int sum = 0;
    while (i < array.Length)
    {
        if (array[i] > 0)
            sum = sum + 1;
            i = i + 1;
    }
    return sum;
}

Console.Write("Введите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
CreateArray(array);
Console.Write($"Количество чисел больше нуля: { QuantityPositiveNumbers(array)}");
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = Math.Round((-b2 + b1)/(-k1 + k2),2);
double y = Math.Round((k2 * x + b2),2);

Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");

