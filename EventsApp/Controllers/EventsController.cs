using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using EventsApp.Models;
using System.Net;
using Newtonsoft.Json;



namespace EventsApp.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult GetEventsList()
        {
            var webClient = new WebClient();
            var jsondata = webClient.DownloadString(@"https://hills.ccsf.edu/~seckardt/cnit134/events.json");
            var EventsList = JsonConvert.DeserializeObject<ListEvents>(jsondata);
            return View(EventsList);
        }
    }
}
