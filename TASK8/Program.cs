//Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные от 1 до N.
namespace HelloWorld
{
    class Program 
    {
        static void Main(string[] args)

        {    
            
        int m = 1;
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = m; i <= n; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }
        Console.ReadKey();
            
        }
    }


}

