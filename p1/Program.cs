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
            decimal cost=0m;
            double bill;
            int quantity;

            Console.WriteLine("Enter the name");
            var f= Console.ReadLine();
            while(f==""){
                f= Console.ReadLine();
            }
            Console.WriteLine($"Welcome {f}");
            Console.WriteLine("Enter the Bottle Size");
            var e=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{e} Gallons");
            Console.WriteLine("Enter the brand label need to buy ");
            
            Console.WriteLine("Nestle - 1.5$/gallon");
             Console.WriteLine(" Pure - 2.5$/gallon");
             Console.WriteLine("Aqua - 3$/gallon");
             Console.WriteLine("please select the brand");
            brand =Console.ReadLine();
             Console.WriteLine($"How many {e} gallons you need");
             quantity=Convert.ToInt32(Console.ReadLine());
            switch(brand){
                case "Nestle": Console.WriteLine($"you selected the Nestle {e} gallon");
                                cost=1.5m*(e);
                                
                break;
                case "Pure": Console.WriteLine($"You selected the pure {e} gallon");
                                cost=2.5m*(e);
                break;
                case "Aqua": Console.WriteLine($" you selected the Aqua {e} gallon");
                                cost=3m*(e);
                break;
                default: Console.WriteLine("Please select ");
                break;
            }
            Console.WriteLine($"total cost is {cost}");
            if( cost< 10 )
            {
                Console.WriteLine("Thank for shopping");
            }
            else
            {
                Console.WriteLine("You have a free 1 gallon pure water bottle");
            }
           




            

            
        }
    }
}
