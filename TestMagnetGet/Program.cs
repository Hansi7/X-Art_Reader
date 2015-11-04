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
            //TestMangnetLink();
            TestHegre();


        }

        private static void TestHegre()
        {
            HegrePage hegre = new HegrePage();
            hegre.CompleteOneItem += hegre_CompleteOneItem;
            hegre.IsDownloadBoardPicture = true;
            hegre.IsDownloadCoverPicture = true;
            //var movies = hegre.GetGalleries(1);
            var movies = hegre.GetVideos(1);
            ArtMovieSaveLoad.Save("Hegre100.dat", movies);
            foreach (var item in movies)
            {
                Console.WriteLine(item.ToString());
            }
            Done();


        }

        static void hegre_CompleteOneItem(object sender, OneCompleteEventArg e)
        {
            Console.WriteLine("Hegre One!" + e.Tag.ToString());
        }

        private static void TestMangnetLink()
        {
            MagnetGet mg = new MagnetGet();
            Console.WriteLine("input keyword to search!");
            var rrrr = mg.GetMagLink_Extratorrent_cc("A Night In Vegas");
            foreach (var item in rrrr)
            {
                Console.WriteLine(item.ToString());
            }
            Done();
            Console.ReadKey();
        }

        static void Done()
        {
            Console.WriteLine("DONE!");
        }
    }
}
