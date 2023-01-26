using DanogMarkFisk;

namespace DanogMarkFisk
{
    public class FishMenu
    {

        public void Menu()
        {
            
            Console.Clear();
            FileAndDir fad = new FileAndDir();
            Console.WriteLine("\nFish menu \n\n(1) Add Fish\n\nPick what to show list\n(2) Aquarium 1\n(3) Aquarium 2\n(4) Aquarium 3\n(5) Aquarium 4\n(6) Show All");
            var v = Console.ReadKey(true);
            switch (v.KeyChar)
            {
                case '1':
                    Console.Clear();
                    AddFish();
                    break;
                case '2':
                    ShowAq1(fad);
                    break;
                case '3':
                    ShowAq2(fad);

                    break;
                case '4':
                    ShowAq3(fad);
                    break;
                case '5':
                    ShowAq4(fad);
                    break;
                case '6':
                    ShowAll(fad);
                    break;
                default:
                    break;
            }
        }

        private static void ShowAq1(FileAndDir fad)
        {
            Console.Clear();
            string[] filePaths = Directory.GetFiles(fad.aq1);
            foreach (string filePath in filePaths)
            {
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine(fileContent);
            }
            Console.ReadKey();
        }

        private static void ShowAq2(FileAndDir fad)
        {
            Console.Clear();
            string[] filePaths2 = Directory.GetFiles(fad.aq2);
            foreach (string filePath in filePaths2)
            {
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine(fileContent);

            }
            Console.ReadKey();
        }

        private void ShowAq3(FileAndDir fad)
        {
            Console.Clear();
            string[] filePaths3 = Directory.GetFiles(fad.aq3);
            foreach (string filePath in filePaths3)
            {
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine(fileContent);
            }
            Console.ReadKey();

        }

        private void ShowAq4(FileAndDir fad)
        {
            Console.Clear();
            string[] filePaths4 = Directory.GetFiles(fad.aq4);
            foreach (string filePath in filePaths4)
            {
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine(fileContent);
            }
            Console.ReadKey();
            Menu();
        }

        private void ShowAll(FileAndDir fad)
        {
            Console.Clear();
            string[] filePathsA1 = Directory.GetFiles(fad.aq1);
            string[] filePathsA2 = Directory.GetFiles(fad.aq2);
            string[] filePathsA3 = Directory.GetFiles(fad.aq3);
            string[] filePathsA4 = Directory.GetFiles(fad.aq4);
            Console.WriteLine("Aquarium 1\nFish in Tank:");
            foreach (string filePath in filePathsA1)
            {
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine(fileContent);
            }
            Console.WriteLine();
            Console.WriteLine("Aquarium 2\nFish in Tank:");
            foreach (string filePath in filePathsA2)
            {
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine(fileContent);
            }
            Console.WriteLine();
            Console.WriteLine("Aquarium 3\nFish in Tank:");
            foreach (string filePath in filePathsA3)
            {
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine(fileContent);
            }
            Console.WriteLine();
            Console.WriteLine("Aquarium 4\nFish in Tank:");
            foreach (string filePath in filePathsA4)
            {
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine(fileContent);
            }
            Console.ReadKey();
            Menu();
        }

        //Tilføj Fisk
        public void AddFish()
        {
            FileAndDir fad = new FileAndDir();
            Fish fish = new Fish();
            Console.WriteLine("What is the name of the Fish?");
            fish.FishName = Convert.ToString(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Saltwater-fish(1)");
            Console.WriteLine("Freshwater-fish(2)");
            var v = Console.ReadKey(true);
            switch (v.KeyChar)
            {
                case '1':
                    fish.FishType = true;


                    break;
                case '2':
                    fish.FishType = false;

                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Invalid input");
                    AddFish();
                    break;
            }
            Console.Clear();
            Console.WriteLine("Meat-eating Fish (1)");
            Console.WriteLine("Plant-eating Fish(2)");
            var u = Console.ReadKey(true);
            switch (u.KeyChar)
            {
                case '1':
                    fish.FishFood = true;


                    break;
                case '2':
                    fish.FishFood = false;

                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Invalid input");
                    AddFish();
                    break;
            }
            fad.Control();
            FileAndDir.WriteToFile(fad, fish);
        }


    }
}
