//DZ2
/* ZADACHA1
int Prompt(string mesage)
{
System.Console.WriteLine($"{mesage}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите трехзначное число");
if (number >=100 && number <1000)
{
int mid = number /10 % 10;
System.Console.WriteLine($"Вторая цифра числа {number} является {mid}");
}
else
System.Console.WriteLine("Это число не трехзначное");
*/



/*
ZADACHA 2/ Я НЕ ПОНИМАЮ КАК ЭТО СДЕЛАТЬ, ПРОБОВАЛ МНОГО ВАРИАНТОВ, НО НЕ РАБОТАЕТ. ПОНИМАЮ ЧТО ТУТ МОЖНО ИСПОЛЬЗОВАТЬ 2 МЕТОДА INT И BOOL.И ИСПОЛЬЗОВАТЬ "/" И "%"
Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}


/*
//ZADACHA 3
Console.WriteLine("Введите цифру дня недели");
int num = Convert.ToInt32(Console.ReadLine());
if (num ==7 || num == 6 )
{
  Console.WriteLine("Да - Выходной");
}
if(num<=5)
{
  Console.WriteLine("Нет - Рабочий день");
  
}
else
{
  return;
}
*/
