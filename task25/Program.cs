/*  Цикл принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

Console.WriteLine("Введите число A:");
int firstNum = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B:");
int secondNum = int.Parse(Console.ReadLine());

int result = 1;

for (int index = 0; index < secondNum; index++)
    result = result * firstNum;


Console.WriteLine(firstNum + "^" + secondNum + "= " + result);

