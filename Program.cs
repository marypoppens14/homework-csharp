// на вход принимает число 
// выдаёт, является ли оно чётным

string a = Console.ReadLine();
int b = Convert.ToInt32(a);

if (b % 2 == 0)
{
    Console.WriteLine("да");
}

else Console.WriteLine("нет");
