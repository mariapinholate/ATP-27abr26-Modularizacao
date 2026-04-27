class Fibonacci
{
    public static void Compilar()
    {
        int n = 20; 
        int a = 0, b = 1, proximo;

        Console.WriteLine("Série de Fibonacci:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            proximo = a + b;
            a = b;
            b = proximo;
        }
    }
}

