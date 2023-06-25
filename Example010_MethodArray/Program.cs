int [] array = { 1, 48, 3, 34, 5, 6, 27, 48 };

int n = array.Length;
int find = 48;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}



