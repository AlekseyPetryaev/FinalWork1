// Итоговая работа:
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями,лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] -> [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] -> [“-2”]
// [“Russia”, “Denmark”, “Kazan”] -> []
// образецы : Hello 2 world :-), 
//            1234 1567 -2 computer science, 
//            Russia Denmark Kazan

Console.Clear();

string[] GetArray() 
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine()!.Split(" ");
}
string[] array = GetArray();
string[] result = PrintArray(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");


string[] PrintArray(string[] input, int n) 
{
    string[] output = new string[Count(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= n) 
        {
            output[j] = input[i];
            j++;
        }
    }
    return output;
}

int Count(string[] input, int n) 
{
    int count = 0;

    for(int i = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= n) 
        {
            count++;
        }
    }
    return count;
}
