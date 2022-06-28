//Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел.
namespace HelloWorld
{
    class Program1
    {
        static void Main (string[] args )

        {

            Console.WriteLine("Введите целое число A: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите  целое число B: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите  целое число С: ");
            int number3 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2)
            {
                if (number1 > number3)
                {
                    Console.WriteLine($"Число {number1} является наибольшим числом");

                }
                else
                {
                    Console.WriteLine($"Число {number3} является наибольшим числом");
                }


            }
            else
            {
                if (number1 > number3)
                {
                    Console.WriteLine($"Число {number1} является наибольшим числом");
                }
                else
                {
                    Console.WriteLine($"Число {number3} является наибольшим числом");

                }





            }
        }
    }
}

