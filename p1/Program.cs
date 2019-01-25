using System;

namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a=0;
            var b=0.0;
            var c=true;
            String brand;
            decimal cost;

            Console.WriteLine("Enter the name");
            var f= Console.ReadLine();
            while(f==""){
                f= Console.ReadLine();
            }
            Console.WriteLine($"Welcome {f}");
            Console.WriteLine("Enter the Bottle Size");
            var e=Console.ReadLine();
            Console.WriteLine($"{e} Gallons");
            Console.WriteLine("Enter the brand label need to buy ");
            brand =Console.ReadLine();
            

            switch(brand){
                case "Nestle": Console.WriteLine($"you selected the Nestle {e} gallon");
                break;
                case "Pure": Console.WriteLine($"You selected the pure {e} gallon");
                break;
                case "Aqua": Console.WriteLine($" you selected the Aqua {e} gallon");
                break;
                default: Console.WriteLine("Please select ");
                break;
            }

            

            
        }
    }
}
