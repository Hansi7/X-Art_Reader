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
            mg.TryToFind("X-art");
        }

        static void mg_GetDone(object sender, EventArgs e)
        {
            Console.WriteLine("DONE!");
        }
    }
}
