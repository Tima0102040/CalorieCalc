using System;
using System.Drawing;
using System.Threading;

namespace CaloriesCalc
{
    class Program
    {
          
        static void Main(string[] args)
        {
            Console.WriteLine("{0,100}","Welcome to FatSecret calculator");
            Console.WriteLine("Enter your weight: ");
            int weight = Int32.Parse(Console.ReadLine());
            Console.Clear();
            
            Console.WriteLine("Enter your high: ");
            int high = Int32.Parse(Console.ReadLine());
            Console.Clear();
            
            Console.WriteLine("Enter your age: ");
            int age = Int32.Parse(Console.ReadLine());
            Console.Clear();
            
            Console.WriteLine("Enter your activity (low active - 1.12, active - 1.27, very active - 1.54: ");
            double activity = Double.Parse(Console.ReadLine());
            Console.Clear();
            
            Console.WriteLine("Enter your sex:  ");
            string sex = Console.ReadLine();
            Console.Clear();

            StartingPart user = new StartingPart(weight, high, age, activity, sex);
            
            user.CountingCalories();
            user.ChooseYourGoal();
            user.ProteinsFatsCarbos();
            Console.Clear();
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wait, your data is being processed...");
            Thread.Sleep(1000);
            Console.ResetColor();
            Console.Clear();
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Your daily nutrient intake: ");
            Console.WriteLine(new String('-', 25));
            Console.ResetColor();

            Console.WriteLine("{0,-22} | {1,-11}", "Calories", user.calories);
            Console.WriteLine("{0,-22} | {1,-11}", "Proteins", user.proteins);
            Console.WriteLine("{0,-22} | {1,-11}", "Fats", user.fats);
            Console.WriteLine("{0,-22} | {1,-11}", "Carbs", user.carbs);
            
        }
        
       
    }
}