using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using WorldCupLibrary.Model;

namespace WorldCupLibrary.Factory
{
    public class UrlConectionFactory<T>
    {
        public static async Task<T> Load(string url)
        {
            var client = new WebClient();
            client.Headers.Add("User-Agent", "Nothing");

            var content = client.DownloadString(url);

            var serializer = new DataContractJsonSerializer(typeof(T));
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
            {
                var data = (T)serializer.ReadObject(ms);
                return data;
            }
        }
    }
}
