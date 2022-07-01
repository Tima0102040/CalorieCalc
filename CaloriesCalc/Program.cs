using System;

namespace CaloriesCalc
{
    class Program
    {
          
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight: ");
            int weight = Int32.Parse(Console.ReadLine());
            Console.Clear();
            
            Console.WriteLine("Enter your high: ");
            int high = Int32.Parse(Console.ReadLine());
            Console.Clear();
            
            Console.WriteLine("Enter your age: ");
            int age = Int32.Parse(Console.ReadLine());
            Console.Clear();
            
            Console.WriteLine("Enter your activity (low active-1.12, active-1.27, very active-1.54: ");
            double activity = Double.Parse(Console.ReadLine());
            Console.Clear();
            
            Console.WriteLine("Enter your 😄 sex:  ");
            string sex = Console.ReadLine();
            Console.Clear();

            StartingPart user = new StartingPart(weight, high, age, activity, sex);
            
            user.CountingCalories();
            user.ChooseYourGoal();
            
            Console.WriteLine(user.calorie);
        }
        
       
    }
}