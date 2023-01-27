namespace DanogMarkFisk
{
    public class FileAndDir
    {
        public string maindir = "C:/User/Dan&Mark";
        public string aq1 = "C:/User/Dan&Mark/Aq1";
        public string aq2 = "C:/User/Dan&Mark/Aq2";
        public string aq3 = "C:/User/Dan&Mark/Aq3";
        public string aq4 = "C:/User/Dan&Mark/Aq4";
        public bool con;
        public void Control()
        {
            if (!Directory.Exists(maindir))
            {
                Directory.CreateDirectory(maindir);
                Directory.CreateDirectory(aq1);
                Directory.CreateDirectory(aq2);
                Directory.CreateDirectory(aq3);
                Directory.CreateDirectory(aq4);
                con = true;
            }
            else
            {
                con = false;
            }
        }
        public static void WriteToFile(FileAndDir fad, Fish fish)
        {
            if (fad.con = true)
            {
                if (fish.FishType == false && fish.FishFood == true)
                {
                    File.WriteAllText(fad.aq1 + "/" + fish.FishName, $"Name: {fish.FishName}, Type: Freshwater, Diet: Meat");
                }
                else if (fish.FishType == false && fish.FishFood == false)
                {
                    File.WriteAllText(fad.aq2 + "/" + fish.FishName, $"Name: {fish.FishName}, Type: Freshwater, Diet: Plants");
                }
                else if (fish.FishType == true && fish.FishFood == true)
                {
                    File.WriteAllText(fad.aq3 + "/" + fish.FishName, $"Name: {fish.FishName}, Type: Saltwater, Diet: Meat");
                }
                else if (fish.FishType == true && fish.FishFood == false)
                {
                    File.WriteAllText(fad.aq4 + "/" + fish.FishName, $"Name: {fish.FishName}, Type: Saltwater, Diet: plants");
                }
            }
            Console.Clear();
            Console.WriteLine("Your fish is now added.");
            Console.ReadKey();
        }
    }
}
