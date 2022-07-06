namespace CaloriesCalc.PRoducts
{
    public class Fruits: Product
    {
        public Fruits(string productName, int productCalorie, int productProtein, int productFat, int productCarb)
        {
            ProductName = productName;
            ProductCalorie = productCalorie;
            ProductFat = productFat;
            ProductCarb = productCarb;
        }
    }
}