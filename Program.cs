string[] CreateArray (int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i+1}-й элемент: ");
        string element = Convert.ToString(Console.ReadLine());
        array[i] = element;
    }
    return array;
}

string[] CreateNewArray (string[] array, int size)
{
    string[] newArray = new string[size];
    int len = 3;
    int count = 0;
    for (int j = 0; j < size; j++)
    {
        if (array[j].Length <= len)
        {
            newArray[count] = array[j];
            count++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
     Console.Write(array[i] + " ");
     }
    Console.WriteLine();
}

Console.Write("Input a number of elements ");
int size = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateArray(size);
Console.Write("Start array: ");
PrintArray(myArray);
Console.WriteLine();
Console.Write("New array: ");
string[] newArray = CreateNewArray(myArray, size);
PrintArray(newArray);