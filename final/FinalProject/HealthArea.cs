using System;
/// <summary>
/// This class defines the Health area of study.
/// It contains lessons designed to teach health-related vocabulary, symptoms, medical situations, and communication with healthcare professionals.
/// </summary>
public class HealthArea : AreaStudy
{
    public HealthArea() : base("Health", "Area focused on health vocabulary and topics.")

    {
        GetLessons().Add(new Lesson(

            1,
            "Sugary Drinks — not Food — May Increase Diabetes Risk",
            "A recent study suggests that sugary drinks, more than sugary foods, \n" +
            "may significantly raise the risk of developing Type 2 diabetes.",
            "A new study from researchers in Germany and the U.S. reviewed 29 global studies and\n" +
            "found that consuming sugary drinks like sodas, sports drinks, and fruit juices is linked\n" +
            "to a higher risk of developing Type 2 diabetes. Each additional soda or sports drink per \n" +
            "day increased the risk by 25%, and each extra fruit juice by 5%. However, sugars from food\n" +
            "did not show the same risk. While the study couldn’t prove causation, the researchers suggest \n" +
            "governments consider these findings in health guidelines. Type 2 diabetes, which mostly affects\n" +
            "adults, is influenced by factors like genetics, lack of exercise, and certain medications. It accounts\n" +
            "for over 95 % of global diabetes cases, according to the WHO. ",
             new List<string>
            {
                "risk - /rɪsk/ ",
                "intake - /ˈɪnˌteɪk/",
                "advise - /ædˈvaɪz/"

            },
            new Dictionary<string, string>
            {
                {"A poor diet and a lack of physical exercise increase your ____ of developing diabetes","risk"}
            }

        ));

        GetLessons().Add(new Lesson(

            2,
            "A Consistent Sleep Schedule Could Save Your Heart",
            "A consistent sleep schedule may significantly reduce the risk of heart disease,\n" +
            "even if total sleep time is within healthy limits",
            "A study involving over 72,000 adults over eight years found that irregular sleep \n" +
            "A long-term study of over 72,000 adults found that having a consistent sleep schedule — going \n" +
            "to bed and waking up at the same time each day — can significantly lower the risk of heart disease. \n" +
            "Researchers used a tool called the Sleep Regularity Index (SRI) to measure how regular each \n" +
            "person’s sleep was. Even a moderate SRI score of 77.1 was linked to a 15% reduction in heart risk,\n" +
            "while very irregular sleepers had a 26% higher risk of serious conditions like heart attacks and strokes.\n" +
            "These results held true even when total sleep time was within the recommended range. Experts emphasize that beyond getting enough sleep, maintaining a consistent daily schedule is key to supporting heart health.",
             new List<string>
            {
                "measure - /ˈmɛʒər/ ",
                "moderate - /ˈmɑːdɛrət/",
                "consistent - /kənˈsɪstənt/ "

            },
            new Dictionary<string, string>
            {
                {"A ______ sleep schedule can help improve your overall well-being","consistent"}
            }

        ));

        GetLessons().Add(new Lesson(

            3,
            "How to Eat Less Meat in 4 Easy Steps",
            "This beginner’s guide offers four simple steps to help you eat less meat \n" +
            "for better health and a more sustainable lifestyle",
            "Reducing meat consumption has health and environmental benefits, and this guide\n" +
            "outlines four easy steps to help you start. First, commit to your goal and start small — such\n" +
            "as avoiding meat one day a week. Second, find multiple motivations, like improving health, saving\n" +
            "money, or protecting the environment, to stay encouraged. Third, plan your meals in advance to avoid\n" +
            "repetition and discover new meat-free dishes. Lastly, track your progress and celebrate milestones, \n" +
            "whether it’s one meat-free day or several months without meat. Small changes can lead to long-term success.",
             new List<string>
            {
                "commit - /kəˈmɪt/",
                " motivation - /moʊtəˈveɪʃən/",
                " goal - /goʊl/"

            },
            new Dictionary<string, string>
            {
                {"What is your _______ for learning English?","motivation"}
            }

        ));
        GetLessons().Add(new Lesson(

            4,
            "The Health Benefits of Kindness",
            "Acts of kindness and volunteering are linked to better physical and mental health, \n" +
            "including lower blood pressure, stress, and inflammation",
            "Research shows that being kind can positively impact both physical and mental health.\n" +
            "A 2018 study found lower heart disease risk in men who helped others, and a 2013 study\n" +
            "revealed that older adults who volunteered 200 hours a year were 40% less likely to develop\n" +
            "high blood pressure. In Canada, high school students who volunteered weekly experienced lower\n" +
            "inflammation, cholesterol, and body mass indexes. Experts suggest that kindness may reduce stress,\n" +
            "offer perspective on personal problems, and increase social connection — all of which are tied to\n" +
            "better health. Even being kind to yourself matters. Simple kind acts can benefit both you and those around you. ",
             new List<string>
            {
                "blood pressure - /ˈblʌd preʃər/",
                "inflammation - /ˌɪnfləˈmeɪʃn/",
                "cholesterol - /kəˈlɛstəˌroʊl/"

            },
            new Dictionary<string, string>
            {
                {"The study found that eating protein from a variety of sources may help prevent high _______ ","blood pressure"}
            }

        ));
        GetLessons().Add(new Lesson(

            5,
            "7 Days of Cold Baths Could Make Our Cells Stronger",
            "A new study suggests that daily cold water baths may improve cellular health by enhancing the body’s repair processes.",
            "Researchers from the University of Ottawa studied the effects of cold water exposure by asking\n" +
            "10 healthy men to spend one hour each day for a week in 14°C water. The study focused on two key\n" +
            "cellular processes: autophagy, where cells repair themselves by recycling damaged parts, and apoptosis,\n" +
            "the programmed death of cells that are no longer useful. At first, participants’ cells showed poor \n" +
            "autophagy and excessive cell death, but by the end of the week, the cells had adapted — showing stronger\n" +
            "autophagy and reduced apoptosis. Researcher Kelli King noted the surprising speed of improvement, suggesting\n" +
            "cold exposure could help maintain cellular health and potentially prevent disease. Still, medical advice is \n" +
            "recommended before trying cold water therapy.",
             new List<string>
            {
                "cell - /sɛl/",
                "repair - /rɪˈpɛr/",
                "prevent - /prɪˈvɛnt/"

            },
            new Dictionary<string, string>
            {
                {"Smoking causes mutations in lung _____ that lead to cancer","cells"}
            }

        ));


    }

}