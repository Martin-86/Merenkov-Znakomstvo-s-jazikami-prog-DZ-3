// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("введите число из пяти цифр");
int a = Convert.ToInt32(Console.ReadLine());
string str = a.ToString();
int[] b = new int[str.Length];
for( int i=0; i< str.Length; i++)
{
    b[i] = int.Parse(str[i].ToString());
}


if (b.Length == 5)
    if(b[0] == b[4])
        {
            if(b[1] == b[3])
            Console.Write("Число "  + (str) + " палиндром.");         
        }
    else
        {
            Console.Write("Число "  + (str) + " не палиндром .");
        }
else
if (b.Length > 5)
{
    Console.Write("Ошибка! Вы ввели больше пяти цифр.");
}
if (b.Length < 5)
{
    Console.Write("Ошибка!Вы ввели меньше пяти цифр!");
}



// if (b.Length == 5)
// {
//     Console.Write("Третья цифра числа - ");
//     PrintArray(b);
//     Console.WriteLine();
// }