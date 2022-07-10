namespace CaloriesCalc.PRoducts
{
    public class Vegetables: Product
    {
        public Vegetables(string productName, int productCalorie, int productProtein, int productFat, int productCarb)
        {
            ProductName = productName;
            ProductCalorie = productCalorie;
            ProductProtein = productProtein;
            ProductFat = productFat;
            ProductCarb = productCarb;
        }
    }
}