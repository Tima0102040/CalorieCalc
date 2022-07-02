using System;

namespace CaloriesCalc
{
    public class StartingPart
    {
        private int weight, high, age, dietGoal;
        private double activity;
        private string sex;
        public double calories, proteins, fats, carbs;

        public StartingPart(int weight, int high, int age, double activity, string sex)
        {
            this.weight = weight;
            this.high = high;
            this.age = age;
            this.activity = activity;
            this.calories = calories;
            this.sex = sex;
        }

        public void CountingCalories()
        {
            while (true)
            {
                if (sex.ToLower() == "male")
                {
                    calories = Convert.ToInt32(864 - 9.72 * age + activity * ((14.2 * weight) + 5.03 * high));
                    break;
                }
                else if (sex.ToLower() == "female")
                {
                    calories = Convert.ToInt32(387 - 7.31 * age + activity * ((10.9 * weight) + 6.60 * high));
                    break;
                }
            }
        }

        public void ChooseYourGoal()
        {
            Console.WriteLine("Choose your goal: ");
            Console.WriteLine("Cutting weight - 1");
            Console.WriteLine("Saving weight  - 2");
            Console.WriteLine("Bulking weight - 3");

            dietGoal = int.Parse(Console.ReadLine());
            Console.Clear();

            while (true)
            {
                if (dietGoal == 1)
                {
                    calories = Convert.ToInt32(calories - (calories * 0.15));
                    break;
                }
                else if (dietGoal == 2)
                {
                    calories = calories;
                    break;
                }
                else if (dietGoal == 3)
                {
                    calories = Convert.ToInt32(calories + (calories * 0.15));
                    break;
                }
            }
        }

        public void ProteinsFatsCarbos()
        {
            if (dietGoal == 1)
            {
                proteins = Convert.ToInt32((0.3 * calories) / 4);
                fats = Convert.ToInt32((0.2 * calories) / 9);
                carbs = Convert.ToInt32((0.5 * calories) / 4);
            }
            else if (dietGoal == 2)
            {
                proteins = Convert.ToInt32((0.3 * calories) / 4);
                fats = Convert.ToInt32((0.3 * calories) / 9);
                carbs = Convert.ToInt32((0.4 * calories) / 4);
            }
            else if (dietGoal == 3)
            {
                proteins = Convert.ToInt32((0.3 * calories) / 4);
                fats = Convert.ToInt32((0.2 * calories) / 9);
                carbs = Convert.ToInt32((0.5 * calories) / 4);
            }
        }
        
    }
}