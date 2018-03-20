using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;
using QnAMakerDialog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;


namespace Tourbot
    {
    [LuisModel("b2d0874e-b4e6-400d-ad55-373454797656", "26638e4172814ef5bd58a70308643b50")]


    [Serializable]
        public class SimpleLUIStourdialog : LuisDialog<object>
        {

            static public string location;
            static public string vehical;
            static public string vehicleClass;
            static public string state;
            static public string hotelname;
            static public string statepl;
        int count = 0;

        public const string Rajasthan = "Rajasthan";

        public const string Amer = "Amer Fort";
            public const string Hawa = "Hawa Mahal";
            public const string Palace = "City palace, Jaipur";
            public const string Mantar = "Jantar Mantar, Jaipur";
            public const string Jaisalmerf = "Jaisalmer Fort";
            public const string Jaigarh = "Jaigarh Fort";
            public const string Ranthambore = "Ranthambore National Park";

            public const string mumbai = "mumbai";
            public const string pune = "pune";
            public const string kolkata = "kolkata";
            public const string bangalore = "bangalore";
            public const string chennai = "chennai";
            public const string delhi = "delhi";
            public const string hedrabad = "hedrabad";
            public const string goa = "goa";

            public const string Train = "Train";
            public const string Plane = "Plane";
            public const string Bus = "Bus";
            public const string AC = "AC";
            public const string Sleeper = "Sleeper";
            public const string General = "General";
            public const string LowestFare = "LowestFare";
            public const string NonAc = "NonAc";
            public const string BusAc = "Ac";


            public const string hotel1 = "Royal Palazzo      598/-";
            public const string hotel2 = "Raghav Palace      710/-";
            public const string hotel3 = "Hotel Metropolitan      1,320/- ";
            public const string hotel4 = "Peppermint      1,739/-";
            public const string hotel5 = "Kings corner     1,897/-";
            public const string hotel6 = "Hari mahal palace      2,161/-";
            public const string hotel7 = "Mahal Khandela      2790/-";
            public const string hotel8 = "Fortune select metropolitan    2939/-";
            public const string hotel9 = "Golden Tulip    3,200/-";
            public const string hotel10 = "Crowne Plaza    4,187/-";


            public const string Bikaner = "Bikaner";
            public const string Udaipur = "Udaipur";
            public const string Chittorgarh = "Chittorgarh";
            public const string Jaipur = "Jaipur";
            public const string Ranakpur = "Ranakpur";
            public const string Jaisalmer = "Jaisalmer";

            public const string Amber = " Amber Fort";
            public const string Amar = " Amar Fort";

        public const string nahar = " Nahargarh Fort";
        public const string Garadia = " Garadia Mahadev Temple";
        
        public const string Albert = "Albert Hall Museum";
        public const string Kota = "Kota";

        public const string nahargarh = "Nahargarh Fort";
            public const string Jal = "Jal Mahal";
        
        public const string Nature = " Nature";
        public const string History = " History";
        public const string City = " City";

        public const string JagMandir = " Jag Mandir";
        public const string Fateh = "Fateh Sagar Lake";
        public const string Monsoon = "Monsoon Palace";
        public const string Bagore = " Bagore Ki Haveli Museum";

        public const string Junagarh = "Junagarh Fort ";
        public const string Lalgarh = "Lalgarh Palace ";
        public const string Prachina = "Prachina Museum ";
        public const string War = "War Memorial ";


        public const string Rawatbhata = "Rawatbhata";

        public const string Jain = "Ranakpur Jain temple";
        public const string Parshuram = "Parshuram Mahadev";



        private IEnumerable<string> options;

        public int activity1 { get; private set; }

        [LuisIntent("greeting")]
        private async Task greeting(IDialogContext context, LuisResult result)
        {

            if (count == 0)
            {
                await context.PostAsync($"Hello, What is your name??");
                count++;
                context.Wait(MessageReceivedName);
            }
            else
            {
                await context.PostAsync($"Hello, I am tourbot");
                context.Wait(MessageReceived);
            }
        }

        private async Task MessageReceivedName(IDialogContext context, IAwaitable<object> results)
        {
            var activity = await results as Activity;
            await context.PostAsync($"Hello, {activity.Text} how can I help you...");
            PromptDialog.Choice<string>(context, OnOptionIner,
                              new List<string>() { Nature, History, City },
                               $"From this what is your area of Interest...{activity.Text}",
                               "Not a valid option",
                               3,
                               promptStyle: PromptStyle.Auto);

        }

        private async Task OnOptionIner(IDialogContext context, IAwaitable<string> result)
        {
            string optionSelected = await result;
            switch (optionSelected)
            {
                case Nature:
                    this.GetNaTURE(context);
                    break;
                case City:
                    this.GetCity(context);
                    break;
                case History:
                    this.GetHistory(context);
                    break;
            }
        }

        private void GetNaTURE(IDialogContext context)
        {
            PromptDialog.Choice<string>(context, this.DisplayNatureCard, new List<String>() { Ranthambore, Garadia, Fateh }, "Plz select among this option to view",
                "Ooops, what you wrote is not a valid option, please try again", 3, promptStyle: PromptStyle.Auto);

        }
        private void GetCity(IDialogContext context)
        {
            PromptDialog.Choice<string>(context, this.DisplayNatureCard, new List<String>() { Bikaner, Udaipur, Chittorgarh, Jaipur, Ranakpur, Jaisalmer, Kota }, "Plz select among this option to view",
                "Ooops, what you wrote is not a valid option, please try again", 3, promptStyle: PromptStyle.Auto);

        }
        private void GetHistory(IDialogContext context)
        {
            PromptDialog.Choice<string>(context, this.DisplayNatureCard, new List<String>() { Palace, Amer, }, "Select your option",
                "Ooops, what you wrote is not a valid option, please try again", 3, promptStyle: PromptStyle.Auto);

        }
        public async Task DisplayNatureCard(IDialogContext context, IAwaitable<string> result)
        {
            var selectedCard = await result;

            var message = context.MakeMessage();

            var attachment = GetSelectCard(selectedCard);
            message.Attachments.Add(attachment);

            await context.PostAsync(message);

            context.Wait(MessageReceived);
        }
        private static Attachment GetSelectCard(string selectedCard)
        {
            // data to be added.............
            switch (selectedCard)
            {

                case Ranthambore:
                    return Data.GetRanthamboreNationalPark();

                case Garadia:
                    return Data.GetGaradia();

                case Fateh:
                    return Data.GetFateh();

                case Bikaner:
                    return Data.GetBikaner();

                case Udaipur:
                    return Data.GetUdaipur();

                case Chittorgarh:
                    return Data.GetChittorgarh();

                case Jaipur:
                    return Data.GetJaipur();

                case Ranakpur:
                    return Data.GetRanakpur();

                case Jaisalmer:
                    return Data.GetJaipur();

                case Kota:
                    return Data.GetKota();

                case Palace:
                    return Data.GetCityPalaceJaipur();
                case Amer:
                    return Data.GetAmerFort();
                default:
                    return Data.GetGaradia();
            }

        }
        [LuisIntent("visit")]

        public async Task visit(IDialogContext context, LuisResult result)
        {
            EntityRecommendation rec;
            Boolean a = result.TryFindEntity("places", out rec);
            if (a)
            {
                if (rec.Entity.Contains("rajasthan") || rec.Entity.Contains("raja"))
                {
                    state = Rajasthan;
                    PromptDialog.Choice<string>(context,
                                OnOptionRaja,
                               new List<string>() { Jaisalmer, Jaipur, Bikaner, Udaipur, Chittorgarh, Ranakpur, Kota },
                                $"Which places do you want to Visit in rajasthan...",
                                "Not a valid option",
                                3,
                                promptStyle: PromptStyle.Auto);
                }
                if (rec.Entity.Contains("jaipur"))
                {
                    state = Jaipur;
                    PromptDialog.Choice<string>(context,
                                   OnOptionRaja,
                                  new List<string>() { Amer, Hawa, Mantar, Palace, Jaisalmerf, Jaigarh, nahar, Garadia },
                                   "Which places do you want to Visit in jaipur.",
                                   "Not a valid option",
                                   3,
                                   promptStyle: PromptStyle.Auto);

                }
                //Udaipur.....................
                if (rec.Entity.Contains("udaipur"))
                {
                    PromptDialog.Choice<string>(context,
                                   OnOptionRaja,
                                  new List<string>() { JagMandir, Fateh, Monsoon, Bagore },
                                   "Places to Visit in Udaipur...",
                                   "Not a valid option",
                                   3,
                                   promptStyle: PromptStyle.Auto);


                }

                if (rec.Entity.Contains("bikaner"))
                {
                    PromptDialog.Choice<string>(context,
                                   OnOptionRaja,
                                  new List<string>() { Junagarh, Lalgarh, Prachina, War },
                                   "Places to Visit in Bikaner...",
                                   "Not a valid option",
                                   3,
                                   promptStyle: PromptStyle.Auto);


                }
                if (rec.Entity.Contains("chittorgarh"))
                {
                    PromptDialog.Choice<string>(context,
                                   OnOptionRaja,
                                  new List<string>() { Rawatbhata },
                                   "Places to Visit in Chittorgarh...",
                                   "Not a valid option",
                                   3,
                                   promptStyle: PromptStyle.Auto);


                }
                if (rec.Entity.Contains("ranakpur"))
                {
                    PromptDialog.Choice<string>(context,
                                   OnOptionRaja,
                                  new List<string>() { Jain, Parshuram },
                                   "Places to Visit in Ranakpur...",
                                   "Not a valid option",
                                   3,
                                   promptStyle: PromptStyle.Auto);


                }


                if (rec.Entity.Contains("kota"))
                {
                    PromptDialog.Choice<string>(context,
                                   OnOptionRaja,
                                  new List<string>() { Garadia },
                                   "Places to Visit in Kota...",
                                   "Not a valid option",
                                   3,
                                   promptStyle: PromptStyle.Auto);


                }
            }
            else
            {

                PromptDialog.Choice<string>(context,
                                OnOptionRaja,
                               new List<string>() { Jaisalmer, Jaipur, Bikaner, Udaipur, Chittorgarh, Ranakpur, Kota },
                                "Best Places in Rajasthan....",
                                "Not a valid option",
                                3,
                                promptStyle: PromptStyle.Auto);

            }
        }

        public async Task OnOptionRaja(IDialogContext context, IAwaitable<string> result)
        {
            var selectedCard = await result;

            var message = context.MakeMessage();

            var attachment = GetSelectdRajasthan(selectedCard);
            message.Attachments.Add(attachment);

            await context.PostAsync(message);

            context.Wait(MessageReceived);
        }

        private static Attachment GetSelectdRajasthan(string selectedCard)
        {
            switch (selectedCard)
            {
                case Jaisalmer:
                    statepl = Jaisalmer;
                    return Data.GetRajasthan(state,statepl);
                case Jaipur:
                    statepl = Jaipur;
                    return Data.GetRajasthan(state,statepl);
                case Bikaner:
                    statepl = Bikaner;
                    return Data.GetRajasthan(state, statepl);
                case Udaipur:
                    statepl = Udaipur;
                    return Data.GetRajasthan(state, statepl);
                case Chittorgarh:
                    statepl = Chittorgarh;
                    return Data.GetRajasthan(state, statepl); ;
                case Ranakpur:
                    statepl = Ranakpur;
                    return Data.GetRajasthan(state, statepl);
                case Kota:
                    statepl = Kota;
                    return Data.GetRajasthan(state, statepl);
                case JagMandir:
                    statepl = JagMandir;
                    return Data.GetRajasthan(state, statepl);
                case Fateh:
                    statepl = Fateh;
                    return Data.GetRajasthan(state, statepl);
                case Monsoon:
                    statepl = Monsoon;
                    return Data.GetRajasthan(state, statepl);
                case Bagore:
                    statepl = Bagore;
                    return Data.GetRajasthan(state, statepl);
                case Amer:
                    statepl = Amer;
                    return Data.GetRajasthan(state, statepl);
                case Hawa:
                    statepl = Hawa;
                    return Data.GetRajasthan(state, statepl);
                case Mantar:
                    statepl = Mantar;
                    return Data.GetRajasthan(state, statepl);
                case Palace:
                    statepl = Palace;
                    return Data.GetRajasthan(state, statepl);
                case Jaisalmerf:
                    statepl = Jaisalmerf;
                    return Data.GetRajasthan(state, statepl);
                case Jaigarh:
                    statepl = Jaigarh;
                    return Data.GetRajasthan(state, statepl);
                case nahar:
                    statepl = nahar;
                    return Data.GetRajasthan(state, statepl);
                case Garadia:
                    statepl = Garadia;
                    return Data.GetRajasthan(state, statepl);
                
                case Junagarh:
                    return Data.GetJunagarh();
                case Lalgarh:
                    return Data.GetLalgarh();
                case Prachina:
                    return Data.GetPrachina();
                case War:
                    return Data.GetWar();
                case Jain:
                    return Data.GetJain();
                case Parshuram:
                    return Data.GetParshuram();
                case Rawatbhata:
                    return Data.GetRawatbhata();

                default:
                    return Data.GetRajasthan(state,statepl);
            }
        }

        public void Start(IDialogContext context)
        {
            context.Wait(this.MessageReceivedAsync);
        }

            [LuisIntent("reach")]
            public async Task reach(IDialogContext context, LuisResult result)
            {
                EntityRecommendation rec;
                Boolean a = result.TryFindEntity("places", out rec);
                if (a)
                {
                    if (rec.Entity.Contains("jaipur") || rec.Entity.Contains("pink city"))
                    {
                        IEnumerable<string> optionsit1 = new List<string> { mumbai, pune, kolkata, bangalore, chennai, delhi, hedrabad, goa };
                        PromptDialog.Choice<string>(
                        context,
                        this.Displayplace,
                        optionsit1,
                        "where are you from?",
                        "Ooops, what you wrote is not a valid option, please try again",
                        3,
                         promptStyle: PromptStyle.Auto);

                    }
                if (rec.Entity.Contains("rajasthan"))
                {
                    IEnumerable<string> optionsit1 = new List<string> { mumbai, pune, kolkata, bangalore, chennai, delhi, hedrabad, goa };
                    PromptDialog.Choice<string>(
                    context,
                    this.Displayplace,
                    optionsit1,
                    "where are you from?",
                    "Ooops, what you wrote is not a valid option, please try again",
                    3,
                     promptStyle: PromptStyle.Auto);

                }
            }
            }
 
            public async virtual Task MessageReceivedAsync(IDialogContext context, IAwaitable<IMessageActivity> result)
            {
                var message = await result;

                PromptDialog.Choice<string>(
                    context,
                    this.Displayplace,
                    options,
                    "Which department you want to know?",
                    "Ooops, what you wrote is not a valid option, please try again",
                    3,
                    PromptStyle.PerLine);
            }


        private async Task Displayplace(IDialogContext context, IAwaitable<string> result)
        {
            string optionSelected = await result;
            switch (optionSelected)
            {
                case mumbai:
                    String a = "Mumbai";
                    
                    this.Getvehical(context, a);
                    break;
                case pune:
                    String b = "Pune";
                    this.Getvehical(context, b);
                    break;
                case kolkata:
                    String c = "Kolkata";
                    this.Getvehical(context, c);
                    break;
                case bangalore:
                    String d = "Bangolre";
                    this.Getvehical(context, d);
                    break;
                case chennai:
                    String e = "Chennai";
                    this.Getvehical(context, e);
                    break;
                case delhi:
                    String f = "Delhi";
                    this.Getvehical(context, f);
                    break;
                case hedrabad:
                    String g = "Hedrabad";
                    this.Getvehical(context, g);
                    break;
                case goa:
                    String h = "Goa";
                    this.Getvehical(context, h);
                    break;
            }
        }
        private void Getvehical(IDialogContext context, String abc)
        {
             location = abc;
            PromptDialog.Choice<string>(
              context,
              this.DisplayTravel,
              new List<String>() { Train, Plane, Bus },
             "Mode of Transport from " + location,
              "Ooops, what you wrote is not a valid option, please try again",
              3,
               promptStyle: PromptStyle.Auto);
        }

        private async Task DisplayTravel(IDialogContext context, IAwaitable<string> result)
        {
            string optionSelected = await result;
            switch (optionSelected)
            {
                case Train:
                    vehical = Train;
                    this.GetTr(context);
                    break;
                case Plane:
                    vehical = Plane;
                    this.GetPl(context);
                    break;
                case Bus:
                    vehical = Bus;
                    this.GetBu(context);
                    break;
            }
        }
        private async void GetTr(IDialogContext context)
        {
            PromptDialog.Choice<string>(context, this.DisplayTrain, new List<String>() { AC, Sleeper, General }, " In Which one would you Travel?",
               "Ooops, what you wrote is not a valid option, please try again", 3, promptStyle: PromptStyle.Auto);
        }
        private async void GetPl(IDialogContext context)
        {
            PromptDialog.Choice<string>(context, this.DisplayFlight, new List<String>() { LowestFare }, "In Which one would you Travel?",
                 "Ooops, what you wrote is not a valid option, please try again", 3, promptStyle: PromptStyle.Auto);
        }
        private async void GetBu(IDialogContext context)
        {
            PromptDialog.Choice<string>(context, this.DisplayBus, new List<String>() { BusAc, NonAc }, "In Which one would you Travel?",
               "Ooops, what you wrote is not a valid option, please try again", 3, promptStyle: PromptStyle.Auto);
        }
        public async Task DisplayTrain(IDialogContext context, IAwaitable<string> result)
        {
            var selectedCard = await result;

            var message = context.MakeMessage();

            var attachment = GetSelectdTrain(selectedCard);
            message.Attachments.Add(attachment);

            await context.PostAsync(message);

            context.Wait(MessageReceived);
        }
        private static Attachment GetSelectdTrain(string selectedCard)
        {
            switch (selectedCard)
            {
                case AC:
                    vehicleClass = AC;
                    return Data.GetAC(location,vehical,vehicleClass);
                case Sleeper:
                    vehicleClass = Sleeper;
                    return Data.GetSleeper(location,vehical,vehicleClass);
                case General:
                    vehicleClass = General;
                    return Data.GetGeneral(location,vehical,vehicleClass);
                default:
                    return Data.GetAC(location, vehical, vehicleClass);
            }
        }
        public async Task DisplayFlight(IDialogContext context, IAwaitable<string> result)
        {
            var selectedCard = await result;

            var message = context.MakeMessage();

            var attachment = GetSelectdFlight(selectedCard);
            message.Attachments.Add(attachment);

            await context.PostAsync(message);

            context.Wait(MessageReceived);
        }
        private static Attachment GetSelectdFlight(string selectedCard)
        {
            switch (selectedCard)
            {
                case LowestFare:
                    vehicleClass = LowestFare;
                    return Data.GetLowestFare(location, vehical, vehicleClass);
                default:
                    return Data.GetLowestFare(location, vehical, vehicleClass);
            }
            // Data to be add...........

        }
        public async Task DisplayBus(IDialogContext context, IAwaitable<string> result)
        {
            var selectedCard = await result;

            var message = context.MakeMessage();

            var attachment = GetSelectdBus(selectedCard);
            message.Attachments.Add(attachment);

            await context.PostAsync(message);

            context.Wait(MessageReceived);
        }
        private static Attachment GetSelectdBus(string selectedCard)
        {
            switch (selectedCard)
            {
                case BusAc:
                    vehicleClass = BusAc;
                    return Data.GetBusAc(location,vehical,vehicleClass);
                case NonAc:
                    vehicleClass = NonAc;
                    return Data.GetNonAc(location, vehical, vehicleClass);
                default:
                    vehicleClass = NonAc;
                    return Data.GetBusAc(location, vehical, vehicleClass);
            }
        }

        [LuisIntent("hotel")]
        public async Task hotel(IDialogContext context, LuisResult result)
        {
            EntityRecommendation rec;
            Boolean a = result.TryFindEntity("places", out rec);
            if (a)
            {
                if (rec.Entity.Contains("jaipur") || rec.Entity.Contains("pink city"))
                {
                    state = Jaipur;
                    await context.PostAsync($"what is your budget for hotel..plz enter amount only in digit");
                    context.Wait(MessageReceivedhotel);
                }
                if (rec.Entity.Contains("Jaisalmer"))
                {
                    await context.PostAsync($"what is your budget for hotel..plz enter amount only in digit");
                    context.Wait(MessageReceivedhotel);
                }
                if (rec.Entity.Contains(" Bikaner"))
                {
                    await context.PostAsync($"what is your budget for hotel..plz enter amount only in digit");
                    context.Wait(MessageReceivedhotel);
                }
                if (rec.Entity.Contains(" Udaipur"))
                {
                    await context.PostAsync($"what is your budget for hotel..plz enter amount only in digit");
                    context.Wait(MessageReceivedhotel);
                }
                 if (rec.Entity.Contains("Chittorgarh"))
                {
                    await context.PostAsync($"what is your budget for hotel..plz enter amount only in digit");
                    context.Wait(MessageReceivedhotel);
                }
                if (rec.Entity.Contains("Ranakpur"))
                {
                    await context.PostAsync($"what is your budget for hotel..plz enter amount only in digit");
                    context.Wait(MessageReceivedhotel);
                }
                // Jaisalmer, Jaipur, Bikaner, Udaipur, Chittorgarh, Ranakpur
            }
        }

        private async Task MessageReceivedhotel(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var activity = await result;
            this.activity1 = int.Parse(activity.Text);
             
            if (activity1 < 1000)
            {
                PromptDialog.Choice<string>(context, this.DisplayHotel, new List<String>() { hotel1, hotel2 }, "Which one do you want to know?",
                "Ooops, what you wrote is not a valid option, please try again", 3, promptStyle: PromptStyle.Auto);
            }
            else if (activity1 < 2000)
            {
                PromptDialog.Choice<string>(context, this.DisplayHotel, new List<String>() { hotel3, hotel4, hotel5 }, "Which one do you want to know?",
                "Ooops, what you wrote is not a valid option, please try again", 3, promptStyle: PromptStyle.Auto);
            }
            else if (activity1 < 3000)
            {
                PromptDialog.Choice<string>(context, this.DisplayHotel, new List<String>() { hotel6, hotel7, hotel8 }, "Which one do you want to know?",
                "Ooops, what you wrote is not a valid option, please try again", 3, promptStyle: PromptStyle.Auto);
            }
            else
            {
                PromptDialog.Choice<string>(context, this.DisplayHotel, new List<String>() { hotel9, hotel10 }, "Which one do you want to know?",
               "Ooops, what you wrote is not a valid option, please try again", 3, promptStyle: PromptStyle.Auto);
            }

        }

        public async Task DisplayHotel(IDialogContext context, IAwaitable<string> result)
        {
            var selectedCard = await result;

            var message = context.MakeMessage();

            var attachment = GetSelectdHotel(selectedCard);
            message.Attachments.Add(attachment);

            await context.PostAsync(message);

            context.Wait(MessageReceived);
        }
        private static Attachment GetSelectdHotel(string selectedCard)
        {
            switch (selectedCard)
            {
                case hotel1:
                    hotelname = hotel1;
                    return Data.Gethotel1(state,hotelname);
                case hotel2:
                    return Data.GetHawaMahal();
                default:
                    return Data.GetAmerFort();
            }
        }
        public async Task DisplayHotel2(IDialogContext context, IAwaitable<string> result)
        {
            var selectedCard = await result;

            var message = context.MakeMessage();

            var attachment = GetSelectdHotel2(selectedCard);
            message.Attachments.Add(attachment);

            await context.PostAsync(message);

            context.Wait(MessageReceived);
        }
        private static Attachment GetSelectdHotel2(string selectedCard)
        {
            switch (selectedCard)
            {
                case hotel3:
                    return Data.GetAmerFort();
                case hotel4:
                    return Data.GetHawaMahal();
                case hotel5:
                    return Data.GetHawaMahal();
                default:
                    return Data.GetAmerFort();
            }
        }
        public async Task DisplayHotel3(IDialogContext context, IAwaitable<string> result)
        {
            var selectedCard = await result;

            var message = context.MakeMessage();

            var attachment = GetSelectdHotel3(selectedCard);
            message.Attachments.Add(attachment);

            await context.PostAsync(message);

            context.Wait(MessageReceived);
        }
        private static Attachment GetSelectdHotel3(string selectedCard)
        {
            switch (selectedCard)
            {
                case hotel6:
                    return Data.Gethotel6();
                case hotel7:
                    return Data.Gethotel7();
                case hotel8:
                    return Data.GetHawaMahal();
                default:
                    return Data.GetAmerFort();
            }
        }
        public async Task DisplayHotel4(IDialogContext context, IAwaitable<string> result)
        {
            var selectedCard = await result;

            var message = context.MakeMessage();

            var attachment = GetSelectdHotel4(selectedCard);
            message.Attachments.Add(attachment);

            await context.PostAsync(message);

            context.Wait(MessageReceived);
        }
        private static Attachment GetSelectdHotel4(string selectedCard)
        {
            switch (selectedCard)
            {
                case hotel9:
                    return Data.GetAmerFort();
                case hotel10:
                    return Data.GetHawaMahal();

                default:
                    return Data.GetAmerFort();
            }
        }


        [LuisIntent("nighttime")]
        public async Task nighttime(IDialogContext context, LuisResult result)
        {
            EntityRecommendation rec;
            Boolean a = result.TryFindEntity("places", out rec);
            if (a)
            {
                PromptDialog.Choice<string>(context,
                                OnOptionnight,
                               new List<string>() { Amber, Amar },
                                " Which would you like to visit at night",
                                "Not a valid option",
                                3,
                                promptStyle: PromptStyle.Auto);
            }
            else
            {
                await context.PostAsync($"At from your location you should stay at home.");
                context.Wait(MessageReceived);
            }
        }
        public async Task OnOptionnight(IDialogContext context, IAwaitable<string> result)
        {
            var selectedCard = await result;
            var message = context.MakeMessage();

            var attachment = GetSelectedNight(selectedCard);
            message.Attachments.Add(attachment);

            await context.PostAsync(message);

            context.Wait(MessageReceived);
        }
        private static Attachment GetSelectedNight(string selectedCard)
        {
            switch (selectedCard)
            {
                case Amar:
                    return Data.GetHawaMahal();
                case Amber:
                    return Data.GetHawaMahal();
                case Amer:
                    return Data.GetAmerFort();
                case Hawa:
                    return Data.GetHawaMahal();
                case Albert:
                    return Data.GetHawaMahal();
                case nahargarh:
                    return Data.GetHawaMahal();
                case Jal:
                    return Data.GetHawaMahal();
                case Palace:
                    return Data.GetCityPalaceJaipur();
                case Mantar:
                    return Data.GetJaigarhFort();
                case Jaisalmer:
                    return Data.GetJaisalmerFort();
                case Jaigarh:
                    return Data.GetJantarMantarJaipur();
                case Ranthambore:
                    return Data.GetRanthamboreNationalPark();
                case AC:
                    return Data.GetAC(location, vehical, vehicleClass);
                case Sleeper:
                    return Data.GetSleeper(location, vehical, vehicleClass);
                case General:
                    return Data.GetGeneral(location, vehical, vehicleClass);
                default:
                    return Data.GetAmerFort();
            }
        }

        [LuisIntent("daytime")]
        public async Task daytime(IDialogContext context, LuisResult result)
        {
            EntityRecommendation rec;
            Boolean a = result.TryFindEntity("places", out rec);
            if (a)
            {
                if (rec.Entity.Contains("rajasthan"))
                {
                    PromptDialog.Choice<string>(context, OnOptionday, new List<string>() { nahargarh, Jal, Albert, Mantar },
                         "Which places do you know about pranav", "Not a valid option", 3, promptStyle: PromptStyle.Auto);
                }
                else if (rec.Entity.Contains("jaipur"))
                {
                    PromptDialog.Choice<string>(context, OnOptionday, new List<string>() { nahargarh, Jal, Albert, Mantar },
                       "Which places do you know about pranav", "Not a valid option", 3, promptStyle: PromptStyle.Auto);
                }
                else
                {
                    PromptDialog.Choice<string>(context, OnOptionday, new List<string>() { nahargarh, Jal, Albert, Mantar },
                         "Which places do you know about pranav", "Not a valid option", 3, promptStyle: PromptStyle.Auto);
                }
            }
            else
            {
                PromptDialog.Choice<string>(context, OnOptionday, new List<string>() { nahargarh, Jal, Albert, Mantar },
                         "Which places do you know about pranav", "Not a valid option", 3, promptStyle: PromptStyle.Auto);
            }
        }
        public async Task OnOptionday(IDialogContext context, IAwaitable<string> result)
        {
            var selectedCard = await result;
            var message = context.MakeMessage();

            var attachment = GetSelectedNight(selectedCard);
            message.Attachments.Add(attachment);

            await context.PostAsync(message);

            context.Wait(MessageReceived);
        }

        [LuisIntent("None")]

            public async Task None(IDialogContext context, IAwaitable<IMessageActivity> message, LuisResult result)
            {

            var activity = await message as Activity;
                await context.Forward(new Qna(),this.AfterQna,activity,CancellationToken.None);
            context.Wait(MessageReceived);
        }

        private async Task AfterQna(IDialogContext context, IAwaitable<object> result)
        {
            context.Wait(MessageReceived);
        }
    }
    }