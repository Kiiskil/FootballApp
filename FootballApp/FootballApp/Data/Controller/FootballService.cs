using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace FootballApp.Data
{
    public class FootballService
    {
        public T _download_serialized_json_data<T>(string url) where T : new()
        {
            //Need to be async method?
            //universal method, which takes url as arg and tries to convert json from url to class, which is specified at method call.
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString(url);
                }
                catch (Exception)
                {
                    //This has not been tested yet
                    //TODO: check the version of resource fiel and update it if it differs from existing one.
                    using (StreamReader r = new StreamReader("matches_latest.json"))
                    {
                        json_data = r.ReadToEnd();
                    }
                    Console.WriteLine("JSON not loaded from web, using backup!");
                }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }
    }
}
