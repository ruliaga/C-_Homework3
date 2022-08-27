Console.Clear();
Console.WriteLine("Введите X1");
int x1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y1");
int y1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z1");
int z1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите X2");
int x2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y2");
int y2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z2");
int z2=Convert.ToInt32(Console.ReadLine());

double L = Math.Round((Math.Sqrt(((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1)))),2);


Console.WriteLine($"Расстояние между двумя точками равно {L}");
