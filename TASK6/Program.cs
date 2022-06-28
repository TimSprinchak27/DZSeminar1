//Напишите программу, которая на вход принимает число и выдает является лм оно четным (делится на 2 без остатка).
namespace HelloWorld
{
    class Program 
    {
        static void Main(string[] args)

        {
            int number;
    
            Console.WriteLine("Введите целое число: ");
            number = Convert.ToInt32(Console.ReadLine());
            

            if (number % 2 ==0)
            {
                Console.WriteLine("Число {number} является четным и делится на 2 без остатка");
            }
            else
            {
                Console.WriteLine("Число {number} не является четным и не делится на 2 без остатка");
            }


        }
    }


}
