//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите число А");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B");
int numberB = int.Parse(Console.ReadLine()!);
int NumberDegree(int numberA, int numberB)
{
    int result = 0;
    result = Convert.ToInt32(Math.Pow(numberA, numberB));
    return result;
}
Console.WriteLine(NumberDegree(numberA, numberB));