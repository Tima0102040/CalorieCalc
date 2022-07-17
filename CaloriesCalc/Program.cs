using System;
using System.Collections.Generic;
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
            Console.WriteLine("Press any button to processed");
            Console.ReadKey();
            Console.Clear();

            User first = new User(user.calories, user.proteins, user.fats, user.carbs);

            User second = new User(first,0,0,0,0);

            var constNutrients = new Dictionary<string, int>()
            {
                {"Calorie", second.Calories},
                {"Protein", second.Proteins},
                {"Fat", second.Fats},
                {"Carb", second.Carbs}
            };

            Diary milk = new Diary("Milk", 43, 4, 1, 0, 1);
            Meat chickenBreast = new Meat("Chicken Breast", 195, 30, 8, 0);
            Fruits banana = new Fruits("Banana", 89, 1, 0, 23);
            Seafood shrimps = new Seafood("Shrimps", 144, 28, 3, 1);
            Vegetables potato = new Vegetables("Potato", 104, 2, 2, 20);
            Meat chicken = new Meat("ch", 10, 0, 0, 0);

            Product[] products = new Product[]
            {
                milk,
                chickenBreast,
                banana,
                shrimps,
                potato,
                chicken
            };

            ProductInformer productInformer = new ProductInformer();

            DateTime startDate = DateTime.Today;
            DateTime stopDate = startDate.AddDays(7);
            int interval = 1;

            DateTime dateTime = startDate;

            while (dateTime < stopDate)
            {
                Console.WriteLine("{0,100}", "Product diary");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Calories - {0}, Proteins - {1}, Fats - {2}, Carbs - {3}", 
                    second.Calories, second.Proteins, second.Fats, second.Carbs);
                Console.ResetColor();
                Console.WriteLine();

                foreach (Product product in products)
                { 
                    product.ToConsole();
                }
                
                string str = Console.ReadLine();
                Console.WriteLine("Enter product or Exit to end day: ");
                
                if (str != "Exit")
                {
                    int productNumb = Convert.ToInt32(str);
                
                    Console.WriteLine("Choose product weight: ");
                    string rts = Console.ReadLine();
                    int productWeight = Convert.ToInt32(rts);
                    products[productNumb].Portion(productWeight);
                    Console.Clear();
                    
                    if (productNumb >= 0 && productNumb < products.Length)
                    { 
                        if (products[productNumb].CaloriePortion < second.Calories 
                            && products[productNumb].ProteinPortion < second.Proteins
                            && products[productNumb].FatPortion < second.Fats
                            && products[productNumb].CarbPortion < second.Carbs)
                        { 
                            productInformer.Buy(second, products[productNumb]);
                        }
                        else 
                            Console.WriteLine("An excess of one of the nutrients");
                    } 
                }
                else
                {
                    Console.Clear();
                    dateTime += TimeSpan.FromDays(interval);
                    Console.WriteLine();
                    Console.WriteLine("Welcome to new day " + dateTime.ToLongDateString());
                    second.Calories = constNutrients["Calorie"];
                    second.Proteins = constNutrients["Protein"];
                    second.Fats = constNutrients["Fat"];
                    second.Carbs = constNutrients["Carb"];
                }
            }
        }
    }
}
