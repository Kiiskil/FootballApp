using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FootballAPI.Models;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace FootballAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FootballMatchController : ControllerBase
    {
        private readonly ILogger<FootballMatchController> _logger;
        Matchlist _matches = new Matchlist();

        public FootballMatchController(ILogger<FootballMatchController> logger)
        {
            _logger = logger;
            var url = "https://functionapp2018071101324.blob.core.windows.net/data/matches_latest.json";
            _matches.Matches = _download_serialized_json_data<List<Match>>(url); 
        }

        private static T _download_serialized_json_data<T>(string url) where T : new() {
            //universal method, which takes url as arg and tries to convert json from url to class, which is specified at method call. 
            using (var w = new WebClient()) {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try {
                    json_data = w.DownloadString(url);
                }
                catch (Exception) {
                    //This has not been tested yet
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

        //GET /footballmatch/
        [HttpGet]
        public ActionResult GetAllMatches(){
            return Ok(_matches.Matches);
        }

        //GET /footballmatch/list/ID
        [HttpGet("list/{id}")]
        public ActionResult GetMatchByListID(int id){
            Match target = _matches.Matches[id];
            if(target != null){
                return Ok(target);
            }
            else {
                return NotFound();
            }
        }

        //GET /footballmatch/match/ID
        [HttpGet("match/{id}")]
        public ActionResult GetMatchByID(int id){
            Match target = _matches.Matches.SingleOrDefault(p => p.Id == id);
            if(target != null){
                return Ok(target);
            }
            else {
                return NotFound();
            }
        }
    }
}
