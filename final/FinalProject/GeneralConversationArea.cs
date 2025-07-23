using System;
/// <summary>
/// This class defines the General Conversation area of study.
/// It provides lessons centered around everyday conversation topics, greetings, personal information, and common interactions.
/// </summary>
public class GeneralConversationArea : AreaStudy
{
    public GeneralConversationArea() : base("General Conversation", "Area focused on different conversation vocabulary and topics.")

    {
        GetLessons().Add(new Lesson(

            1,
            "The Best Musical Instruments for Beginners",
            "This text presents three beginner-friendly musical instruments that are easy to learn, affordable, and fun to play.",
            "Learning an instrument can be rewarding, and some are better suited for beginners. The piano is a great choice\n" +
            "because it's easy to make a pleasant sound and helps with music theory and reading sheet music — and electric\n" +
            "keyboards are a more affordable option. The ukulele is simple and gentle on the fingers, with just four strings,\n" +
            "making it easy to learn chords and notes, and it can lead to learning other string instruments like the guitar. \n" +
            "Lastly, bongo drums are ideal for beginners interested in percussion; they’re affordable, portable, and excellent\n" +
            "for developing rhythm, a skill useful for all musicians.",
             new List<string>
            {
                "rhythm - /ˈrɪðəm/",
                "theory - /ˈθiːəri/",
                "portable - /ˈpɔrtəbəl/"

            },
            new Dictionary<string, string>
            {
                {"I've always had a terrible sense of ______", "rhythm"}
            }

        ));

        GetLessons().Add(new Lesson(

            2,
            "Emojis Can Help Couples Feel Closer, Study Finds",
            "A new study shows that using emojis in text messages can help couples feel more connected and emotionally supported.",
            "A study from the University of Texas at Austin found that adding emojis to text messages can strengthen romantic \n" +
            "relationships by making conversations feel more caring and emotionally involved. Researchers asked 260 adults \n" +
            "to evaluate different message exchanges, some with emojis and some without. Participants felt that messages with \n" +
            "emojis made the sender seem more responsive and thoughtful, which led to a greater sense of closeness and satisfaction.\n" +
            "Psychologist Raquel Peel, commenting on the study, noted that emojis are a helpful alternative when in-person interaction\n" +
            "isn't possible, helping couples stay emotionally connected in a digital world.",
            new List<string>
            {
                "caring - /ˈkɛrɪŋ/",
                "thoughtful - /ˈθɔːtfəl/",
                "psychologist -/saɪˈkɑːlədʒɪst/"

            },
            new Dictionary<string, string>
            {
                {"Family members described the victim as a caring and _______ woman", "thoughtful"}
            }

        ));

        GetLessons().Add(new Lesson(

            3,
            "How We Handle Stress May Change Our Personality",
            "A long-term study shows that how we handle daily stress can influence changes in our personality over time.",
            "A study by Michigan State University followed over 2,000 adults for 18 years to explore the relationship\n" +
            "between stress management and personality change. Participants who became better at handling daily stressors\n" +
            "grew more extroverted, agreeable, and open to new experiences. Conversely, those who struggled with stress became\n" +
            "more introverted and less open. Lead researcher William Chopik highlighted that improvements in emotional regulation\n" +
            "can positively affect personality traits over time. Although the study didn’t explore specific stress-reduction \n" +
            "strategies, the findings suggest that managing stress effectively can lead to lasting personality growth and greater happiness.",
            new List<string>
            {
                "personality - /ˌpɜrsəˈnælɪti/",
                "stressor -  /ˈstre-sər/",
                "extrovert - /ˈɛkstroʊˌvərt/"

            },
            new Dictionary<string, string>
            {
                {"My financial situation has been a major _______ over the past few months", "stressor "}
            }

        ));
        GetLessons().Add(new Lesson(

            4,
            "How to Talk About Neurodiversity",
            "This guide explains respectful and inclusive ways to talk about neurodiversity, highlighting key terms and language preferences.",
            "Neurodiversity refers to the natural variation in how human brains function, with about one in seven people considered\n" +
            "neurodivergent — including those with autism, ADHD, or dyslexia. The text explains important distinctions in language, \n" +
            "such as person-first (“person with autism”) vs. identity-first (“autistic person”) approaches, noting that preferences vary \n" +
            "among individuals and communities. Organizations like the UK's National Autistic Society and the Autistic Self Advocacy\n" +
            "Network support identity-first language, while many parents prefer person-first. The article also mentions the informal term\n" +
            " “neurospicy,” which is used in online spaces but may not be appropriate in all contexts. When unsure, it’s best to ask or avoid unfamiliar terms.",
            new List<string>
            {
                "dyslexia -  /dɪsˈleksiə/",
                "diversity - /dɪˈvərsɪtiː/",
                "diagnosis - /ˌdaɪəgˈnoʊsɪs/"

            },
            new Dictionary<string, string>
            {
                {"With over 140 languages spoken in the city, Toronto is famous for its ethnic and cultural _______.", "diversity"}
            }

        ));
        GetLessons().Add(new Lesson(

            5,
            "These Phrases Won't 'Throw You to the Wolves'",
            "This article explains common English idioms related to wolves and their meanings in everyday situations.",
            "English includes several idioms based on wolves that describe different behaviors or situations. \n" +
            "“A wolf in sheep’s clothing” refers to someone who seems kind but is actually untrustworthy.\n" +
             "To “throw someone to the wolves” means to put them in danger to protect oneself.\n" +
            "“Keeping the wolf from the door” means having just enough money to survive. Someone rude or lacking\n" +
            "manners might be said to have “been raised by wolves.” If a person lies about needing help, they are\n" +
            "“crying wolf”—a reference to the classic fable. Finally, a “lone wolf” is someone who prefers to be \n" +
            "alone and act independently.",
            new List<string>
            {
                "raise - /reɪz/",
                "manners - /ˈmænərz/",
                "trust - /trʌst/"

            },
            new Dictionary<string, string>
            {
                {"It's bad _____ to interrupt someone while they're speaking", "manners"}
            }

        ));



    }

}