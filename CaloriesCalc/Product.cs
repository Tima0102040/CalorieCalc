using System;

namespace CaloriesCalc
{
    public class Product
    {
        public string ProductName { get; set; }
        public int ProductCalorie { get; set; }
        public int ProductProtein { get; set; }
        public int ProductFat { get; set; }
        public int ProductCarb { get; set; }
        public virtual void ToConsole()
        {
            Console.WriteLine(new String('-', 20));
            Console.WriteLine("Name: " + ProductName);
            Console.WriteLine("Calorie: " + ProductCalorie.ToString());
            Console.WriteLine("Protein: " + ProductProtein.ToString());
            Console.WriteLine("Fat: " + ProductFat.ToString());
            Console.WriteLine("Carb: " + ProductCarb.ToString());
            Console.WriteLine("Nutritional value per 100gr");
        }

        public void Portion(int productWeight)
        {
            int caloriePortion = Convert.ToInt32(productWeight * ProductCalorie) / 100;
            int proteinPortion = Convert.ToInt32(productWeight * ProductProtein) / 100;
            int fatPortion = Convert.ToInt32(productWeight * ProductFat) / 100;
            int carbPortion = Convert.ToInt32(productWeight * ProductCarb) / 100;
        }
    }
}