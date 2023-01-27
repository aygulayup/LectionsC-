// Найти факториал числа, используя РЕкурсию.

double Factorial(int n)
{

    if(n == 1) return 1; // 1! = 1 0! = 1
    else return n * Factorial(n - 1);
}
Console.WriteLine(Factorial(20));