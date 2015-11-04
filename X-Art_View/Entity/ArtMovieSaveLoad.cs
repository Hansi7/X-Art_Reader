using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace X_Art_View
{
    public static class ArtMovieSaveLoad
    {
        public static bool Save(string fileName, List<ArtMovie> movies)
        {
            try
            {
                System.IO.FileStream fs = new System.IO.FileStream(fileName, System.IO.FileMode.Create);
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                bf.Serialize(fs, movies);
                fs.Close();
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < movies.Count; i++)
                {
                    sb.AppendLine(movies[i].ToString());
                }
                System.IO.File.WriteAllText(System.IO.Path.ChangeExtension(fileName, "txt"), sb.ToString());

                return true;
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message);
                return false;
            }

        }

        public static List<ArtMovie> Load(string fileName)
        {
            List<ArtMovie> list = new List<ArtMovie>();

            using (System.IO.FileStream fs = new System.IO.FileStream(fileName, System.IO.FileMode.Open))
            {
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                list = bf.Deserialize(fs) as List<ArtMovie>;
                System.Windows.Forms.MessageBox.Show("Loaded!");
            }

            return list;
        }

    }
}
