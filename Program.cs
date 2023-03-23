Console.Clear();
string [] array = new string[5] {"123", "hello", "res", "67", "world"};
string [] array2 = new string[array.Length];
NewArray(array, array2);
PrintArray(array2);
void NewArray(string [] array, string [] array2)
{
    int count = 0;
    for (int i = 0; i <array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
        array2[count] = array[i];
        count ++;
        }

    }
}

void PrintArray (string [] array)
{
    for (int i = 0; i <array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
   
}