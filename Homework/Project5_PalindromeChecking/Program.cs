//26. Программа проверяет пятизначное число на палиндромом. Например: 12321
Console.WriteLine("Привет! Данная программа производит проверку пятизначного числа на палиндромность. Число вводится в коде");
int i=98989; // нет требования ввода с клавиатуры 
if (i/10000 == i%10 && (i/1000)%10 == (i/10)%10) Console.WriteLine($"{i} палиндромом");
else Console.WriteLine($"{i} НЕ палиндромом");