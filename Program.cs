using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_3
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //Ask user to input the price
            Console.Write("Enter the price: ");
            float price = float.Parse(Console.ReadLine());

            //Ak user to input the quantity
            Console.Write("Enter the quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            float total_cost = price * quantity;
            //print total cost if user enter positive #
            if (price > 0 && quantity > 0)
            {
                Console.WriteLine("Total cost: Php" + total_cost);
            } else
            {
                Console.WriteLine("Please enter positive number only");
             
            }
            
        }
    }
}

