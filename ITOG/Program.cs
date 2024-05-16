string[] firstArray = new string[6] { "cat", "sheep", "dog", "fish", "pig", "chicken" };
string[] secondArray = new string[firstArray.Length];
int i = 0;
int j = 0;
void SecondArrayNew(string[] array1, string[] array2)
{
    for (i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[j] = array1[i];
            j++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

SecondArrayNew(firstArray, secondArray);
PrintArray(secondArray);