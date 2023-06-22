// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.Write("Введите количество элементов массива: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] randomArray = new int[a];

// void mas(int a)
// {
// for (int i = 0; i < a; i++)
// {
// randomArray[i] = new Random().Next(99,999);
// Console.Write(randomArray[i] + " ");

// }
// Console.WriteLine ();
// }

// int kol(int[] randomArray)
// {
// int kol = 0;
// for (int i = 0; i < randomArray.Length; i++)
// {
// if (randomArray[i] % 2 == 0)
// kol = kol + 1;
// }
// return kol;
// }

// mas(a);


// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами.Найдите 
// сумму элементов, стоящих на нечётных позициях.


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);

PrintArray(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

    Console.WriteLine($"Cумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(-100,101);
        }
}
void PrintArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }

    Console.WriteLine();
}