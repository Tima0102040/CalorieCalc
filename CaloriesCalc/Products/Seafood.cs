namespace CaloriesCalc.PRoducts
{
    public class Seafood: Product
    {
        public Seafood(string productName, int productCalorie, int productProtein, int productFat, int productCarb)
        {
            ProductName = productName;
            ProductCalorie = productCalorie;
            ProductProtein = productProtein;
            ProductFat = productFat;
            ProductCarb = productCarb;
        }
    }
}