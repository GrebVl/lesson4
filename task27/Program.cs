/* программа принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int lengthNum(int num)
{
    int len = 0;
    while (num != 0)
    {
        num = num / 10;
        len++;
    }
    return len;
}

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
int length = lengthNum(number);

int[] arrey = new int[length];


for (int j = 0; j < length; j++)
{
    arrey[j] = number % 10;
    number = number / 10;
}

int sum = 0;

for (int i = 0; i < length; i++)
{
    sum = sum + arrey[i];
}
Console.WriteLine("Сумма= " + sum);
