using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FootballApp.Models;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace FootballApp.Data
{
    public class FootballMatchService
    {
        //string url = "https://functionapp2018071101324.blob.core.windows.net/data/matches_latest.json";
        //public Matchlist matchlist = new Matchlist();
        
        public static async Task<T> DownloadSerializesJsonData<T>(string url) where T : new()
        {
           
            //universal method, which takes url as arg and tries to convert json from url to class, which is specified at method call. 
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = await w.DownloadStringTaskAsync(url);
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

