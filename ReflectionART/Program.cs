using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ReflectionART
{
    class Program
    {
        static void Main(string[] args)
        {
            //object ooo = X_Art_View.ArtMovieSaveLoad.Load("Hegre100.dat");
            //var kk = ooo.GetType().GetGenericArguments();

            //var p_count =ooo.GetType().GetField("Count");
            //var p1 = ooo.GetType().GetProperty("Count");
            //var p1_value = p1.GetValue(ooo, null);

            //var p2 = ooo.GetType().GetProperty("Item");
            //for (int i = 0; i < (int)p1_value; i++)
            //{
            //    var p2_value = p2.GetValue(ooo, new object[] { i });
            //    p2_value.GetType();
            //}
            //O();
            K();

            Console.ReadKey();


        }

        static void O()
        {
            List<MethodInfo> ListMethods = new List<MethodInfo>();

            X_Art_View.MagnetGet nc = new X_Art_View.MagnetGet();
            Type t = nc.GetType();
            object obj = Activator.CreateInstance(t);
            MethodInfo[] ms = t.GetMethods();
            foreach (MethodInfo item in ms)
            {
                if (item.Name.IndexOf("Get") != -1)
                {
                    ListMethods.Add(item);
                }
            }
            int methodsNumber = 1;
            Console.WriteLine("The following Methods is Available,Choose One To Use");
            foreach (MethodInfo item in ListMethods)
            {
                Console.WriteLine((methodsNumber++) + ": " + item.Name);
            }
            Console.WriteLine("Input the number and Press Enter");
            int userInput = 0;
            var usrIpt = Console.ReadLine();
            while (!int.TryParse(usrIpt, out userInput) || userInput > ListMethods.Count || userInput <= 0)
            {
                Console.WriteLine("Input the number and Press Enter");
                usrIpt = Console.ReadLine();
            }
            object[] par = new object[1];
            Console.WriteLine("input key word to Search!");
            par[0] = Console.ReadLine();
            Console.WriteLine("Working... Please Wait...");
            var result = ListMethods[userInput].Invoke(obj, par);
            var listResult = (result as List<X_Art_View.MagnetResult>);

            StringBuilder sb = new StringBuilder();
            foreach (var item in listResult)
            {
                sb.AppendLine(item.ToString());
            }
            var fn = System.IO.Path.ChangeExtension(System.IO.Path.GetTempFileName(), ".txt");
            System.IO.File.WriteAllText(fn, sb.ToString(), Encoding.UTF8);
            System.Diagnostics.Process.Start(fn);

        }
        static void K()
        {
            List<MethodInfo> ListMethods = new List<MethodInfo>();

            var nc = new X_Art_View.HegrePage();
            Type t = nc.GetType();
            object obj = Activator.CreateInstance(t);
            MethodInfo[] ms = t.GetMethods();
            foreach (MethodInfo item in ms)
            {
                if (item.Name.IndexOf("Get") != -1)
                {
                    ListMethods.Add(item);
                }
            }
            int methodsNumber = 1;
            Console.WriteLine("The following Methods is Available,Choose One To Use");
            foreach (MethodInfo item in ListMethods)
            {
                Console.WriteLine((methodsNumber++) + ": " + item.Name);
            }
            Console.WriteLine("Input the number and Press Enter");
            int userInput = 0;
            var usrIpt = Console.ReadLine();
            while (!int.TryParse(usrIpt, out userInput) || userInput > ListMethods.Count || userInput <= 0)
            {
                Console.WriteLine("Input the number and Press Enter");
                usrIpt = Console.ReadLine();
            }
            object[] par = new object[1];
            Console.WriteLine("input key word to Search!");
            par[0] = Console.ReadLine();
            Console.WriteLine("Working... Please Wait...");
            if (par[0].GetType()== ListMethods[userInput].GetParameters()[0].ParameterType)
            {
                
            }
            else
            {
                par[0] = Convert.ToInt32(par[0]);
            }

            var result = ListMethods[userInput].Invoke(obj, par);
            var listResult = (result as List<X_Art_View.ArtMovie>);

            StringBuilder sb = new StringBuilder();
            foreach (var item in listResult)
            {
                sb.AppendLine(item.ToString());
            }
            var fn = System.IO.Path.ChangeExtension(System.IO.Path.GetTempFileName(), ".txt");
            System.IO.File.WriteAllText(fn, sb.ToString(), Encoding.UTF8);
            System.Diagnostics.Process.Start(fn);

        }
    }
}
