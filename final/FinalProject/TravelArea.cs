using System;


public class TravelArea : AreaStudy
{
    public TravelArea() : base("Travel", "Area focused on travel vocabulary and topics.")

    {
        GetLessons().Add(new Lesson(

            1,
            "How to Plan the Perfect Road Trip",
            "This guide offers practical tips for planning a safe, enjoyable, and flexible road trip",
            "Planning a road trip requires careful preparation to make the most of the journey. First, choose \n" +
            "a route by using maps, online searches, or recommendations from others, and avoid driving more than\n" +
            "seven hours a day to stay safe. Next, decide where you’ll sleep each night — whether in hotels or a \n" +
            "camper — and book in advance to save money. Finally, allow extra time in your schedule so you can take\n" +
            "detours, enjoy scenic routes, or explore unexpected places along the way.",
             new List<string>
            {
                "camper - /ˈkæmpər/",
                "detour - /ˈdiːtʊr/",
                "scenery - /ˈsiːnəriː/"

            },
            new Dictionary<string, string>
            {
                {"We took a short ______ to visit a nearby waterfall", "detour"}
            }

        ));

        GetLessons().Add(new Lesson(

            2,
            "Places to Visit in Brazil Beyond Rio",
            "This text highlights three fascinating destinations in Brazil beyond Rio de Janeiro,\n" +
            "each offering unique cultural and natural experiences.",
            "Beyond Rio, Brazil offers incredible destinations to explore. In Manaus, located in \n" +
            "the Amazon region, visitors can see the historic Teatro Amazonas and take trips into \n" +
            "the rainforest, including to the Meeting of Waters, where two rivers flow side by side \n" +
            "without mixing. Salvador, in the northeast, is rich in Afro-Brazilian culture, with vibrant music,\n" +
            "food, and colorful colonial architecture in its historic Pelourinho district. For a more remote\n" +
            "adventure, Fernando de Noronha features stunning beaches like Praia do Sancho, where visitors must\n" +
            "descend a 70-meter cliff using a ladder or arrive by boat to experience its natural beauty.",
            new List<string>
            {
                "ladder - /ˈlædər/",
                "rainforest - /ˈreɪnˌfɒrɪst/",
                "explore - /ɪkˈsplɔr/"

            },
            new Dictionary<string, string>
            {
                {"He put the _____ against the wall and made sure it was stable.", "ladder"}
            }

        ));

        GetLessons().Add(new Lesson(

            3,
            "Lost and Found: The Secrets Inside Unclaimed Luggage",
            "This article reveals the surprising journey and strange discoveries inside unclaimed airline luggage.",
            "Each year, thousands of airline bags are lost, and if no one claims them after three weeks, they are\n" +
            "considered permanently lost. In the U.S., many of these bags are sent to Unclaimed Baggage, a company \n" +
            "that resells their contents. While most contain everyday items, some include bizarre surprises like a book\n" +
            "about exorcism, a magician’s hat, and even a freeze-dried chicken’s foot. One suitcase was found to be filled\n" +
            "entirely with rocks. Though unusual items aren't sold, valuable finds like diamond rings and luxury goods can be\n" +
            "purchased on the company's website. The article advises travelers to pack wisely — in case their luggage is never claimed.",
            new List<string>
            {
                "freeze-dried - /ˈfriːz draɪd/",
                "exorcism - /ˈeksɔːrsɪzəm/",
                "claim - /kleɪm/"

            },
            new Dictionary<string, string>
            {
                {"This granola has nuts and ________ berries", "freeze-dried"}
            }

        ));
        GetLessons().Add(new Lesson(

            4,
            "Why Planning a Vacation May Be Good for Our Health",
            "This article explains how planning a vacation can boost mental well-being even before the trip begins.",
            "While living in the moment is important, imagining future vacations can also benefit our mental health. \n" +
            "According to researcher Matthew Killingsworth from the University of Pennsylvania, looking forward to \n" +
            "something enjoyable — like a trip — brings happiness and can be mentally rewarding. The process of planning\n" +
            "a vacation can bring joy and anticipation, sometimes even more than the trip itself. People may savor the idea\n" +
            "of travel and feel more positive just by browsing destinations online. However, the downside is that the end of\n" +
            "a holiday often brings a dip in mood.",
            new List<string>
            {
                "imagine - /ɪˈmædʒɪn/",
                "anticipation - /ænˌtɪsəˈpeɪʃən/",
                "mental - /ˈmɛntl/"

            },
            new Dictionary<string, string>
            {
                {"I can't ______ going a week without my phone!", "imagine"}
            }

        ));
        GetLessons().Add(new Lesson(

            5,
            "Airport Theory: The Last-Minute Travel Trend",
            "Airport theory: is a risky travel trend where people arrive at the airport just \n" +
            "minutes before their flight to save time — and sometimes miss it.",
            "Airport theory is a trending travel idea on TikTok where travelers rush to the airport\n" +
            "just 15 minutes before their flight, relying on online check-in and carry-on bags to skip\n" +
            "the check-in desk and head straight to security. While some successfully board in time, others\n" +
            "get stuck in traffic or in long security lines and miss their flights. Experts caution against\n" +
            "this risky trend and continue to recommend arriving well in advance — two hours for domestic and \n" +
            "three hours for international flights — to ensure a smooth travel experience.",
            new List<string>
            {
                "stuck - /stʌk/",
                "rush - /rʌʃ/",
                "security - /sɪˈkjʊrəti/ "

            },
            new Dictionary<string, string>
            {
                {"We ______ to catch the train but just missed it", "rushed"}
            }

        ));
        

    }

}