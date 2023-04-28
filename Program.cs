// на вход принимает число (N)
// на выходе показывает все чётные числа от 1 до N

string N = Console.ReadLine();
int x = Convert.ToInt32(N);
int y = 2;

while (x > y)

{
    if(x % 2 == 0)
    Console.Write(y + " ");
    y +=2;
     
}
Console.WriteLine("Чётные числа: ");
