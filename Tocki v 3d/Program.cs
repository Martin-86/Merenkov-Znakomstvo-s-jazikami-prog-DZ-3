Console.WriteLine("Введите координаты точки А");
Console.WriteLine("xA =");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("yA =");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("zA =");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.WriteLine("xB =");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("yB =");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("zB =");
int zB  = Convert.ToInt32(Console.ReadLine());

int sAB = (xA - xB)*(xA - xB)+(yA - yB)*(yA - yB)+(zA - zB)*(zA - zB);

double a = Math.Sqrt(sAB);

Console.WriteLine(a);
