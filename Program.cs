// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateRandomArray(int start, int end)
// {
// Console.WriteLine("Введите кол-во элементов массива: ");
//     int N = Convert.ToInt32(Console.ReadLine());
// int[] RandomArray = new int[N];
// for (int i = 0; i < N; i++)
// {
//     RandomArray[i] = new Random().Next(start, end + 1);
// }
// return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]+ " ");
//     }
//     Console.WriteLine();
// }

// int[] myArray = CreateRandomArray(100, 999);
// ShowArray(myArray);

// int count = 0;

// for (int i = 0; myArray[i] % 2 ==0; i++)
// {
//     count = count + 1;
  
// }

// Console.Write(count);


// Задача 36. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// int[] CreateRandomArray(int start, int end)
// {
// Console.WriteLine("Введите кол-во элементов массива: ");
//     int N = Convert.ToInt32(Console.ReadLine());
// int[] RandomArray = new int[N];
// for (int i = 0; i < N; i++)
// {
//     RandomArray[i] = new Random().Next(start, end + 1);
// }
// return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]+ " ");
//     }
//     Console.WriteLine();
// }
// int[] myArray = CreateRandomArray(-100, 100);
// ShowArray(myArray);

// int sum_odd = 0;

// for (int i = 0; i<myArray.Length; i++)
// {
//     if (i % 2 != 0)
//     {
//         sum_odd = sum_odd + myArray[i];
//     }
// }
// Console.Write(sum_odd);


// Задача 38. Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
int[] CreateRandomArray(int start, int end)
{
Console.WriteLine("Введите кол-во элементов массива: ");
    int N = Convert.ToInt32(Console.ReadLine());
int[] RandomArray = new int[N];
for (int i = 0; i < N; i++)
{
    RandomArray[i] = new Random().Next(start, end + 1);
}
return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}
int[] myArray = CreateRandomArray(-100, 100);
ShowArray(myArray);

