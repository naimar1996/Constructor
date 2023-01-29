using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    public class Building
    {
        public string name;
        public int height;
        public int area;
        public string address;

        public Building(int height, int area)
        {
            this.height = height;
            this.area = area;
        }
        public void GetVolume()
        {
            int volume = height * area;
            Console.WriteLine(volume);
        }
    }
}
