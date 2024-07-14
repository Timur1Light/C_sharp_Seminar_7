// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
// Пример:
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

void Main()
{
    int[] array = { 1, 2, 5, 0, 10, 34 };
    Print(array);
    System.Console.WriteLine();
}

void Print(int[] array)
{
    System.Console.Write("[" + string.Join(", ",array) + "] => " );
    PrintArrayRevers(array, array.Length - 1);
}


void PrintArrayRevers(int[] array, int i)
{
    if (i < 0) return;
    System.Console.Write(array[i] + " ");
    PrintArrayRevers(array, i - 1);
}


Main();