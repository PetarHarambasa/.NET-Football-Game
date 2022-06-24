using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldCupLibrary.Factory;
using WorldCupLibrary.Model;

namespace WorldCupLibrary.Utils
{
    public static class FileUtils<T>
    {
        public static bool CheckIfExists(string path) => File.Exists(path);

        public static string ReadFile(string path) => File.ReadAllText(path);

        private static string ReadFromFile(string path)
        {
            string data;

            if (CheckIfExists(path))
            {
                data = ReadFile(path);
            }
            else
            {
                data = null;
            }
            return data;
        }

        public static void  SaveDataToJSON(T settings, string path)
        {
            string JSONObject = ParserFactory<T>.SaveJSON(settings);
            File.WriteAllText(path, JSONObject);
        }
        public static T LoadDataFromJSON(string path)
        {
            string data = ReadFromFile(path);
            return ParserFactory<T>.LoadData(data);
        }

    }
}
