Console.Clear();
Console.WriteLine("Введите радиус круга: ");
double R=Convert.ToDouble(Console.ReadLine());

int S=Convert.ToInt32(Math.Round(Math.PI*R*R/2));

char[] array=S.ToString().ToCharArray();

int max=0;
int index=0;

while (index<array.Length){

if((Convert.ToInt32(array[index]))>max){
    max=Convert.ToInt32(array[index]);
    index++;
} else{

    index++;
}
}
Console.WriteLine(max);
