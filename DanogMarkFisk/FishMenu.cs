using DanogMarkFisk;

namespace DanogMarkFisk
{
    public class FishMenu
    {
        public void Menu()
        {
            Console.WriteLine("\nFish menu \n\n(1) Add Fish\n\nPick what to show list\n(2) Aquarium 1\n(3) Aquarium 2\n(4) Aquarium 3\n(5) Aquarium 4");
            var v = Console.ReadKey(true);
            switch (v.KeyChar)
            {
                case '1':
                    Console.Clear();
                    AddFish();
                    break;
                case '2':
                    Console.Clear();

                    break;
                case '3':
                    Console.Clear();

                    break;
                case '4':
                    Console.Clear();

                    break;
                case '5':
                    Console.Clear();

                    break;

                default:
                    break;
            }
        }

        //Tilføj Fisk
        public void AddFish()
        {
            Fish fish = new Fish();
            Console.WriteLine("Saltwaterfish(1)");
            Console.WriteLine("Freshwaterfish(2)");
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


            //Aquarium 1 




            //Aquarium 2



            //Aquarium 3



            //Aquarium 4

        }
    }
}
