using Microsoft.Bot.Connector;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Web;
using System.Web.Script.Serialization;

namespace Tourbot
{
    public class Data
    {

        public static Attachment GetReceiptCard()
        {
            var receiptCard = new ReceiptCard
            {
                Title = "Mumbai Journey",

                Items = new List<ReceiptItem>
                 {
                    new ReceiptItem("Air Plane", price: "Upto 8000 Rs: ", quantity: "1", image: new CardImage(url: "https://www.google.co.in/search?q=airplane+images&source=lnms&tbm=isch&sa=X&ved=0ahUKEwi65JXqtubZAhUMlJQKHcyBA64Q_AUICigB&biw=1407&bih=655#imgrc=VjENmwnfXxIMZM:")),
                    new ReceiptItem("Train", price: "$ 45.00", quantity: "1", image: new CardImage(url: "https://github.com/amido/azure-vector-icons/raw/master/renders/cloud-service.png")),
                 },
                Tax = "$ 7.50",
                Total = "$ 90.95",
                Buttons = new List<CardAction>
                {
                    new CardAction(
                     ActionTypes.OpenUrl,
                     "More information",
                     "https://account.windowsazure.com/content/6.10.1.38-.8225.160809-1618/aux-pre/images/offer-icon-freetrial.png",
                    "https://azure.microsoft.com/en-us/pricing/")
                }
            };

            return receiptCard.ToAttachment();
        }


        //Fort ...........

