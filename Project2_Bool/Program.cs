// Изучение алгоритма "bool".
Console.WriteLine("Данная программа создана в качестве тренировки работы с логическим оператором bool");
// По месяцу определяем время года
int mount = 1;
if (mount == 1 || mount == 2 || mount == 12) Console.WriteLine("Winter");
if (mount == 3 || mount == 4 || mount == 5) Console.WriteLine("Spring");
if (mount == 6 || mount == 7 || mount == 8) Console.WriteLine("Summer");
if (mount == 9 || mount == 10 || mount == 11) Console.WriteLine("Autumn");
// По возрасту человека проверить подходит ли он для работы. Нужны люди от 25 до 45.
int age=11;
if (age>=25 && age<=45)
{
  Console.WriteLine("Подходит");
}
else
{
  Console.WriteLine("Не подходит");
}