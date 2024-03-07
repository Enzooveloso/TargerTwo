using System;
class Target
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira um numero e descubra se ele faz parte ou nao da sequencia de Fibonacci");
        int n = int.Parse(Console.ReadLine());

        if (fibonacci(n))
        {
            Console.WriteLine("O numero informado pertence a sequencia");
        }
        else { Console.WriteLine("O numero informado nao pertence a sequencia"); }
    }
    static bool fibonacci(int n)
{
    //Os dois primeiros numero da sequencia de fibonacci
    int a = 0;
    int b = 1;

    int fib = b;
    while (fib < n)
    {
        fib = a + b;
        a = b;
        b = fib;
    }
    return fib == n;
}
}