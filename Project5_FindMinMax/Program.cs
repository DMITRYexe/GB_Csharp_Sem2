// Ищуем минимальную и максимальную цифры в числе

int i = 1354, max = -1, min = 10, digit; // в мин и макс указываем числа выше и ниже диапазаона соответсвенно
while (i != 0)
{
  digit = i % 10;
  if (digit > max) max = digit;
  if (digit < min) min = digit;
  i /= 10;
}
Console.WriteLine($"Max={max}, min={min}");

