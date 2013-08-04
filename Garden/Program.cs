using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        double tomBr = double.Parse(Console.ReadLine());
        double tomArea = double.Parse(Console.ReadLine());
        double cucBr = double.Parse(Console.ReadLine());
        double cucArea = double.Parse(Console.ReadLine());
        double potBr = double.Parse(Console.ReadLine());
        double potArea = double.Parse(Console.ReadLine());
        double carBr = double.Parse(Console.ReadLine());
        double carArea = double.Parse(Console.ReadLine());
        double cabBr = double.Parse(Console.ReadLine());
        double cabArea = double.Parse(Console.ReadLine());
        double beanBr = double.Parse(Console.ReadLine());
        //double beanArea = 0;

        // ptice
        double tomPrice = 0.5;
        double cucPrice = 0.4;
        double potPrice = 0.25;
        double carPrice = 0.6;
        double cabPrice = 0.3;
        double beanPrice = 0.4;

        double totalCost = 0;
        double allArea = 250;
        double leftArea = 0;

        totalCost = (tomBr * tomPrice) + (cucBr * cucPrice) + (potBr * potPrice) 
            + (carBr * carPrice) + (cabBr * cabPrice) + (beanBr * beanPrice);

        leftArea = allArea - (tomArea+cucArea+potArea+carArea+cabArea);
        Console.WriteLine("Total costs: {0:0.00}", totalCost);
        if (leftArea==0)
        {
            Console.WriteLine("No area for beans");
        }
        else if (leftArea<0)
        {
            Console.WriteLine("Insufficient area");
        }
        else
        {
            Console.WriteLine("Beans area: {0}", leftArea);
        }        
    }
}

