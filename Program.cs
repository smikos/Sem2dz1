int Prompt(string message)
{
    System.Console.Write( message );
    int value= Convert.ToInt32(Console.ReadLine());
    return value ;
}

int number = Prompt("Введите трехзначное число >");
if (number<100 || number >=1000)

{
    Console.WriteLine("Вы ввели не трехзначное число, пожалуйста повторите ввод");
    return;
}
Console.WriteLine($"Введенное число '{number}'");
int secondRank = number /10%10;
Console.WriteLine($"Вторая цифра '{secondRank}'");