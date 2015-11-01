using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using X_Art_View;
namespace TestMagnetGet
{
    class Program
    {
        static void Main(string[] args)
        {
            MagnetGet mg = new MagnetGet();
            Console.WriteLine("input keyword to search!");
            var keyword = Console.ReadLine();
            var rrrr =  mg.GetMagLink_Extratorrent_cc("A Night In Vegas");
            foreach (var item in rrrr)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }

        static void mg_GetDone(object sender, EventArgs e)
        {
            Console.WriteLine("DONE!");
        }
    }
}
