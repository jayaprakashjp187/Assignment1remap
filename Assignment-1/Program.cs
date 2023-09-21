using System.Transactions;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Please Choose any one program from below option");
            Console.WriteLine("1.Display_5_friend_name \n2.SquareOfNumbers");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch(choose)
            {
                case 1:
                    Console.WriteLine("friends names");
                    FriendsNames o = new FriendsNames();
                    
                    break;
                 case 2:
                    Console.WriteLine("unique elements are");
                    Console.WriteLine("enter first number");
                    double a= Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    double b= Convert.ToDouble(Console.ReadLine());

                    SquareOfNumbers c = new SquareOfNumbers(a,b);
                   
                    break;

            }
        }
    }
}
