//24. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("Привет! Данная программа определяет четверть оси координат по введеным Х и У");
Console.WriteLine("При этом, Х и У отличны от нуля");
Console.WriteLine("Введите координату Х, затем координату У");
double x = Convert.ToDouble(Console.ReadLine()), y =  Convert.ToDouble(Console.ReadLine());
bool x1 = true, y1 = true; // интересно реализовать это через bool (хотя можно и без)
if (x<0) x1 = false;
if (y<0) y1 = false;
if (x1 && y1) Console.WriteLine("Первая четверть");
if (x1==false && y1) Console.WriteLine("Вторая четверть");
if (x1==false && y1==false) Console.WriteLine("Третяя четверть");
if (x1 && y1==false) Console.WriteLine("Четвертая четверть");