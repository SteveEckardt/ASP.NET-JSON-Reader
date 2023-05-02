using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsApp.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Time { get; set; }
    }
}
