namespace CaloriesCalc
{
    public class User
    {
        public int Calories { get; private set; }
        public int Proteins { get; private set; }
        public int Fats { get; private set; }
        public int Carbs { get; private set; }
        public int SpentCalories { get; private set; }
        public int SpentProteins { get; private set; }
        public int SpentFats { get; private set; }
        public int SpentCarbs { get; private set; }

        public User(int calories, int proteins, int fats, int carbs)
        {
            Calories = calories;
            Proteins = proteins;
            Fats = fats;
            Carbs = carbs;
        }
        
        public User (User first, int spentCalories, int spentProteins, int spentFats, int spentCarbs)
            : this(first.Calories, first.Proteins,first.Fats,first.Carbs)
        {
            SpentCalories = spentCalories;
            SpentProteins = spentProteins;
            SpentFats = spentFats;
            SpentCarbs = spentCarbs;
            
        }

        public void ReduceBalance(int prodCalories, int prodProteins, int prodFats, int prodCarbs)
        {
            Calories -= prodCalories; 
            SpentCalories += prodCalories; 
            
            Proteins -= prodProteins; 
            SpentProteins += prodProteins;
            
            Fats -= prodFats; 
            SpentFats += prodFats;
            
            Carbs -= prodCarbs; 
            SpentCarbs += prodCarbs;
        }
    }
}