//Напишите программу, которая на вход принимает два числа и выдает какое число больше а какое меньше.
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)

        {
            int A, B;
            Console.WriteLine ("Введите целое число A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine ("Введите  целое число B: ");
            B = Convert.ToInt32(Console.ReadLine());
            if ( A > B )
            {
                Console.WriteLine($"Число {A} является наибольшим числом, а число {B} наименьшим");
            }
            else
            {
                Console.WriteLine("Число {B} является наибольшим числом, а число {A} наименьшим");
            }
            

        }
    }
       
}