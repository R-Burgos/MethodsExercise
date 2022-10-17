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

        public static string BuildingMat1()
        {
            Console.WriteLine("Name a building material:");
            string buildingMat1 = Console.ReadLine();
            return buildingMat1;
        }
        public static string BuildingMat2()
        {
            Console.WriteLine("Name another building material:");
            string buildingMat2 = Console.ReadLine();
            return buildingMat2;
        }
        public static string BuildingMat3()
        {
            Console.WriteLine("Name a final building material:");
            string buildingMat3 = Console.ReadLine();
            return buildingMat3;
        }
        public static string HatedAnimal()
        {
            Console.WriteLine("What is your least favorite anmial?");
            string hatedAnimal = Console.ReadLine();
            return hatedAnimal;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!\nPlease answer the following questions to enjoy a personalized mad lib version of The Three Little Pigs story.\n");  


            var name = Greetings();
            var favoriteColor = FavoriteColor();
            var favoriteAnimal = FavoriteAnimal();
            var favoriteBand = FavoriteBand();
            var typeBuilding = TypeOfBuilding();
            var buildMat1 = BuildingMat1();
            var buildMat2 = BuildingMat2();
            var buildMat3 = BuildingMat3();
            var hatedAnimal = HatedAnimal();

            Console.WriteLine($"{name}, thank you for answering all those questions! Your personalized story will now begin.\n");

            Console.WriteLine($"Once upon a time there was an old mother {favoriteAnimal} who had three little {favoriteAnimal}s and not enough food to feed them.\nSo when they were old enough, she sent them out into the world to seek their fortunes.");
            Console.WriteLine($"The first little {favoriteAnimal} was very lazy. He didn't want to work at all and he built his {typeBuilding} out of {buildMat1}.\nThe second little {favoriteAnimal} worked a little bit harder but he was somewhat lazy too and he built his {typeBuilding} out of {buildMat2}.\nThen, they sang and danced to {favoriteBand} together the rest of the day.");
            Console.WriteLine($"The third little {favoriteAnimal} worked hard all day and built his {typeBuilding} with {buildMat3}.\nIt was a sturdy {typeBuilding} complete with a fine fireplace and chimney. It looked like it could withstand the strongest winds.\n");
            
            Console.WriteLine($"The next day, a {favoriteColor} {hatedAnimal} happened to pass by the lane where the three little {favoriteAnimal} lived.\nHe saw the {buildMat1} {typeBuilding}, and he smelled the {favoriteAnimal} inside. He thought the {favoriteAnimal} would make a mighty fine meal and his mouth began to water.");
            Console.WriteLine($"So he knocked on the door and said:\n'Little {favoriteAnimal}! Little {favoriteAnimal}! Let me in! Let me in!'");
            Console.WriteLine($"But the little {favoriteAnimal} saw the {favoriteColor} {hatedAnimal}'s big paws through the keyhole, so he answered back:");
            Console.WriteLine($"'No! No! No! Not by the hairs on my chinny chin chin!'");
            Console.WriteLine($"Then the {favoriteColor} {hatedAnimal} showed his teeth and said:");
            Console.WriteLine($"'Then I'll huff and I'll puff and I'll blow your {typeBuilding} down!'");
            Console.WriteLine($"So he huffed and he puffed and he blew the {typeBuilding} down! The {favoriteColor} {hatedAnimal} opened his jaws very wide and\nbit down as hard as he could, but the first little {favoriteAnimal} escaped and ran away to hide with the second little {favoriteAnimal}.\n");

            Console.WriteLine($"The {favoriteColor} {hatedAnimal} continued down the lane and he passed by the second {typeBuilding} made of {buildMat2};\nand he saw the {typeBuilding}, and he smelled the {favoriteAnimal}s inside, and his mouth began to water as he thought about the fine dinner they would make.\n");
            Console.WriteLine($"So the {favoriteColor} {hatedAnimal} knocked on the door and said:\n'Little {favoriteAnimal}s! Little {favoriteAnimal}s! Let me in! Let me in!'");
            Console.WriteLine($"But the little {favoriteAnimal}s saw the {favoriteColor} {hatedAnimal}'s pointy ears through the keyhole, so they answered back:");
            Console.WriteLine($"'No! No! No! Not by the hairs on our chinny chin chin!'");
            Console.WriteLine($"So the {favoriteColor} {hatedAnimal} showed his teeth and said:");
            Console.WriteLine($"'Then I'll huff and I'll puff and I'll blow your {typeBuilding} down!'");
            Console.WriteLine($"So he huffed and he puffed and he blew the {typeBuilding} down! The {favoriteColor} {hatedAnimal} was greedy and he tried to catch\nboth {favoriteAnimal}s at once, but he was too greedy and got neither! His big jaws clamped down on nothing but air\nand the two little {favoriteAnimal}s scrambled away as fast as their little hooves would carry them.\n");

            Console.WriteLine($"The {favoriteColor} {hatedAnimal} chased them down the lane and he almost caught them. But they made it to the {buildMat3} {typeBuilding} and\nslammed the door closed before the {favoriteColor} {hatedAnimal} could catch them. The three little {favoriteAnimal}s were very frightened,\nthey knew the {favoriteColor} {hatedAnimal} wanted to eat them. And that was very, very true. The {favoriteColor} {hatedAnimal} hadn't eaten all day and \nhe had worked up a large appetite chasing the {favoriteAnimal}s around and now he could smell all\nthree of them inside and he knew that the three little {favoriteAnimal}s would make a lovely feast.\n");

            Console.WriteLine($"So the {favoriteColor} {hatedAnimal} knocked on the door and said:\n'Little {favoriteAnimal}s! Little {favoriteAnimal}s! Let me in! Let me in!'");
            Console.WriteLine($"But the little {favoriteAnimal}s saw the {favoriteColor} {hatedAnimal}'s narrow eyes through the keyhole, so they answered back:");
            Console.WriteLine($"'No! No! No! Not by the hairs on our chinny chin chin!'");
            Console.WriteLine($"So the {favoriteColor} {hatedAnimal} showed his teeth and said:");
            Console.WriteLine($"'Then I'll huff and I'll puff and I'll blow your {typeBuilding} down!'\n");

            Console.WriteLine($"Well, he huffed and he puffed. He puffed and he huffed. And he huffed, huffed, and he puffed, puffed;\nbut he could not blow the {typeBuilding} down. At last, he was so out of breath that he couldn't huff and he couldn't puff anymore. So he stopped to rest and thought a bit.");
            Console.WriteLine($"But this was too much. The {favoriteColor} {hatedAnimal} danced about with rage and swore he would come down\nthe chimney and eat up the little {favoriteAnimal} for his supper. But while he was climbing on to the roof the little {favoriteAnimal} made up a blazing\nfire and put on a big pot full of water to boil. Then, just as the {favoriteColor} {hatedAnimal} was coming down the chimney,\nthe little {favoriteAnimal} pulled off the lid, and plop! in fell the {favoriteColor} {hatedAnimal} into the scalding water.");
            Console.WriteLine($"So the little {favoriteAnimal} put on the cover again, boiled the {favoriteColor} {hatedAnimal} up, and the\nthree little {favoriteAnimal}s ate him for supper while listening to {favoriteBand} in the {buildMat3} {typeBuilding}.\n");

            Console.WriteLine("THE END\n");

            Console.WriteLine($"Well, {name}, I hope you enjoyed this mad lib version of The Three Little Pigs.");
            Console.WriteLine($"Honestly, {name}, this was a lot to do! Maybe I won't think of another ridiculous idea for the next exercise...\n");
            Console.WriteLine("Anyways, thank you for reading my story!");

        }
    }
}