// Посчитать кол-во цифр в числе
int i = 1234, c = 0, sum =0;

while (i!=0)
{
  c++;
  int d=i%10;
  sum+=d;
  i/=10;
}
Console.WriteLine(c);
Console.WriteLine(sum);
