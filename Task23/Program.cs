Console.Clear();
Console.WriteLine("Введите N");
int N=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("----------------------");

Console.Write($"{N} -> ");

double position=1.0;

while (position<=N){
    
    Console.Write($"{Math.Pow(position,3.0)} ");
    position++;
}

