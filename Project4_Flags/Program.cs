// Работа с флагами
// Дано число. Проверить если в нем "0".
int i = 13450;
bool flag = false;
while (i != 0)
{
  int d = i % 10;
  if (d == 0)
  {
    flag = true;
  }
  i /= 10;
}

if (flag)  // запись аналогична flag=true;
{
  Console.WriteLine("В числе есть 0");
}
else
{
  Console.WriteLine("В числе нет 0");
}
