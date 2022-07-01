using System;

namespace CaloriesCalc
{
    public class StartingPart
    {
        private int weight, high, age, dietGoal;
        private double activity;
        private string sex;
        public double calorie;

        public StartingPart(int weight, int high, int age, double activity, string sex)
        {
            this.weight = weight;
            this.high = high;
            this.age = age;
            this.activity = activity;
            this.calorie = calorie;
            this.sex = sex;
        }

        public void CountingCalories()
        {
            while (true)
            {

                if (sex.ToLower() == "male")
                {
                    calorie = Convert.ToInt32(864 - 9.72 * age + activity * ((14.2 * weight) + 5.03 * high));
                    break;
                }
                else if (sex.ToLower() == "female")
                {
                    calorie = Convert.ToInt32(387 - 7.31 * age + activity * ((10.9 * weight) + 6.60 * high));
                    break;
                }
            }
            
        }

        public void ChooseYourGoal()
        {
            int key;
            Console.WriteLine("Choose your goal: ");
            Console.WriteLine("Cutting weight - 1");
            Console.WriteLine("Saving weight  - 2");
            Console.WriteLine("Bulking weight - 3");
            
            key = int.Parse(Console.ReadLine());
            Console.Clear();

            if (key == 1)
                calorie = Convert.ToInt32(calorie - (calorie * 0.15));
            else if (key == 2)
                calorie = calorie;
            else if (key == 3)
                calorie = Convert.ToInt32(calorie + (calorie * 0.15));
        }
        
    }
}