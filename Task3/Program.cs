int[] array = [1, 2, 3, 4, 5, 6, 7, 8, 9];
int index = array.Length;
void Print(int[] array)
{
    if (index > 0)
    {
        index--;
        Console.Write(array[index]);
        Print(array);
    }
}
Print(array);