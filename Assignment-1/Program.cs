using System.Diagnostics;
using System.Transactions;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Please Choose any one program from below option");
            Console.WriteLine("1.Display_5_friend_name \n2.squareofnumbers \n3. placename \n4.Area and perimeter of circle\n5.stopwatch");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch(choose)
            {
                case 1:
                    Console.WriteLine("friends names");
                    FriendsNames o = new FriendsNames();
                    
                    break;
                 case 2:
                    Console.WriteLine("square numbers ");
                    Console.WriteLine("enter first number");
                    double a= Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    double b= Convert.ToDouble(Console.ReadLine());

                    SquareOfNumbers c = new SquareOfNumbers(a,b);
                   
                    break;
                    case 3:
                    
                    PlaceName h = new PlaceName();

                  
                    Console.Write("Enter a what placename  you want to visit");

                   
                    string inputPlace = Console.ReadLine();

                    
                    h.PlaceNameInCasing(inputPlace);
                    break;
                case 4:
                    Console.Write("Enter the diameter of the circle: ");
                    double diameter = Convert.ToDouble(Console.ReadLine());

                    AreaAndPerimeter ap = new AreaAndPerimeter(diameter);
                    

                    break;
                case 5:
                
                    Console.WriteLine("welcome to the Stopwatch Program");
                    StopWatch.CheckingStopWatch();
                    break;

                    
                

                     


            }
        }
    }
}