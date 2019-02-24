using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTracker.APIBackService.Models
{
    public class TripSegment
    {
        public int Id { get; set; }
        public string TripId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        //Store the date timezone offset
        public DateTimeOffset StartDateTime { get; set; }
        public DateTimeOffset EndDateTime { get; set; }
        
    }

    


}