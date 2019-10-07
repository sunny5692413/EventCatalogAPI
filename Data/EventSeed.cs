using Microsoft.EntityFrameworkCore;
using EventCatalogAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Data
{
    public static class EventSeed
    {
        public static void Seed(EventContext context)
        {
            context.Database.Migrate();
            if (!context.EventLocations.Any())
            {
                context.EventLocations.AddRange
                    (GetPreconfiguredEventLocations());
                context.SaveChanges();
            }
            if (!context.EventTypes.Any())
            {
                context.EventTypes.AddRange
                    (GetPreconfiguredEventTypes());
                context.SaveChanges();
            }
            if (!context.EventPrices.Any())
            {
                context.EventPrices.AddRange
                    (GetPreconfiguredEventPrices());
                context.SaveChanges();
            }
            if (!context.EventItems.Any())
            {
                context.EventItems.AddRange
                    (GetPreconfiguredEventItems());
                context.SaveChanges();
            }

        }

        private static IEnumerable<EventItem> GetPreconfiguredEventItems()
        {
            return new List<EventItem>()
            {
               new EventItem() { EventTypeId=2, EventLocationId=2,EventPriceId=1,  Time = new DateTime(2019,11,1) , Description = "Join us in viewing new displays by local arists.", Name = "First Tuesday Art Crawl", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/2" },
                new EventItem() { EventTypeId=3,EventLocationId=4, EventPriceId=4, Time = new DateTime(2019,11,5) ,Description = "Get your hands floury and take home something tasty!", Name = "Pasta Making Class", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/3" },
                new EventItem() { EventTypeId=4,EventLocationId=3, EventPriceId=2, Time = new DateTime(2019,11,10) ,Description = "Grow your network and meet your neighbors.", Name = "Eastside Networking Happy Hour", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/4" },
                new EventItem() { EventTypeId=4,EventLocationId=1, EventPriceId=2, Time = new DateTime(2019,11,20) ,Description = "Grow your network and meet your neighbors.", Name = "Westside Networking Happy Hour", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/5" },
                new EventItem() { EventTypeId=5,EventLocationId=3, EventPriceId=3, Time = new DateTime(2019,11,27) ,Description = "Buy and sell handmade goods and goodies.", Name = "Fall Craft Fair",  PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/6" },
                new EventItem() { EventTypeId=2,EventLocationId=2, EventPriceId=3, Time = new DateTime(2019,12,05) ,Description = "We'll have drinks available for purchase and pro painters here to help you make a masterpiece.", Name = "Paint and Sip Night", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/7"  },
                new EventItem() { EventTypeId=1,EventLocationId=1, EventPriceId=4, Time = new DateTime(2019,12,07) ,Description = "Monthly Jazz Happy Hour. This month we have a suprrise guest from NYC.", Name = "Evening of Jazz", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/8" },
                new EventItem() { EventTypeId=5,EventLocationId=4, EventPriceId=1, Time = new DateTime(2019,10,29) , Description = "Enjoy an evening of classical music in the park.", Name = "Classical Music in the Park", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/1" },
                new EventItem() { EventTypeId=2,EventLocationId=4, EventPriceId=4, Time = new DateTime(2019,12,11) ,Description = "Kids and adults will love blowing bubbles and balloons.", Name = "Bubbles and Balloons", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/9" },
                new EventItem() { EventTypeId=3,EventLocationId=2, EventPriceId=2, Time = new DateTime(2019,12,21) ,Description = "8 new Food Trucks will show off tasty bites for purchase.", Name = "Food Truck Showdown",  PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/10" },
                new EventItem() { EventTypeId=1,EventLocationId=2, EventPriceId=3, Time = new DateTime(2019,12,23) ,Description = "Dance to some 60's French Pop tunes", Name = "French Pop Dance Party",  PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/11" },
                new EventItem() { EventTypeId=4,EventLocationId=3, EventPriceId=2, Time = new DateTime(2020,12,29) ,Description = "Tech industry professionals will meet up to network.", Name = "TechMeetup", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/12" },
                new EventItem() { EventTypeId=1,EventLocationId=1, EventPriceId=1, Time = new DateTime(2020,1,15) ,Description = "We'll have pros on hand to help you re-draf that resume and get that job!", Name = "Resume Bootcamp", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/13" },
                new EventItem() { EventTypeId=5,EventLocationId=4, EventPriceId=4, Time = new DateTime(2020,1,29) ,Description = "Family fun with tasty cold treats!", Name = "Popsicle Party",  PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/14" },
                new EventItem() { EventTypeId=1,EventLocationId=2, EventPriceId=3, Time = new DateTime(2020,2,15) ,Description = "Come see what area Highschools have been working on at the Marching Band Soundoff.", Name = "Marching Band Soundoff",  PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/15" },
                new EventItem() { EventTypeId=2,EventLocationId=2, EventPriceId=2, Time = new DateTime(2020,2,17) ,Description = "Learn about and enjoy some of Van Gogh's greatest works", Name = "Van Gogh", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/16" },
                new EventItem() { EventTypeId=2,EventLocationId=3, EventPriceId=1, Time = new DateTime(2020,2,25) ,Description = "Benefit Art Auction with proceeds going to the American Heart Association.", Name = "Arto with Heart", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/17" },
                new EventItem() { EventTypeId=5,EventLocationId=1, EventPriceId=3, Time = new DateTime(2020,03,10) ,Description = "For entry rules and to sign up see our website. These tickets are for spectators.", Name = "Soap Box Derby", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/18" },
                new EventItem() { EventTypeId=3,EventLocationId=4, EventPriceId=1, Time = new DateTime(2020,03,21) ,Description = "Come make cheese and potato pierogis!", Name = "Pierogi Making", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/19" },
                new EventItem() { EventTypeId=1,EventLocationId=2, EventPriceId=4, Time = new DateTime(2020,04,03) ,Description = "BLuegrass music every 3rd Friday.", Name = "Blue Grass Fridays", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/20" },
                new EventItem() { EventTypeId=4,EventLocationId=1, EventPriceId=2, Time = new DateTime(2020,04,05) ,Description = "Recruiters will tell you what they're looking for and help you with keywords and phrases.", Name = "Meet a Recruiter", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/21" },
                new EventItem() { EventTypeId=1,EventLocationId=3, EventPriceId=3, Time = new DateTime(2020,06,20) ,Description = "We'll be playing top hits from the 80s all night long with some local cover bands.", Name = "80's Music Tribute", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/22" },
                new EventItem() { EventTypeId=5,EventLocationId=4, EventPriceId=1, Time = new DateTime(2020,06,23) ,Description = "We've got reptiles and furry animals for your little ones to meet, feed, and pet!", Name = "Petting Zoo", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/23" },
                new EventItem() { EventTypeId=3,EventLocationId=4, EventPriceId=4, Time = new DateTime(2020,07,02) ,Description = "Meet local ice cream makers and enjoy a variety of tasty treats!", Name = "Ice Cream Social", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/24" },
                new EventItem() { EventTypeId=5,EventLocationId=1, EventPriceId=1, Time = new DateTime(2020,07,14) ,Description = "With rides, games, and food there is fun for everyone!", Name = "Family Fun Days", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/25" },
                new EventItem() { EventTypeId=4,EventLocationId=2, EventPriceId=3, Time = new DateTime(2020,07,29) ,Description = "Hiring managers will be helping you with real world examples and their favorite tips.", Name = "Ace the Interview", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/26" },
                new EventItem() { EventTypeId=1,EventLocationId=3, EventPriceId=2, Time = new DateTime(2020,08,03) ,Description = "Check out our song book and get ready to rock your favorite song!", Name = "karaoke Night", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/27" },
                new EventItem() { EventTypeId=5,EventLocationId=2, EventPriceId=4, Time = new DateTime(2020,08,05) ,Description = "Learn tips and tricks for camping with small children. Gear will be availabe to try on for size.", Name = "Camping with Little Ones", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/28" },
                new EventItem() { EventTypeId=2,EventLocationId=4, EventPriceId=4, Time = new DateTime(2020,08,29) ,Description = "We will be making pinch pots, no prior experience required.", Name = "Pottery Night", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/29" },
                new EventItem() { EventTypeId=4,EventLocationId=1, EventPriceId=2, Time = new DateTime(2020,09,2) ,Description = "Network and trade tips with your service industry peers.", Name = "Industry Night", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/30" },
                new EventItem() { EventTypeId=4,EventLocationId=2, EventPriceId=3, Time = new DateTime(2020,09,05) ,Description = "Have questions about the tech, financial, or healthcare industry? We will have experts on site to answer them.", Name = "Ask An Expert", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/31" },
                new EventItem() { EventTypeId=3,EventLocationId=1, EventPriceId=1, Time = new DateTime(2020,09,30) ,Description = "Vegetarian, vegan, and meat tacos will be available for purchase.", Name = "Taco Tuesday", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/32" },
                new EventItem() { EventTypeId=2,EventLocationId=2, EventPriceId=1, Time = new DateTime(2020,10,02) ,Description = "Come see the exhibit on loan from the Smithsonian.", Name = "Arto of Ancient Egypt", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/33" },
                new EventItem() { EventTypeId=3,EventLocationId=1, EventPriceId=2, Time = new DateTime(2020,10,15) ,Description = "Basic supply list will be emailed to attendeess. We will be canning carrots and corn.", Name = "Intro to Canning", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/34" },
                new EventItem() { EventTypeId=1,EventLocationId=3, EventPriceId=3, Time = new DateTime(2020,10,20) ,Description = "Sisters Violet and Viviane will be sharing the stage.", Name = "Violas and Violins", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/35" },
                new EventItem() { EventTypeId=1,EventLocationId=3, EventPriceId=4, Time = new DateTime(2020,10,22) ,Description = "We're excited to host a traveling chamber music group to fill our beautiful space with classical sounds.", Name = "Classical Chamber Music", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/36" },
                new EventItem() { EventTypeId=5,EventLocationId=4, EventPriceId=3, Time = new DateTime(2020,10,28) ,Description = "Bring your kids and let's enjoy some games under glow lights.", Name = "Glow Light Games", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/37" },
                new EventItem() { EventTypeId=2,EventLocationId=3, EventPriceId=1, Time = new DateTime(2020,11,20) ,Description = "UW art professors will walk you through modern art concepts.", Name = "Modern Art- An Introduction", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/38" },
                new EventItem() { EventTypeId=3,EventLocationId=1, EventPriceId=2, Time = new DateTime(2020,11,23) ,Description = "Grab your friends or make new ones at this family-style meal.", Name = "Eating Family Style", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/39" },
                new EventItem() { EventTypeId=5,EventLocationId=2, EventPriceId=4, Time = new DateTime(2020,11,27) ,Description = "Lace up your shoes and get your running crew together for a family 5K.", Name = "Family Fun Run", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/40" }
            };
        }

        private static IEnumerable<EventType> GetPreconfiguredEventTypes()
        {
            return new List<EventType>()
            {
                new EventType() {Type = "Music"},
                new EventType() {Type = "Art"},
                new EventType() {Type = "Food"},
                new EventType() {Type = "Career"},
                new EventType() {Type = "Family"}
            };
        }

        private static IEnumerable<EventLocation> GetPreconfiguredEventLocations()
        {
            return new List<EventLocation>()
            {
                new EventLocation() {Location = "Seattle"},
                new EventLocation() {Location = "Bellevue"},
                new EventLocation() {Location = "Redmond"},
                new EventLocation() {Location = "Bothell"}
            };
        }
        private static IEnumerable<EventPrice> GetPreconfiguredEventPrices()
        {
            return new List<EventPrice>()
            {
                //new EventPrice() {Price = "Free"},
                //new EventPrice() {Price = "$5"},
                //new EventPrice() {Price = "$10"},
                //new EventPrice() {Price = "$15"}
                new EventPrice() {Price = 0},
                new EventPrice() {Price = 5},
                new EventPrice() {Price = 10},
                new EventPrice() {Price = 15}
            };
        }
    }
}
