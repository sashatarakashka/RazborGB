Console.WriteLine("Введите число : ");
string text = Console.ReadLine();
int x = Convert.ToInt32(text);
switch(x)
{
    case 1 :
    Console.WriteLine("Понедельник");
    break;
    case 2 :
    Console.WriteLine("Вторник");
    break;
    case 3 :
    Console.WriteLine("Среда");
    break;
    case 4 :
    Console.WriteLine("Четверг");
    break;
    case 5 :
    Console.WriteLine("Пятница");
    break;
    case 6 :
    Console.WriteLine("Суббота");
    break;
    case 7 :
    Console.WriteLine("Воскресенье");
    break;
    default :
    Console.WriteLine("Нет такого дня недели, введите число от 1 до 7");
    break;
}
Console.WriteLine("The End");