// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] collection)
{
    int length = a;
    int index = 0;                      
    while (index < a)           
    {
        collection[index] = index + 1;
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length; 
    int position = 0;
    int power = 3;
    while(position < count)
    {
        Console.Write((Math.Pow(col[position], power))+ " ");
        position++;
    }
}

int[] array = new int [a];

FillArray(array);
PrintArray(array);
Console.WriteLine();
