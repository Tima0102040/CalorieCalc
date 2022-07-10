namespace CaloriesCalc.PRoducts
{
    public class Meat: Product
    {
        public Meat(string productName, int productCalorie, int productProtein, int productFat, int productCarb)
        {
            ProductName = productName;
            ProductCalorie = productCalorie;
            ProductProtein = productProtein;
            ProductFat = productFat;
            ProductCarb = productCarb;
        }
    }
}