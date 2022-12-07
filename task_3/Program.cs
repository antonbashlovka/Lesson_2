/*
Задача 3: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/

Console.WriteLine("Введите число");
string number = Console.ReadLine();
int intNumber = 0;

while (int.TryParse(number, out intNumber) == false){
    Console.WriteLine("Ошибка. Вы ввели текст, необходимо число. Попробуйте еще раз");
    number = Console.ReadLine();   
}

if (intNumber % 7 == 0 && intNumber % 23 == 0){
    Console.WriteLine("да");
}else{
    Console.WriteLine("нет");
}
