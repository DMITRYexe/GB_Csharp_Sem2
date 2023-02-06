//22. По двум заданным числам проверять является ли одно квадратом другого.
Console.WriteLine("Привет! Данная программа проверяет не является ли одно число квадратом другого");
Console.WriteLine("Введите два числа:");
double a = Convert.ToDouble (Console.ReadLine()), b = Convert.ToDouble (Console.ReadLine());
if ( Math.Pow(a,2)==b || Math.Pow(b,2)==a) Console.WriteLine("Одно из чисел является квадратом другого"); // по заданию определить "какое какому" не требуется.
else Console.WriteLine("Ни одно из чисел не является квадратом другого");