        public static Attachment GetAmerFort()
        {

            var AmerFort = new HeroCard
            {
                Title = "Amer Fort",
                Subtitle = $"16th-century hilltop fort & palace \r\r ratings (4.5)",
                Text = "Amer Fort is a fort located in Amer, Rajasthan, India. Amer is a town with an area of 4 square kilometres located 11 kilometres from Jaipur, the capital of Rajasthan. Located high on a hill, it is the principal tourist attraction in Jaipur",
                Images = new List<CardImage> { new CardImage("https://lh6.googleusercontent.com/-x3SyPae8W9M/WkgtHG4JOaI/AAAAAAAA3Yo/N8MqNoPvxrEh5ls1dSgh-Ft8NCYlwXJvgCLIBGAYYCw/w100-h134-n-k-no/") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://en.wikipedia.org/wiki/Amer_Fort") },

            };
            return AmerFort.ToAttachment();

        }

        public static Attachment GetHawaMahal()
        {
            var video = new VideoCard
            {
                Title = "Hawa Mahal",
                Subtitle = $"Pink/red sandstone 'Palace of the Winds'     \r\r  ratings (4.4)",
                Text = "Hawa Mahal is a palace in Jaipur, India. It is constructed of red and pink sandstone. The palace sits on the edge of the City Palace, Jaipur, and extends to the zenana, or women's chambers",
                Image = new ThumbnailUrl
                {
                    Url = "https://lh4.googleusercontent.com/-GPqPsuQWNH8/V5hpba-Ig_I/AAAAAAAAU8s/gWbpJwLHVOYlFhSXcintcjX5AbWLr_ITACLIBGAYYCw/w100-h134-n-k-no/"
                },
                Media = new List<MediaUrl>
                {
                    new MediaUrl()
                    {
                        Url ="https://www.youtube.com/watch?v=nKlhbd79g_c"
                    }
                },
                Buttons = new List<CardAction>
                {
                    new CardAction()
                    {
                        Title ="More Info",
                        Type=ActionTypes.OpenUrl,
                        Value= "https://en.wikipedia.org/wiki/Hawa_Mahal"
                    }
                }
            };
            return video.ToAttachment();
        }
        public static Attachment GetCityPalaceJaipur()
        {
            var CityPalaceJaipur = new HeroCard
            {
                Title = "City Palace, Jaipur",
                Subtitle = "$Lavish 1700s palace complex & museum \r\r ratings (4.4)",
                Text = "City Palace, Jaipur, which includes the Chandra Mahal and Mubarak Mahal palaces and other buildings, is a palace complex in Jaipur, the capital of the Rajasthan state, India",
                Images = new List<CardImage> { new CardImage("https://lh5.googleusercontent.com/proxy/X7OXrxk1P9cyaNx8TKDECvx9Ry4_0An4R9ny7IBayDnIZ9rZ8gcAgkvlcR5bBedbHtgHaZN3IqeAn35j07BbVIHSembULqU=w100-h134-n-k-no") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://en.wikipedia.org/wiki/City_Palace,_Jaipur") }
            };

            return CityPalaceJaipur.ToAttachment();

        }
        public static Attachment GetJantarMantarJaipur()
        {
            var JantarMantarJaipur = new HeroCard
            {
                Title = "Jantar Mantar, Jaipur",
                Subtitle = "$Instruments for astronomical observation \r\r ratings (4.2)",
                Text = "The Jantar Mantar monument in Jaipur, Rajasthan is a collection of nineteen architectural astronomical instruments, built by the Rajput king Sawai Jai Singh II, and completed in 1734.",
                Images = new List<CardImage> { new CardImage("https://lh4.googleusercontent.com/proxy/oFps8oHrT_czBC-qL7an1au7THQKVFGcjAad8_O37sRX-_XX67Lh1V7G2LsJc-Hb-GtpCeAxf9Pz5u3e8cv797CDqHHssYWORm9UCrznfhfvJBEEchkx2mw_cjtadg3lQYx_thMwiLNZEQqlSlcAH22oOFQLUQ=w100-h134-n-k-no") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://en.wikipedia.org/wiki/Jantar_Mantar,_Jaipur") }
            };

            return JantarMantarJaipur.ToAttachment();
        }
        public static Attachment GetJaisalmerFort()
        {
            var JaisalmerFort = new HeroCard
            {
                Title = "Jaisalmer Fort",
                Subtitle = $"Majestic desert fort with ornate temples \r\r ratings (4.4)",
                Text = "Jaisalmer Fort is situated in the city of Jaisalmer, in the Indian state of Rajasthan. It is believed to be one of the very few “living forts” in the world, as nearly one fourth of the old city's population still resides within the fort",
                Images = new List<CardImage> { new CardImage("https://lh5.googleusercontent.com/-C8lmoyIoDpw/WE7fAsj-bUI/AAAAAAAAAfo/Da6lytgA5XUMUW86idnsEr6cmWHIgQ0ugCLIBGAYYCw/w100-h134-n-k-no/") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://en.wikipedia.org/wiki/Jaisalmer_Fort") }
            };

            return JaisalmerFort.ToAttachment();
        }
        public static Attachment GetJaigarhFort()
        {
            var JaigarhFort = new HeroCard
            {
                Title = "Jaigarh Fort",
                Subtitle = "$Historic hilltop fort with a musuem \r\r ratings (4.5)",
                Text = "Jaigarh Fort is situated on the promontory called the Cheel ka Teela of the Aravalli range; it overlooks the Amber Fort and the Maota Lake, near Amber in Jaipur, Rajasthan, India",
                Images = new List<CardImage> { new CardImage("https://lh5.googleusercontent.com/-TD6Tng5QpQc/V-G5Fmy2vlI/AAAAAAAAEMk/fbPGGhP_uJcPgICYZbPd-vD-zBHZ6VS0wCJkC/w100-h134-n-k-no/") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://en.wikipedia.org/wiki/Jaigarh_Fort") }
            };

            return JaigarhFort.ToAttachment();
        }
        public static Attachment GetRanthamboreNationalPark()
        {
            var RanthamboreNationalPark = new HeroCard
            {
                Title = "Ranthambore National Park",
                Subtitle = $"Large reserve best known for its tigers \r\r ratings (4.4)",
                Text = "Ranthambore National Park is a vast wildlife reserve near the town of Sawai Madhopur in Rajasthan, northern India. It is a former royal hunting ground and home to tigers, leopards and marsh crocodiles.",
                Images = new List<CardImage> { new CardImage("https://lh3.googleusercontent.com/-s-AGIhp4ZDk/WkerWexHh_I/AAAAAAAAUtY/mM1sJFvcYxQn1HtWMmPnX23Bri0JfWpmwCLIBGAYYCw/w100-h134-n-k-no/") },

                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://en.wikipedia.org/wiki/Ranthambore_National_Park") }
            };


            return RanthamboreNationalPark.ToAttachment();
        }


        public static Attachment GetJagMandir()
        {
            var JagMandir = new HeroCard
            {
                Title = "Jag Mandir",
                Subtitle = $"Island in Lake Pichola \r\r Ratings (4.4)",
                Text = "Jag Mandir is a palace built on an island in the Lake Pichola. It is also called the 'Lake Garden Palace' . The palace is located in Udaipur city in the Indian state of Rajasthan",
                Images = new List<CardImage> { new CardImage("https://www.makemytrip.com/travel-guide/media/dg_image/udaipur/Jag-Mandir-Palace.jpg") },

                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://en.wikipedia.org/wiki/Jag_Mandir") }
            };


            return JagMandir.ToAttachment();
        }
        public static Attachment GetFateh()
        {
            var Fateh = new HeroCard
            {
                Title = "Fateh Sagar Lake",
                Subtitle = $"Lake in India \r\r Ratings (4.6)",
                Text = "Fateh Sagar Lake is situated in the city of Udaipur in the Indian state of Rajasthan. It is an artificial lake named after Maharana Fateh Singh of Udaipur and Mewar, constructed north-west of Udaipur, to the north of Lake Pichola in the 1680s",
                Images = new List<CardImage> { new CardImage("https://www.makemytrip.com/travel-guide/media/dg_image/udaipur/Fateh-Sagar-Lake_wikimedia-commons_Shakti.jpg") },

                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://en.wikipedia.org/wiki/Fateh_Sagar_Lake") }
            };


            return Fateh.ToAttachment();
        }
        public static Attachment GetMonsoon()
        {
            var Monsoon = new HeroCard
            {
                Title = "Monsoon Palace",
                Subtitle = $"Palace in Kodiyat, India \r\r Ratings (4.3)",
                Text = "The Monsoon Palace, also known as the Sajjan Garh Palace, is a hilltop palatial residence in the city of Udaipur, Rajasthan in India, overlooking the Fateh Sagar Lake",
                Images = new List<CardImage> { new CardImage("https://image3.mouthshut.com/images/imagesp/925752694s.jpg") },

                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://en.wikipedia.org/wiki/Monsoon_Palace") }
            };


            return Monsoon.ToAttachment();
        }

        public static Attachment GetBagore()
        {
            var Bagore = new HeroCard
            {
                Title = "Bagore Ki Haveli Museum",
                Subtitle = $"Museum in Udaipur, India \r\r Ratings (4.4)",
                Text = "Museum in a traditional 18th-century mansion featuring art, costumes, restored rooms & more.",
                Images = new List<CardImage> { new CardImage("https://media-cdn.tripadvisor.com/media/photo-s/07/b9/49/42/bagore-ki-haveli.jpg") },

                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "http://www.wzccindia.com/") }
            };


            return Bagore.ToAttachment();
        }


        // Train details..........


        public static Attachment GetAC(string location,string vehical,string vehicalClass)
        {
            WebClient webClient = new WebClient();
            webClient.Headers.Set("content-type", "application/json");
            Dictionary<string, string> myvalues = new Dictionary<string, string>();
            myvalues.Add("location", location);
            myvalues.Add("class", vehicalClass);
            DataContractJsonSerializer myserializer = new DataContractJsonSerializer(typeof(Dictionary<string, string>));
            string myJsonString = (new JavaScriptSerializer()).Serialize(myvalues);

            string result2 = webClient.UploadString("http://localhost:8081/api2/", "POST", myJsonString);
            dynamic parsedArrayTwo = JsonConvert.DeserializeObject(result2);
            //JObject jo = JObject.Parse(result2);
            //JArray ab = JArray.Parse(parsedArrayTwo);
           // var cost = parsedArrayTwo[0].cost;
            var text = parsedArrayTwo[0].text;
            //  var title = parsedArrayTwo[0].ttitle;
            //  var subtitle = parsedArrayTwo[0].subtitle;
            var link = parsedArrayTwo[0].link;
            var button = parsedArrayTwo[0].button;
            var AC = new HeroCard
            {
                Title = "AC Train",
                Subtitle = $"     ",
                Text = $"{text}",
                Images = new List<CardImage> { new CardImage($"{link}") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Book Ticket", value: $"{button}") }
            };

            return AC.ToAttachment();
        }

        public static Attachment GetGeneral(string location, string vehical, string vehicalClass)
        {
            WebClient webClient = new WebClient();
            webClient.Headers.Set("content-type", "application/json");
            Dictionary<string, string> myvalues = new Dictionary<string, string>();
            myvalues.Add("location", location);
            myvalues.Add("class", vehicalClass);
            DataContractJsonSerializer myserializer = new DataContractJsonSerializer(typeof(Dictionary<string, string>));
            string myJsonString = (new JavaScriptSerializer()).Serialize(myvalues);

            string result2 = webClient.UploadString("http://localhost:8081/api2/", "POST", myJsonString);
            dynamic parsedArrayTwo = JsonConvert.DeserializeObject(result2);
            //JObject jo = JObject.Parse(result2);
            //JArray ab = JArray.Parse(parsedArrayTwo);
            
            var text = parsedArrayTwo[0].text;
            //  var title = parsedArrayTwo[0].ttitle;
            //  var subtitle = parsedArrayTwo[0].subtitle;
            var link = parsedArrayTwo[0].link;
            var button = parsedArrayTwo[0].button;
            var General = new HeroCard
            {
                Title = "General class",
                Subtitle = $"",
                Text = $"{text}",
                Images = new List<CardImage> { new CardImage($"{link}") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Book Ticket", value: $"{ button} ") }
            };

            return General.ToAttachment();
        }


        public static Attachment GetSleeper(string location, string vehical, string vehicalClass)
        {
            WebClient webClient = new WebClient();
            webClient.Headers.Set("content-type", "application/json");
            Dictionary<string, string> myvalues = new Dictionary<string, string>();
            myvalues.Add("location", location);
            myvalues.Add("class", vehicalClass);
            DataContractJsonSerializer myserializer = new DataContractJsonSerializer(typeof(Dictionary<string, string>));
            string myJsonString = (new JavaScriptSerializer()).Serialize(myvalues);

            string result2 = webClient.UploadString("http://localhost:8081/api2/", "POST", myJsonString);
            dynamic parsedArrayTwo = JsonConvert.DeserializeObject(result2);
            //JObject jo = JObject.Parse(result2);
            //JArray ab = JArray.Parse(parsedArrayTwo);
            var text = parsedArrayTwo[0].text;
            //  var title = parsedArrayTwo[0].ttitle;
            //  var subtitle = parsedArrayTwo[0].subtitle;
            var link = parsedArrayTwo[0].link;
            var button = parsedArrayTwo[0].button;
            var Sleeper = new HeroCard
            {
                Title = "Sleeper class",
                Subtitle = $"",
                Text = $"{text}",
                Images = new List<CardImage> { new CardImage($"{link}") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Book Ticket", value: $"{button}") }
            };

            return Sleeper.ToAttachment();
        }

        public static Attachment GetLowestFare(string location, string vehical,string vehicalclass)
        {
            WebClient webClient = new WebClient();
            webClient.Headers.Set("content-type", "application/json");
            Dictionary<string, string> myvalues = new Dictionary<string, string>();
            myvalues.Add("location", location);
            myvalues.Add("class", vehicalclass);
            DataContractJsonSerializer myserializer = new DataContractJsonSerializer(typeof(Dictionary<string, string>));
            string myJsonString = (new JavaScriptSerializer()).Serialize(myvalues);

            string result2 = webClient.UploadString("http://localhost:8081/api2/", "POST", myJsonString);
            dynamic parsedArrayTwo = JsonConvert.DeserializeObject(result2);
            var text = parsedArrayTwo[0].text;
            //  var title = parsedArrayTwo[0].ttitle;
            //  var subtitle = parsedArrayTwo[0].subtitle;
            var link = parsedArrayTwo[0].link;
            var button = parsedArrayTwo[0].button;
            var LowestFare = new HeroCard
            {
                Title = "Flights to Jaipur",
                Subtitle = $"Cheap Flight Tickets at Lowest Airfare",
                Text =$"{text}",
                Images = new List<CardImage> { new CardImage($"{link}") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Book Ticket", value: $"{button}") }
            };

            return LowestFare.ToAttachment();
        }

        // bus details.............

        public static Attachment GetBusAc(string location,string vehical,string vehicalclass)
        {
            WebClient webClient = new WebClient();
            webClient.Headers.Set("content-type", "application/json");
            Dictionary<string, string> myvalues = new Dictionary<string, string>();
            myvalues.Add("location", location);
            myvalues.Add("class", vehicalclass);
            DataContractJsonSerializer myserializer = new DataContractJsonSerializer(typeof(Dictionary<string, string>));
            string myJsonString = (new JavaScriptSerializer()).Serialize(myvalues);

            string result2 = webClient.UploadString("http://localhost:8081/api2/", "POST", myJsonString);
            dynamic parsedArrayTwo = JsonConvert.DeserializeObject(result2);
            var text = parsedArrayTwo[0].text;
            var title = parsedArrayTwo[0].title;
            var subtitle = parsedArrayTwo[0].subtitle;
            var link = parsedArrayTwo[0].link;
            var button = parsedArrayTwo[0].button;
            var BusAc = new HeroCard
            {
                Title = $"{title}",
                Subtitle = $"{subtitle}",
                Text = $"{text}",
                Images = new List<CardImage> { new CardImage("http://3.imimg.com/data3/OI/HB/MY-15185526/non-ac-busses-500x500.png") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Book Bus", value: "https://www.redbus.in/") }
            };

            return BusAc.ToAttachment();
        }

        public static Attachment GetNonAc(string location, string vehical, string vehicalclass)
        {
            WebClient webClient = new WebClient();
            webClient.Headers.Set("content-type", "application/json");
            Dictionary<string, string> myvalues = new Dictionary<string, string>();
            myvalues.Add("location", location);
            myvalues.Add("class", vehicalclass);
            DataContractJsonSerializer myserializer = new DataContractJsonSerializer(typeof(Dictionary<string, string>));
            string myJsonString = (new JavaScriptSerializer()).Serialize(myvalues);

            string result2 = webClient.UploadString("http://localhost:8081/api2/", "POST", myJsonString);
            dynamic parsedArrayTwo = JsonConvert.DeserializeObject(result2);
            var text = parsedArrayTwo[0].text;
            //  var title = parsedArrayTwo[0].ttitle;
            //  var subtitle = parsedArrayTwo[0].subtitle;
            var NonAc = new HeroCard
            {
                Title = "Non AC Bus",
                Subtitle = $"Affordable Prices",
                Text = $"{text}",
                Images = new List<CardImage> { new CardImage("https://akm-img-a-in.tosshub.com/indiatoday/images/story/201704/bmtc-story_647_041417093031.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://www.redbus.in/") }
            };

            return NonAc.ToAttachment();
        }

        // places...........................................

        public static Attachment GetRajasthan(string state,string statepl)
        {
            WebClient webClient = new WebClient();
            webClient.Headers.Set("content-type", "application/json");
            Dictionary<string, string> myvalues = new Dictionary<string, string>();
            myvalues.Add("state", state);
            myvalues.Add("place", statepl);
            DataContractJsonSerializer myserializer = new DataContractJsonSerializer(typeof(Dictionary<string, string>));
            string myJsonString = (new JavaScriptSerializer()).Serialize(myvalues);

            string result3 = webClient.UploadString("http://localhost:8081/api3/", "POST", myJsonString);
            dynamic parsedArrayTwo = JsonConvert.DeserializeObject(result3);
            var text = parsedArrayTwo[0].text;
            var title = parsedArrayTwo[0].title;
            var subtitle = parsedArrayTwo[0].subtitle;
            var link = parsedArrayTwo[0].link;
            var button = parsedArrayTwo[0].button;

            var Jaisalmer = new HeroCard
            {
                Title = $"{title}",
                Subtitle = $"{subtitle}",
                Text = $"{text}",
                Images = new List<CardImage> { new CardImage($"{link}") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: $"{button}") }
            };

            return Jaisalmer.ToAttachment();
        }

        // hotels..................................................

        public static Attachment Gethotel1(string state,string hotel)
        {
            var hotel1 = new HeroCard
            {
                Title = "Royal Palazzo      598/- ",
                Subtitle = $"per day 598/-",
                Text = " Address: Subhash Nagar Shopping Centre, Behind Doodh Mandi, Subhash Nagar, Jaipur, Rajasthan 302016 \r\r   Phone: 0141 406 2646   ",
                Images = new List<CardImage> { new CardImage("https://r1imghtlak.mmtcdn.com/igpf67d0n90g33um16saip6o0000.jpg?interpolation=progressive-bicubic&downsize=700:360&output-quality=50") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Book A Room", value: "https://www.googleadservices.com/pagead/aclk?sa=L&ai=DChcSEwi_qtTD1-vZAhWWGY8KHbUFC40YABAAGgJzYg&ohost=www.google.co.in&cid=CAASEuRoaitp6icAVBZG_R1J7bfoWQ&sig=AOD64_2av668aGCeuqk533ujo2rd_mFPZA&q=&ved=0ahUKEwjFv87D1-vZAhXMKo8KHV8NDJsQ0QwIJA&adurl=") }
            };

            return hotel1.ToAttachment();
        }

        public static Attachment Gethotel2()
        {
            var hotel2 = new HeroCard
            {
                Title = "Raghav Palace   ",
                Subtitle = $"per day  710/- ",
                Text = "Address: Subhash Nagar Shopping Centre, Behind Doodh Mandi, Subhash Nagar, Jaipur, Rajasthan 302016 \r\r   Phone: 0141 406 2646",
                Images = new List<CardImage> { new CardImage("http://resortraghavpalace.com/wp-content/uploads/2015/06/13.png") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Book A Room", value: "https://www.booking.com/hotel/in/raghav-palace.html") }
            };

            return hotel2.ToAttachment();
        }

        public static Attachment Gethotel3()
        {
            var hotel3 = new HeroCard
            {
                Title = "Hotel Metropolitan   ",
                Subtitle = $"per day  1,320/- ",
                Text = "Address: 26, Vivek Nagar, Station Road, Near Sindhi Camp, Jaipur, Rajasthan 302006 \r\r Phone: 0141 410 7878",
                Images = new List<CardImage> { new CardImage("https://s-ec.bstatic.com/images/hotel/max1024x768/778/77875498.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Book A Room", value: "http://hotelmetropolitanjaipur.business.site/") }
            };

            return hotel3.ToAttachment();
        }


        public static Attachment Gethotel4()
        {
            var hotel4 = new HeroCard
            {
                Title = "Souvenir Peppermint   ",
                Subtitle = $"per day 1,739/- ",
                Text = "Address: 6, Subhash Nagar, Near Science Park, Near Petrol Pump, Jaipur, Rajasthan 302016 \r\r Phone: 0141 669 3000",
                Images = new List<CardImage> { new CardImage("https://t-ec.bstatic.com/images/hotel/max500/813/8134101.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Book A Room", value: "http://www.souvenirhotels.com/") }
            };

            return hotel4.ToAttachment();
        }

        public static Attachment Gethotel5()
        {
            var hotel5 = new HeroCard
            {
                Title = "Kings corner    ",
                Subtitle = $"per day   1,897/-  ",
                Text = "Address: 555, Lane Number 6, Raja Park, Jaipur, Rajasthan 302004 \r\r Phone: 096020 20444",
                Images = new List<CardImage> { new CardImage("https://exp.cdn-hotels.com/hotels/12000000/11620000/11615800/11615726/99748949_z.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Book A Room", value: "http://www.hotelkingscorner.com/") }
            };

            return hotel5.ToAttachment();
        }

        public static Attachment Gethotel6()
        {
            var hotel6 = new HeroCard
            {
                Title = "Hari mahal palace   ",
                Subtitle = $"per day   2,161/- ",
                Text = "Address: Tirthraj, Jacob Road, Civil Lines, Jaipur, Rajasthan 302006 \r\r Phone: 0141 222 1399",
                Images = new List<CardImage> { new CardImage("https://media.weddingz.in/images/24e2e20f68733d4ab74d524e552208eb/21_42312PI.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Book A Room", value: "http://harimahalpalace.com/") }
            };

            return hotel6.ToAttachment();
        }

        public static Attachment Gethotel7()
        {
            var hotel7 = new HeroCard
            {
                Title = " Mahal Khandela    ",
                Subtitle = $"per day   2790/- ",
                Text = "Address: D-219B, Bhaskar Marg, Banipak, Jaipur, Rajasthan 302016 \r\r Phone: 095211 21153",
                Images = new List<CardImage> { new CardImage("https://r1imghtlak.mmtcdn.com/e402d222504811e48272daf4768ad8d9.jfif?interpolation=progressive-bicubic&downsize=700:360&output-quality=50") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Book A Room", value: "http://www.mahalkhandela.com/") }
            };

            return hotel7.ToAttachment();
        }


        public static Attachment Gethotel8()
        {
            var hotel8 = new HeroCard
            {
                Title = " Fortune select metropolitan     ",
                Subtitle = $" per day  2939/- ",
                Text = "Address: Near Nehru Sahkar Bhawan, C - Scheme, 22 Godam Circle, Jaipur, Rajasthan 302001 \r\r Phone: 0141 398 8442",
                Images = new List<CardImage> { new CardImage("https://ui.cltpstatic.com/places/hotels/2119/211920/images/img120094271624_w.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Book A Room", value: "https://www.fortunehotels.in/jaipur-fortune-select-metropolitan-dining.dhm.39?utm_source=google&utm_medium=organic&utm_term=jaipur-fortune-select-metropolitan-dining&utm_content=jaipur&utm_campaign=Listings") }
            };

            return hotel8.ToAttachment();
        }

        public static Attachment Gethotel9()
        {
            var hotel9 = new HeroCard
            {
                Title = " Golden Tulip  ",
                Subtitle = $"per day  3,200/- ",
                Text = "Address: M.I Road, Opposite GPO, Jaipur, Rajasthan 302001 \r\r Phone: 0141 426 8777",
                Images = new List<CardImage> { new CardImage("http://www.goldentulipjaipur.com/sites/default/files/styles/hero-image-slide/public/thumbnails/imagefinal_exterior_logo_3.jpg?itok=NF7Hwgfz") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Book A Room", value: "http://www.goldentulipjaipur.com/") }
            };

            return hotel9.ToAttachment();
        }

        public static Attachment Gethotel10()
        {
            var hotel10 = new HeroCard
            {
                Title = " Crowne Plaza   ",
                Subtitle = $"per day  4,187/- ",
                Text = "Address: Tonk Road, Sitapura Industrial Area, Jaipur, Rajasthan 302022 \r\r Phone: 0141 717 6666",
                Images = new List<CardImage> { new CardImage("http://crowneplaza.hotelsgroup.in/gallery/crowne-plaza-jaipur-tonk-road.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Book A Room", value: "https://www.ihg.com/crowneplaza/hotels/us/en/jaipur/jaitr/hoteldetail?cm_mmc=GoogleMaps-_-CP-_-IN-_-JAITR") }
            };

            return hotel10.ToAttachment();
        }


        //Forts........................

        public static Attachment GetAmber()
        {
            var Amber = new HeroCard
            {
                Title = " Amber Fort   ",
                Subtitle = $"  ratings (4.3)",
                Text = "Amber Fort, situated 11 kms from Jaipur, is a fort built with great artistic taste. Cradled on the top of a hill forming a beautiful reflection in Maotha Lake, it is popularly known as Amer Fort.",
                Images = new List<CardImage> { new CardImage("https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/Amer_Fort_Entrance.jpg/200px-Amer_Fort_Entrance.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://www.amberfort.org/") }
            };

            return Amber.ToAttachment();
        }

        public static Attachment GetAmar()
        {
            var Amar = new HeroCard
            {
                Title = " Amar Fort   ",
                Subtitle = $"  \r\r  ratings (4.5)",
                Text = "Address: Subhash Nagar Shopping Centre, Behind Doodh Mandi, Subhash Nagar, Jaipur, Rajasthan 302016 \r\r   /+Phone: 0141 406 2646",
                Images = new List<CardImage> { new CardImage("https://www.holidify.com/images/attr_square/2124.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://en.wikipedia.org/wiki/Amer_Fort") }
            };

            return Amar.ToAttachment();
        }


        // Jaipur cities.............


        public static Attachment Getnahar()
        {
            var nahar = new HeroCard
            {
                Title = " Nahargarh Fort  ",
                Subtitle = $"",
                Text = "Nahargarh Fort, situated on the outer skirts of Jaipur is an epitome of great architecture and planning. Drenched with rich past, the fort allows you a picturesque view of the entire city. Built in 1734, this grand architecture is a perfect way to begin the excursion of this pink city.",
                Images = new List<CardImage> { new CardImage("https://www.holidify.com/images/attr_square/2136.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://en.wikipedia.org/wiki/Nahargarh_Fort") }
            };

            return nahar.ToAttachment();
        }

        public static Attachment GetAlbert()
        {
            var Albert = new HeroCard
            {
                Title = " Albert Hall Museum  ",
                Subtitle = $"Museum in Jaipur",
                Text = "The Albert Hall Museum is a museum in Jaipur in Rajasthan, India. It is the oldest museum of the state and functions as the State museum of Rajasthan.",
                Images = new List<CardImage> { new CardImage("https://upload.wikimedia.org/wikipedia/commons/thumb/8/89/Albert_Hall_Museum_Night_View.jpg/1200px-Albert_Hall_Museum_Night_View.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://en.wikipedia.org/wiki/Albert_Hall_Museum") }
            };

            return Albert.ToAttachment();
        }

        public static Attachment GetParshuram()
        {
            var Parshuram = new HeroCard
            {
                Title = "Parshuram Mahadev",
                Subtitle = $"Hindu temple in Kotra, India \r\r Ratings (4.4)",
                Text = "Parshuram Mahadev Temple is a Shiva temple located at border of Pali and Rajsamand district of Rajasthan state in India . It is said that Parshuram, the sixth avatar of Lord Vishnu, made the cave with his axe and used to worship the lord Shiva at this serene place in the foothills of the Aravalis mountain range.",
                Images = new List<CardImage> { new CardImage("https://content.jdmagicbox.com/comp/pali-rajasthan/d5/9999p2932.2932.141220173743.e4d5/catalogue/parshuram-mahadev-temple-desuri-pali-rajasthan-temples-18cfd2f.jpg?interpolation=lanczos-none&output-format=jpg&resize=1024:370&crop=1024:370px;*,*") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://en.wikipedia.org/wiki/Parshuram_Mahadev_Templee") }
            };

            return Parshuram.ToAttachment();
        }
        public static Attachment GetJain()
        {
            var Jain = new HeroCard
            {
                Title = "Ranakpur Jain temple ",
                Subtitle = $"Jain temple in India \r\r Ratings (4.7)",
                Text = "The renowned Jain temple at Ranakpur is dedicated to Tirthankara Rishabhanatha. Dharna Shah, a local Jain businessperson, started construction of the temple in the 15th century following a divine vision",
                Images = new List<CardImage> { new CardImage("https://www.google.co.in/maps/uv?hl=en&pb=!1s0x3968200ebea75025:0xded51f5beb355524!2m22!2m2!1i80!2i80!3m1!2i20!16m16!1b1!2m2!1m1!1e1!2m2!1m1!1e3!2m2!1m1!1e5!2m2!1m1!1e4!2m2!1m1!1e6!3m1!7e115!4shttps://en.wikipedia.org/wiki/Ranakpur_Jain_temple!5sGoogle+Search&imagekey=!1e1!2shttps://upload.wikimedia.org/wikipedia/commons/thumb/0/0f/Jain_Temple_Ranakpur.jpg/440px-Jain_Temple_Ranakpur.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://en.wikipedia.org/wiki/Ranakpur_Jain_temple") }
            };

            return Jain.ToAttachment();
        }
        //...................................
        // chittorgarh......................

        public static Attachment GetRawatbhata()
        {
            var Rawatbhata = new HeroCard
            {
                Title = "Rawatbhata ",
                Subtitle = $"City in India",
                Text = "Rawatbhata is a City, Tehsil And a Nager Palika in Chittorgarh District in The Indian State of Rajasthan. It is 50 km From The Nearest City Kota. Rawatbhata is Connected To The Major Routes in Country Through Kota",
                Images = new List<CardImage> { new CardImage("https://upload.wikimedia.org/wikipedia/commons/thumb/6/6d/Jal_Mahal_in_Man_Sagar_Lake.jpg/1200px-Jal_Mahal_in_Man_Sagar_Lake.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://en.wikipedia.org/wiki/Rawatbhata") }
            };

            return Rawatbhata.ToAttachment();
        }
        public static Attachment GetJunagarh()
        {
            var Junagarh = new HeroCard
            {
                Title = "Junagarh Fort",
                Subtitle = $"Building complex in Bikaner  \r\r  ratings (4.5)",
                Text = "Junagarh Fort is a fort in the city of Bikaner, Rajasthan, India. The fort was originally called Chintamani and was renamed Junagarh or 'Old Fort' in the early 20th century when the ruling family moved to Lalgarh Palace outside the fort limits ",
                Images = new List<CardImage> { new CardImage("https://upload.wikimedia.org/wikipedia/commons/thumb/f/f0/Bikaner_fort_view_08.jpg/1200px-Bikaner_fort_view_08.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://en.wikipedia.org/wiki/Junagarh_Fort") }
            };

            return Junagarh.ToAttachment();
        }
        public static Attachment GetLalgarh()
        {
            var Lalgarh = new HeroCard
            {
                Title = "Lalgarh Palace",
                Subtitle = $"Palace in Bikaner  \r\r  ratings (4)",
                Text = $"Lalgarh Palace is a palace and heritage hotel in Bikaner in the Indian state of Rajasthan, built for Sir Ganga Singh, Maharaja of Bikaner, between 1902 and 1926.At present half of the place is home of Princess Siddhi Kumari and half has been converted into heritage hotel ",
                Images = new List<CardImage> { new CardImage("https://www.tourmyindia.com/images/lalgarh-palace-1.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://en.wikipedia.org/wiki/Lalgarh_Palace") }
            };

            return Lalgarh.ToAttachment();
        }
        public static Attachment GetPrachina()
        {
            var Prachina = new HeroCard
            {
                Title = "Prachina Museum",
                Subtitle = $"Historical place museum in Bikaner \r\r  ratings (4.3)",
                Text = $"Museum tracing Bikaner's cultural history with exhibits ranging from art to royal fashions & armor.",
                Images = new List<CardImage> { new CardImage("https://www.tourmyindia.com/images/prachina-museum-2.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "http://www.prachinamuseum.org/") }
            };

            return Prachina.ToAttachment();
        }
        public static Attachment GetWar()
        {
            var War = new HeroCard
            {
                Title = "War Memorial ",
                Subtitle = $"Museum in Bikaner\r\r  ratings (4.6)",
                Text = $"Museum tracing Bikaner's cultural history with exhibits ranging from art to royal fashions & armor.",
                Images = new List<CardImage> { new CardImage("https://s-media-cache-ak0.pinimg.com/originals/26/d4/fc/26d4fcc689c41eeabd9e9de682450813.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://en.wikipedia.org/wiki/War_memorial") }
            };

            return War.ToAttachment();
        }


        public static Attachment GetKota()
        {
            var Kota = new HeroCard
            {
                Title = "Kota",
                Subtitle = $"City in India   \r\r  ratings (4.5)",
                Text = "Kota is a city on the Chambal River in Rajasthan, northern India. Inside the Kota Garh, or City Palace, the Maharao Madho Singh Museum exhibits miniature paintings and antique weapons. South, along the river, tranquil Chambal Garden has a pond with crocodiles. Northeast, 18th-century Jagmandir Palace sits in the middle of Kishore Sagar Lake. ",
                Images = new List<CardImage> { new CardImage("http://www.luxurytrailsofindia.com/wp-content/uploads/2016/08/Kota-Rajasthan-1.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://en.wikipedia.org/wiki/Kota,_Rajasthan") }
            };

            return Kota.ToAttachment();
        }

        public static Attachment GetBikaner()
        {
            var Bikaner = new HeroCard
            {
                Title = "Bikaner",
                Subtitle = $"City of India     \r\r  ratings (4.4)",
                Text = "Bikaner is a city in the north Indian state of Rajasthan, east of the border with Pakistan. It's surrounded by the Thar Desert. The city is known for the 16th-century Junagarh Fort, a huge complex of ornate buildings and halls. Within the fort, the Prachina Museum displays traditional textiles and royal portraits. ",
                Images = new List<CardImage> { new CardImage("https://lh4.googleusercontent.com/-P4Pi7VifD6c/WK12bw-nyXI/AAAAAAAAB-w/E4o5lukgsSQkDg7yK_XkQ_rmF2OkQWwMQCLIBGAYYCw/w1064-h400-n-k-no/") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://en.wikipedia.org/wiki/Bikaner") }
            };

            return Bikaner.ToAttachment();
        }

        public static Attachment GetUdaipur()
        {
            var Udaipur = new HeroCard
            {
                Title = "Udaipur",
                Subtitle = $"City of India    \r\r  ratings (4.4)",
                Text = "Udaipur, formerly the capital of the Mewar Kingdom, is a city in the western Indian state of Rajasthan. Founded by Maharana Udai Singh II in 1559, it’s set around a series of artificial lakes and is known for its lavish royal residences. City Palace, overlooking Lake Pichola, is a monumental complex of 11 palaces, courtyards and gardens, famed for its intricate peacock mosaics.",
                Images = new List<CardImage> { new CardImage("http://tourism.rajasthan.gov.in/content/dam/rajasthan-tourism/english/city/explore/221.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://en.wikipedia.org/wiki/Udaipur") }
            };

            return Udaipur.ToAttachment();
        }



        public static Attachment GetChittorgarh()
        {
            var Chittorgarh = new HeroCard
            {
                Title = "Chittorgarh",
                Subtitle = $"City of India     \r\r  ratings (4.4)",
                Text = "Chittorgarh is a city and municipality in Rajasthan, northwest India. It’s known for the honey-colored, 7th-century Chittorgarh Fort, a vast hilltop complex with the remains of many temples and monuments. The 15th-century, 9-story Vijay Stambh (Tower of Victory) is built from red sandstone and white marble. It offers city views from the top, and it is lit up at night. Nearby is the Rajput-style Fateh.",
                Images = new List<CardImage> { new CardImage("https://lh4.googleusercontent.com/-o-k2VNWbPBk/Wn1-G34OwPI/AAAAAAAAKDQ/tVQWPfXxBaEJrUVW4KDH-ZyVM5oqbdiPwCLIBGAYYCw/w1064-h400-n-k-no/") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://en.wikipedia.org/wiki/Chittorgarh") }
            };

            return Chittorgarh.ToAttachment();
        }



        public static Attachment GetRanakpur()
        {
            var Ranakpur = new HeroCard
            {
                Title = "Ranakpur",
                Subtitle = $"City of India    \r\r  ratings (4.4)",
                Text = "Ranakpur is a village located in Desuri tehsil near Sadri town in the Pali district of Rajasthan in western India. It is located between Jodhpur and Udaipur. 162 km from Jodhpur and 91 km from Udaipur, in a valley on the western side of the Aravalli Range. The Nearest Railway Station to reach Ranakpur is Falna Railway station. Ranakpur is one among the most famous places to visit in Pali, Rajasthan",
                Images = new List<CardImage> { new CardImage("https://lh3.googleusercontent.com/-X5Hy-GyJaJ8/WWdoXKsiHvI/AAAAAAABMy4/A6e7IRcW_7oH-GYHgVEgRG89nQHPXEdUQCLIBGAYYCw/w1064-h400-n-k-no/") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://en.wikipedia.org/wiki/Ranakpur") }
            };

            return Ranakpur.ToAttachment();
        }

        public static Attachment GetJaipur()
        {
            var Jaipur = new HeroCard
            {
                Title = "Jaipur",
                Subtitle = $"City in India \r\r ratings (4.5)",
                Text = "Jaipur is the capital of India’s Rajasthan state. It evokes the royal family that once ruled the region and that, in 1727, founded what is now called the Old City, or “Pink City” for its trademark building color.",
                Images = new List<CardImage> { new CardImage("https://lh4.googleusercontent.com/-PSnezYlhvY0/Wm4gQUOcTLI/AAAAAAAALMw/8p4aXbcSrywylnHH2q3rwSsgqOmgwApJQCLIBGAYYCw/w1064-h400-n-k-no/") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://en.wikipedia.org/wiki/Jaipur") }
            };

            return Jaipur.ToAttachment();
        }
        public static Attachment GetGaradia()
        {
            var Jaipur = new HeroCard
            {
                Title = "Jaipur",
                Subtitle = $"City in India \r\r ratings (4.5)",
                Text = "Jaipur is the capital of India’s Rajasthan state. It evokes the royal family that once ruled the region and that, in 1727, founded what is now called the Old City, or “Pink City” for its trademark building color.",
                Images = new List<CardImage> { new CardImage("https://lh4.googleusercontent.com/-PSnezYlhvY0/Wm4gQUOcTLI/AAAAAAAALMw/8p4aXbcSrywylnHH2q3rwSsgqOmgwApJQCLIBGAYYCw/w1064-h400-n-k-no/") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "More Info", value: "https://en.wikipedia.org/wiki/Jaipur") }
            };

            return Jaipur.ToAttachment();
        }
    }
}


