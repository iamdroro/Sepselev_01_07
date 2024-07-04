// See https://aka.ms/new-console-template for more information
using Sepselev_01_07;
using Sepselev_01_07.Vrednosty;

Console.WriteLine("Введите тип кабеля");
string type = Console.ReadLine();
Console.WriteLine("Введите количество жил кабеля");
int kolvo =int.Parse(Console.ReadLine());
Console.WriteLine("Введите диаметр кабеля");
double diametr = double.Parse(Console.ReadLine());
QalityObject qalityobjectq=new QalityObject(type,kolvo,diametr);
qalityobjectq.DisplayInfo();
Console.WriteLine();
Console.WriteLine("Введите тип кабеля");
string atype = Console.ReadLine();
Console.WriteLine("Введите количество жил кабеля");
int akolvo = int.Parse(Console.ReadLine());
Console.WriteLine("Введите диаметр кабеля");
double adiametr = double.Parse(Console.ReadLine());
Console.WriteLine("Введите наличие оплетки P");
string tf=Console.ReadLine();
Vrednosty vrednosty = new Vrednosty(atype, akolvo, adiametr,tf);
vrednosty.DisplayInfo();
Console.WriteLine();