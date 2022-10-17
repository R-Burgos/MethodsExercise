namespace MethodsExercise
{
    internal class Program
    {
        public static string Greetings()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            return name;
        }

        public static string FavoriteColor()
        {
            Console.WriteLine("What is your favorite color?");
            string favoriteColor = Console.ReadLine();
            return favoriteColor;
        }

        public static string FavoriteAnimal()
        {
            Console.WriteLine("What is your favorite anmial?");
            string favoriteAnimal = Console.ReadLine();
            return favoriteAnimal;
        }

        public static string FavoriteBand()
        {
            Console.WriteLine("What is your favorite band?");
            string favoriteBand = Console.ReadLine();
            return favoriteBand;
        }

        public static string TypeOfBuilding()
        {
            Console.WriteLine("Name a type of building (House/tower/shack ect..)");
            string typeOfBuilding = Console.ReadLine();
            return typeOfBuilding;
        }

        public static string BuildingMaterials()
        { 
            Console.Wr
        
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome text");  // ADD AN INTRO HERE <----------------------------------

            var name = Greetings();
            var favoriteColor = FavoriteColor();
            var favoriteAnimal = FavoriteAnimal();
            var favoriteBand = FavoriteBand();

            Console.WriteLine($"");

        }
    }
}