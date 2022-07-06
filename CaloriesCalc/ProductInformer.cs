using System;

namespace CaloriesCalc
{
    public class ProductInformer
    {
        public void Buy(User second, Product product)
        {
            int calorie = product.ProductCalorie;
            int protein = product.ProductProtein;
            int fat = product.ProductFat;
            int carb = product.ProductCarb;
            
            second.ReduceBalance(calorie,protein,fat,carb);
            Console.WriteLine("Product {0} was added to your Recommended Daily Amount", product.ProductName);
        }
        
    }
}