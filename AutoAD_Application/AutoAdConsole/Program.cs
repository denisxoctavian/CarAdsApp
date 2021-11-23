using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoAdModel;

namespace AutoAdConsole
{
    class Program
    {
       
        static void Main(string[] args)
        {
            AutoAdList Ads = new AutoAdList();
            Ads.LoadFromDisk();
            Console.Write(Ads);
            Console.ReadLine();

        }
    }
}
