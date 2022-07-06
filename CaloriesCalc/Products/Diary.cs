namespace CaloriesCalc.PRoducts
{
    public class Diary : Product
    {
        public double DiaryFat { get; set; }
            
        public Diary(string productName, int productCalorie, int productProtein, int productFat, int productCarb, double diaryFat)
        {
            ProductName = productName;
            ProductCalorie = productCalorie;
            ProductProtein = productProtein;
            ProductFat = productFat;
            ProductCarb = productCarb;
            DiaryFat = diaryFat;
        }
    }
    
}