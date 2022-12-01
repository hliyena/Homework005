// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.


// Console.WriteLine("Введите количество элементов массива:  ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("массив: ");
// PrintArray(numbers);
// int count = 0;

// for (int a = 0; a < numbers.Length; a++)
// if (numbers[a] % 2 == 0)
// count++;

// Console.WriteLine($"Количество четных чисел в массиве: {count}");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//      for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.WriteLine();
// }



// // Задача 36: Задайте одномерный массив, заполненный случайными числами.
// // Найдите сумму элементов, стоящих на нечётных позициях(индексы элементов должны быть нечетными(1,3,5 и тд)).


// Console.WriteLine("Введите количество элементов массива  ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);

// PrintArray(numbers);
// int sum = 0;

// for (int a = 0; a < numbers.Length; a+=2)
//     sum = sum + numbers[a];

//     Console.WriteLine($"Сумма элементов на нечетных позициях равна: {sum}");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = new Random().Next(1,10);
//         }
// }
// void PrintArray(int[] numbers)
// {
//       for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }   
//     Console.WriteLine();
// }



// // Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// // Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// // Результат запишите в новом массиве.

// int A = 6;
// int[] array = new int[A];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 6);
//     Console.Write(array[i] + "  ");
// }
// Console.WriteLine();

// int j = array.Length - 1;
// for (int i = 0; i < (array.Length + 1) / 2; i++)
// {
//     Console.Write(array[i] * array[j] + "  ");
//     j--;
// }




// // Задача 38: Задайте массив целых чисел от -10 до 10. Найдите разницу между максимальным и минимальным элементов массива.




// int A = 8;
// int[] array = new int[A];
// int max = array[0];
// int min = array[0];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-10, 10);
//     Console.Write(array[i] + "  ");
// }
// Console.WriteLine();

// for (int j = 0; j < array.Length; j++)
// {
//     if (array[j] > max) max = array[j];
//     if (array[j] < min) min = array[j];
// }
// Console.WriteLine();
// Console.Write("Разница между max и min элементами составляет: ");
// Console.Write(max - min);