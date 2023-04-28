// на вход принимает два числа 
// выдаёт, какое число большее, а какое меньшее

string a = Console.ReadLine();
string b = Console.ReadLine();
int c = Convert.ToInt32(a);
int d = Convert.ToInt32(b);

if(c > d)
{
    Console.WriteLine(c);
}
else Console.WriteLine(d);
