
namespace DanogMarkFisk
{
    public class FishMenu
    {
        public void Menu()
        {
            Console.Clear();
            FileAndDir fad = new FileAndDir();
            Console.WriteLine("\nFish menu \n\n(1) Add Fish\n(2) Show All");
            var v = Console.ReadKey(true);
            switch (v.KeyChar)
            {
                case '1':
                    Console.Clear();
                    AddFish(fad);
                    break;
                case '2':
                    ShowAll(fad);
                    break;
                default:
                    break;
            }
        }
        private void ShowAll(FileAndDir fad)
        {
            Console.Clear();
            string[] filePathsA1 = Directory.GetFiles(fad.aq1);
            string[] filePathsA2 = Directory.GetFiles(fad.aq2);
            string[] filePathsA3 = Directory.GetFiles(fad.aq3);
            string[] filePathsA4 = Directory.GetFiles(fad.aq4);

            Aquarium(filePathsA1, "Aquarium 1");
            Aquarium(filePathsA2, "Aquarium 2");
            Aquarium(filePathsA3, "Aquarium 3");
            Aquarium(filePathsA4, "Aquarium 4");
            Console.ReadKey();
        }
        private static void Aquarium(string[] filePaths, string number)
        {
            Console.WriteLine();
            Console.WriteLine("{0}\nFish in Tank:", number);
            foreach (string filePath in filePaths)
            {
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine(fileContent);
            }
        }
        private void AddFish(FileAndDir fad) //Tilføj Fisk
        {
            Fish fish = new Fish();
            Console.WriteLine("What is the name of the Fish?");
            fish.FishName = Convert.ToString(Console.ReadLine());
            string Name = fish.FishName;
            if (Name.Any(char.IsDigit) || Name.Length >= 20)
            {
                Console.Clear();
                Console.WriteLine("A fishname cannot include numbers, and must not exceed 20 characters.");
                Console.ReadKey();
            }
            else if(!Name.Any(char.IsDigit) && Name.Length <= 20)
            {
                FishTypeControl(fad, fish);
            }
        }

        private static void FishTypeControl(FileAndDir fad, Fish fish)
        {
            Console.Clear();
            Console.WriteLine("Saltwater-fish(1)");
            Console.WriteLine("Freshwater-fish(2)");
            var v = Console.ReadKey(true);
            switch (v.KeyChar)
            {
                case '1':
                    fish.FishType = true;
                    GetDiet(fad, fish);
                    break;
                case '2':
                    fish.FishType = false;
                    GetDiet(fad, fish);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid input");
                    break;
            }
        }

        private static void GetDiet(FileAndDir fad, Fish fish)
        {
            Console.Clear();
            Console.WriteLine("Meat-eating Fish (1)");
            Console.WriteLine("Plant-eating Fish(2)");
            var u = Console.ReadKey(true);
            switch (u.KeyChar)
            {
                case '1':
                    fish.FishFood = true;
                    fad.Control();
                    FileAndDir.WriteToFile(fad, fish);
                    break;
                case '2':
                    fish.FishFood = false;
                    fad.Control();
                    FileAndDir.WriteToFile(fad, fish);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
