
string[] array1 = new string[] { "Hello", "2", "world", ":-)" };
string[] array2 = new string[] { "1234", "1567", "-2", "computer science" };
string[] array3 = new string[] { "Russia", "Denmark", "Kazan" };

PrintArray(array1);
string[] newArray1 = FilterArray(array1);
Console.Write(" -> ");
PrintArray(newArray1);
Console.WriteLine();

PrintArray(array2);
string[] newArray2 = FilterArray(array2);
Console.Write(" -> ");
PrintArray(newArray2);
Console.WriteLine();

PrintArray(array3);
string[] newArray3 = FilterArray(array3);
Console.Write(" -> ");
PrintArray(newArray3);
Console.WriteLine();

string[] FilterArray(string[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }

    string[] newArray = new string[count];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[index] = array[i];
            index++;
        }
    }

    return newArray;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}