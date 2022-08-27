Console.Clear();
Console.WriteLine("Введите пятизначное число:");
int number=Convert.ToInt32(Console.ReadLine());

int check=number.ToString().Length;

if (check==5) {

char [] num = number.ToString().ToCharArray();

if(num[0]==num[4] && num[1]==num[3]){
    Console.WriteLine("это число палиндром");
} else {
    Console.WriteLine("это число НЕ палиндром");
}

    
} else {

Console.WriteLine("Вы ввели некорректное число.");

}
