// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
		
int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void PrintArray(string[] array)
{
    int len = array.Length;
    Console.Write("[");
    for (int i = 0; i < len - 1; i++)  Console.Write($"{array[i]}, ");
    if (len > 0) Console.Write($"{array[len - 1]}");
    Console.Write($"] ");
}

string[] GetArray(string[] array)
{
    int len = array.Length;
    int count = 0;

    for (int i = 0; i < len; i++)
        if (array[i].Length <= 3)
            count++;

    string[] arrayReturn = new string[count];
    count = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayReturn[count] = array[i];
            count++;
        }
    }
    return arrayReturn;
}

int count = GetNum("Введите размер массива: ");
string[] arrayStart = new string[count];
for (int i = 0; i < count; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент массива");
    arrayStart[i] = Console.ReadLine();
}

string[] arrayFinal = GetArray(arrayStart);

PrintArray(arrayStart);
Console.Write(" -> ");
PrintArray(arrayFinal);