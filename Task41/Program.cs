void InputArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write($"Введите число {i+1} ");
        col[i] = Convert.ToInt32(Console.ReadLine());
    }
    
}

int NumberMore0 (int[] col)
{
    int count=0;
    for (int i=0;i<col.Length; i++)
    {
        if (col[i]>0)
            count++;
    }
    return count;
}


Console.Clear();
Console.Write("Введите кол-во элементов ");
int m=Convert.ToInt32(Console.ReadLine());
int[] arr=new int[m];
InputArray(arr);
Console.WriteLine($"[{String.Join(",",arr)}]");
Console.WriteLine($"Чисел больше 0 {NumberMore0(arr)}");

