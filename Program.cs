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


