/*
Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число");
string number = Console.ReadLine();
int i = 0;


while (int.TryParse(number, out i) == false){
    Console.WriteLine("Ошибка. Вы ввели текст, необходимо число. Попробуйте еще раз");
    number = Console.ReadLine();   
}
while (number.Length != 3){
    Console.WriteLine("Ошибка. Необходимо трехзначное число, попробуйте еще раз");
    number = Console.ReadLine();   
}

int res = (i / 10) % 10;

Console.WriteLine("Вторая цифра числа " + res);






