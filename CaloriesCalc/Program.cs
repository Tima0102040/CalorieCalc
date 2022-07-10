using System;
using System.Drawing;
using System.Threading;
using CaloriesCalc.PRoducts;

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
            user.CountingNutrients();
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
            Console.WriteLine();
            
            User first = new User(user.calories, user.proteins, user.fats, user.carbs);

            User second = new User(first,0,0,0,0);
            
            Console.WriteLine("SecondCalories:" + second.Calories);

            Diary milk = new Diary("Milk", 43, 4, 1, 0, 1);
            Meat chickenBreast = new Meat("Chicken Breast", 195, 30, 8, 0);
            Fruits banana = new Fruits("Banana", 89, 1, 0, 23);
            Seafood shrimps = new Seafood("Shrimps", 144, 28, 3, 1);
            Vegetables potato = new Vegetables("Potato", 104, 2, 2, 20);

            Product[] products = new Product[]
            {
                milk,
                chickenBreast,
                banana,
                shrimps,
                potato
            };

            foreach (Product product in products )
            {
                product.ToConsole();
            }
            
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to your product diary");
                Console.WriteLine();

                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"Product {i} {products[i].ProductName}.");
                    Console.WriteLine("Calories        Proteins        Fats        Carbs");
                    Console.WriteLine(products[i].ProductCalorie
                                      +"        "+products[i].ProductProtein
                                      +"        "+products[i].ProductFat
                                      +"        "+products[i].ProductCarb);
                    Console.WriteLine(new String('-', 25));
                }
                
                Console.WriteLine("Choose product: ");
                string str = Console.ReadLine();
                int productNumb = Convert.ToInt32(str);
                
                Console.WriteLine("Choose product weight: ");
                string rts = Console.ReadLine();
                int productWeight = Convert.ToInt32(rts);
                
                products[productNumb].Portion(productWeight);
            }
        }
    }
}