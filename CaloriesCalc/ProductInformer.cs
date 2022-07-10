using System;

namespace CaloriesCalc
{
    public class ProductInformer
    {
        public void Buy(User second, Product product)
        {
            int calorie = product.CaloriePortion;
            int protein = product.ProteinPortion;
            int fat = product.FatPortion;
            int carb = product.CarbPortion;
            
            second.ReduceBalance(calorie,protein,fat,carb);
            Console.WriteLine(
                "Product {0} was added to your Recommended Daily Amount. Calories - {1}, Proteins - {2}, Fats - {3}, Carbs - {4}",
                product.ProductName, calorie, protein, fat, carb);
        }
        
    }
}