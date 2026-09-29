// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("введите число: ");
int number = int.Parse(Console.ReadLine());
if (number > 0)
{
    Console.WriteLine("Число положительное. ");
}
else if (number < 0)
{
    Console.WriteLine("число отрицательное. ");
}
else
{
    Console.WriteLine("число равное нулю");
}


Console.WriteLine("Введите балл(0-100): ");
int score = int.Parse(Console.ReadLine());

if (score >= 91)
{
    Console.WriteLine("Оценка отлично (5)");
}
else if (score >= 71)
{
    Console.WriteLine("Оценка хорошо (4)");
}
else if (score >= 51)
{
    Console.WriteLine("Оценка удвалетворительно (3)");
}
else if (score < 51)
{
    Console.WriteLine("Оценка неудвалетварительно (2)");
}

Console.WriteLine("ввидите кол-во посещений (из 19):");
int attendance = int.Parse(Console.ReadLine());
Console.WriteLine("введите средний бал по практике: ");
double practiceGpa = double.Parse(Console.ReadLine());
bool goodAttendance = attendance >= 14; // посещаемость >= 75%
bool goodGrades = practiceGpa >= 3.0; // оценка не ниже 3
if (goodAttendance && goodGrades)
{
    Console.WriteLine("+ допуск к экзамену разрешен. ");
}
else if (!goodAttendance && goodGrades)
{
    Console.WriteLine("- недостаточно посещений. Нужно отработать пропуски. ");
}
else if (goodAttendance && !goodGrades)
{
    Console.WriteLine("низкий бал по практике нужно пересдать работы. ");
}
else
{
    Console.WriteLine("проблемы и с посещаемостью и с оценками срочно к преподавателю.");
}