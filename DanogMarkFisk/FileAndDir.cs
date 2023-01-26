using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanogMarkFisk
{
    public class FileAndDir
    {
        private string maindir = "@C:/User/Dan&Mark";
        private string aq1 = "@C:/User/Dan&Mark/Aq1";
        private string aq2 = "@C:/User/Dan&Mark/Aq2";
        private string aq3 = "@C:/User/Dan&Mark/Aq3";
        private string aq4 = "@C:/User/Dan&Mark/Aq4";


        public void Control()
        {

            if(!Directory.Exists(maindir))
            {
            Directory.CreateDirectory(maindir);
            Directory.CreateDirectory(aq1);
            Directory.CreateDirectory(aq2);
            Directory.CreateDirectory(aq3);
                Directory.CreateDirectory(aq4);
            }
        }
    }
}
