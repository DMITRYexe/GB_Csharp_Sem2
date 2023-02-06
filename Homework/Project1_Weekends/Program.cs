// 21. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Привет! Данная программа выполняет проверку является ли день недели выходным");
Console.WriteLine("Укажите день недели в виде числа:");
short d = Convert.ToInt16(Console.ReadLine());
if (d==6 || d==7)
Console.WriteLine("Это выходной");
else 
Console.WriteLine("Это не выходной");