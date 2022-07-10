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
        //----------------------------------
        public int CaloriePortion { get; set; }
        public int ProteinPortion { get; set; }
        public int FatPortion { get; set; }
        public int CarbPortion { get; set; }
        public virtual void ToConsole()
        {
            Console.WriteLine("Product {0}", ProductName);
            Console.WriteLine("Calories        Proteins        Fats        Carbs");
            Console.WriteLine($"{ProductCalorie.ToString()}" + $"{ProductProtein.ToString(),18}" +
                              $"{ProductFat.ToString(),13}" + $"{ProductCarb.ToString(),13}");
            Console.WriteLine(new String('-', 49));
        }
        public void Portion(int productWeight)
        {
             CaloriePortion = Convert.ToInt32(productWeight * ProductCalorie) / 100;
             ProteinPortion = Convert.ToInt32(productWeight * ProductProtein) / 100; 
             FatPortion = Convert.ToInt32(productWeight * ProductFat) / 100;
             CarbPortion = Convert.ToInt32(productWeight * ProductCarb) / 100;
        }
    }
}