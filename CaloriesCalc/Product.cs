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
            Console.WriteLine(new String('-', 25));
            Console.WriteLine("Name: " + ProductName);
            Console.WriteLine("Price: " + ProductCalorie.ToString());
            Console.WriteLine("Company: " + ProductProtein.ToString());
            Console.WriteLine("Company: " + ProductFat.ToString());
            Console.WriteLine("Company: " + ProductCarb.ToString());

        }
        
        
    }
}