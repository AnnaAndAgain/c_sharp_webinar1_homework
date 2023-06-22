/*Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число, желательно больше 1:");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 1)
{
    int i = 2;
    while (i <= N)
    {
        System.Console.Write(i + " ");
        i += 2;
    }
    System.Console.WriteLine("");
}
else System.Console.WriteLine($"Ваше число  ({N}) не больше единицы, я так не играю! Введите другое!");
