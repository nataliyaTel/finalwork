// Задача:
// Написать программу ,которая из имеющего массива строк формирует массив из строк ,длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры ,либо задать на старте выполняемого алгоритма.
// При решении не рекомендуется пользоваться коллекциями,лучше обойтись исключительно массивами.

 
string[] array = new string[] { "1234", "1567", "-2", "computer science" }; // задаем массив на старте 

void SortElements(string[] arr)
{
    int n = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
         arr[n++] = arr[i];      
        }
    }
    Array.Resize(ref arr, n);
    PrintArray(arr);
}

void PrintArray(string[] matr)
{
    for (int i = 0; i < matr.Length; i++)
    {
        Console.Write($" {matr[i]}");
    }
    Console.WriteLine();
}

SortElements(array);