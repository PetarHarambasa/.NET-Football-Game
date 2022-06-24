using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCupLibrary.Factory
{
    public class ParserFactory<T>
    {
        public static T CreateJSONParaser(string content)
        {
            T generic = default;
            try
            {
                if (content != "")
                {
                    generic = JsonConvert.DeserializeObject<T>(content);
                }
                return generic;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public static string SaveJSON(T settings) => JsonConvert.SerializeObject(settings);

        public static T LoadData(string data)
        {
            T content = default;
            if (data != null)
            {
                content = JsonConvert.DeserializeObject<T>(data);
            }

            return content;
        }
    }
}
