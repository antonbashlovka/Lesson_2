/*
Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число");
string number = Console.ReadLine();
int intNumber = 0;


while (int.TryParse(number, out intNumber) == false){
    Console.WriteLine("Ошибка. Вы ввели текст, необходимо число. Попробуйте еще раз");
    number = Console.ReadLine();   
}
while (number.Length < 3){
    Console.WriteLine("Третьей цифры нет, введите другое число");
    number = Console.ReadLine();   
}

int length = number.Length;

double res = Math.Floor(intNumber / Math.Pow(10, length-3)) % 10;


Console.WriteLine("Третья цифра числа " + res);