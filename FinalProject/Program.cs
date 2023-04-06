void Main()
{
    string[] arr = { "Hello", "2", "world", ":-)", "Hi", "351" };
    Console.WriteLine(String.Join(" ", searchElemensOfArray(arr, 3)));
}

string[] searchElemensOfArray(string[] array, int n)
{
    int newArrayLenght = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n) { newArrayLenght++; }
    }
    string[] newArray = new string[newArrayLenght];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {
            newArray[j++] = array[i];
        }
    }
    return newArray;
}
Main();
