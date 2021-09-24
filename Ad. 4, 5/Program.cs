using System;

namespace Ad._4__5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ad. 4
            int a;
            string b;
            double c;
            a = 10;
            b= "Szkoła Dotneta";
            c= 12.5;
            Console.WriteLine("Ad. 4\n" + a + "\n" + b + "\n" + c);

            //Ad. 5

            Console.WriteLine("\n Ad. 5 \n Hello! \n Give your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Give your lastname:");
            string lastName = Console.ReadLine();
            Console.WriteLine("phone number:");
            int phone = int.Parse(Console.ReadLine());
            Console.WriteLine("email:");
            string email = Console.ReadLine();
            Console.WriteLine("Weight:");
            double weight = double.Parse(Console.ReadLine());


            Console.WriteLine("This is your date:" + "\n" + name + "\n" + lastName + "\n" + phone + "\n" + weight);
        }
    }
}
