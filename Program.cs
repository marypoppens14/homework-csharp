// на вход принимает три числа 
// выдаёт максимальное из этих чисел

string a = Console.ReadLine();
string b = Console.ReadLine();
string c = Console.ReadLine();

int d = Convert.ToInt32(a);
int e = Convert.ToInt32(b);
int f = Convert.ToInt32(c);

int max = d;

if (d > max) max = d;
if (e > max) max = e;
if (f > max) max = f;

Console.Write("max = ");
Console.WriteLine(max);
