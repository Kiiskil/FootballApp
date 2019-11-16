using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using FootballAPI.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace FootballAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            var url = "https://functionapp2018071101324.blob.core.windows.net/data/matches_latest.json";
            var matches = new List<Match>();
            matches.Add(_download_serialized_json_data<Match>(url));
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        private static T _download_serialized_json_data<T>(string url) where T : new() {
            //universal method, which takes url as arg and tries to convert json from url to class, which is specified at method call. 
            //SIIRRÄ MUUALLE; CONTROLLERIIN PREF
            using (var w = new WebClient()) {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try {
                    json_data = w.DownloadString(url);
                    //Console.Write(json_data);
                }
                catch (Exception) {
                    Console.WriteLine("BUSTED!");
                }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }          
    }
}
