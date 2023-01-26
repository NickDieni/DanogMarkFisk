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
            Console.WriteLine("Is it a");
        }


        //Aquarium 1 




        //Aquarium 2



        //Aquarium 3



        //Aquarium 4

    }
}
