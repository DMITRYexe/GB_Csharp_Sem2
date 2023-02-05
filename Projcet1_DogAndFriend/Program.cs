/* Задача про двух друзей и собаку:
Два друга идут на встречу друг другу. Расстояние между ними 10000м.
Скорость первого - 1м/с, второго 2м/с.
От первого друга ко второму бежит собака. Её скорость 5м/с.
Когда она добегает до второго друга, она начинает бежать к первому.
Так она повторяет пока друзья не встретяться (дистанция 10 м или меньше).
Сколько раз собака пробежит от одного друга к другому?
*/
Console.WriteLine("Привет! Эта программа решает задачу про двух друзей и собаку.");
Console.WriteLine("Условие и переменные записаны в коде. Программа выдаст только ответ");
int  firstFriendSpeed = 1, secondFriendSpeed = 2, dogSpeed = 5, count = 0, currentFriend = 2;
double time, distnace = 10000;
while (distnace > 10)
{
  if (currentFriend == 1)
  {
    time = distnace / (firstFriendSpeed + dogSpeed);
    currentFriend = 2;
  }
  else
  {
    time = distnace / (secondFriendSpeed + dogSpeed);
    currentFriend = 3;
  }
  distnace = distnace - (firstFriendSpeed + secondFriendSpeed) * time;
  count = count + 1;
}
Console.WriteLine(count);