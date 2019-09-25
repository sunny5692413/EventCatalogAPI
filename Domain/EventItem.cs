using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Domain
{
    public class EventItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime Time { get; set; }
        public string Description { get; set; }
       
        public string PictureUrl { get; set; }
        public int EventTypeId { get; set; }

        public virtual EventType EventType { get; set; }//nevigational property
        public int EventPriceId { get; set; }
        public virtual EventPrice EventPrice { get; set; } //a reference type data will not take any space in memory
        public int EventLocationId { get; set; }
        public virtual EventLocation EventLocation { get; set; } 
    }
}
