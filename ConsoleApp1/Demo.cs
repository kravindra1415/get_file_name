using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Demo
    {
        public void getFiles()
        {
            try
            {
                string[] dirs = Directory.GetFiles(@"F:\getFiles\ConsoleApp1\ConsoleApp1\files\", "a*");
                Console.WriteLine("The number of files starting with c is {0}.", dirs.Length);

                foreach (string dir in dirs)
                {
                    Console.WriteLine(dir);
                    var data = dir.Substring(dir.LastIndexOf('\\')+1);
                    Console.WriteLine(data);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }
    }
}
//F:\getFiles\ConsoleApp1\ConsoleApp1\files\