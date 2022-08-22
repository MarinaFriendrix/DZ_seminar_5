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
// вариант 1.

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

int max = int.MinValue;
int min = int.MaxValue;
foreach (int t in myArray)
{
    if (t < min)
    min = t;
    if (t > max)
    max = t;
}


Console.WriteLine("Max: {0}", max);
Console.WriteLine("Min: {0}", min);

int raz = max - min;
Console.WriteLine("Разница: " +raz);


// вариант 2.(Методы создания и вывода массива оставляем из варианта 1.)
// int[] myArray = CreateRandomArray(-100, 100);
// ShowArray(myArray);
// int min = myArray[0];
// int max = myArray[0];
// for (int i = 1; i < myArray.Length; i++)
// {
//     if (myArray[i] < min)
//     {
//         min = myArray[i];
//     }
//     else
//     {
//         if (myArray[i] > max)
//         {
//             max = myArray[i];
//         }
//     }
// }
// Console.WriteLine("Минимум: " +min);
// Console.WriteLine("Максимум: " +max);

// int raz = max - min;
// Console.WriteLine("Разница: " +raz);
