using System;

/// <summary>
/// Represents the "Business" area of study, focused on business-related vocabulary and topics.
/// Inherits from AreaStudy and populates lessons with relevant business content.
/// </summary>
public class BusinessArea : AreaStudy
{
    public BusinessArea() : base("Business", "Area focused on business vocabulary and topics.")

    {
        GetLessons().Add(new Lesson(

            1,
            "Why Employee Well-being Is Good for Business",
            "This lesson discusses how companies are improving performance by focusing on employee well-being.",
            "Employers worldwide are increasingly investing in employee well-being, recognizing that it improves\n"+
            "company performance, customer service, and talent retention. According to the World Economic Forum and McKinsey,\n"+
            "better worker health can boost the global economy by trillions, while poor mental health increases turnover risk.\n"+
            "In Asia Pacific, nearly 40% of companies prioritize well-being, with investments growing 27% since 2020. Gallup highlights\n"+
            "that supporting employees' careers and finances has the greatest impact, encouraging leaders to create a culture focused\n"+
            "on development and integrate well-being into career conversations",
             new List<string>
            {
                "well-being - /wɛl ˈbiːɪŋ/",
                "retention - /rɪˈtɛnʃən/",
                "development - /dɪˈvɛləpmənt/"

            },
            new Dictionary<string, string>
            {
                {"To ____ customers, businesses often offer discounts and rewards", "retain"}
            }

        ));

        GetLessons().Add(new Lesson(

            2,
            "Why Work Friends Might Influence Your Career",
            "This article highlights the influence of workplace friendships, both positive and negative, on employees’ career decisions.",
            "A study of 656 employees conducted by researchers from the University of South Florida and the University of Cincinnati \n" +
            "showed that when a close friend starts looking for another job, you are more likely to consider leaving too — even if you  \n" +
            "are satisfied with your current position. This influence was strongest among those with close and regular contact. The research \n" +
            "followed new hires at a global IT company over two years, during which 27% of them left the company. Interestingly, employees\n" +
            "were less likely to follow friends’ job-hunting behavior when placed in their preferred city. In short, workplace friendships not\n" +
            "only make the day more enjoyable but can also significantly influence your career decisions.",
            new List<string>
            {
                "complain - /kəmˈpleɪn/",
                "influence - /ˈɪnfluːəns/",
                "job-hunt - /ˈdʒɑːb hʌnt/"

            },
            new Dictionary<string, string>
            {
                {"There's no point _______ to the boss; he never listens to our problems", "complaining"}
            }

        ));

        GetLessons().Add(new Lesson(

            3,
            "Why Millionaire CEOs Wear the Same Clothes Every Day",
            "The article explains why many millionaire CEOs choose to wear the same clothes every day as a \n" +
            "strategy to reduce daily decisions and focus their energy on more important matters.",
            "Figures like Mark Zuckerberg and the late Steve Jobs are known for their simple,\n" +
            "repetitive outfits, such as gray t-shirts or black sweaters with jeans. This choice \n" +
            "isn’t due to a lack of resources, but rather a way to reduce “decision fatigue,” a phenomenon\n" +
            "where many small decisions drain mental energy. Even Barack Obama mentioned he avoided choosing \n" +
            "meals or outfits to focus on more important matters. Other experts, like Nick Hobson, suggest that \n" +
            "wearing the same clothes also gives them a sense of control in an uncertain professional environment.\n" +
            "However, for those who are not business leaders, choosing the right outfit is still useful for making a good impression.",
            new List<string>
            {
                "outfit - /ˈaʊtˌfɪt/",
                "waste - /weɪst/",
                "avoid- /əˈvɔɪd/"

            },
            new Dictionary<string, string>
            {
                {"I've been trying to ____ looking at screens before I go to bed", "avoid"}
            }

        ));
        GetLessons().Add(new Lesson(

            4,
            "The Truth Behind the Bite in Apple's Logo",
            "This article explores the myths and the true origin behind the bite in Apple's iconic logo.",
            "There are various theories about the bite in Apple’s logo, including the popular myth that it’s a tribute\n" +
            "to Alan Turing and another linking it to the Biblical story of Adam and Eve. However, the real reason is much\n" +
            "simpler. According to designer Rob Janoff, the bite was added so people would recognize the fruit as an apple \n" +
            "and not mistake it for a cherry. He even admitted that he wasn’t aware of the computing term “byte” until after\n" +
            "the logo was created. Despite the deep symbolic interpretations, the truth is purely practical.",
            new List<string>
            {
                "theory - /ˈθiːəriː/",
                "tribute - /ˈtrɪbjuːt/",
                "foundation - /faʊnˈdeɪʃən/"

            },
            new Dictionary<string, string>
            {
                {"Albert Einstein first published his ____ of relativity in 1905.", "theory"}
            }

        ));
        GetLessons().Add(new Lesson(

            5,
            "Major Japanese Companies Use AI for Recruitment",
            "This text explores how Japanese companies are increasingly using AI in recruitment, highlighting both its benefits and concerns",
            "A recent survey by Jiji Press found that nearly 30% of major Japanese companies are using or planning to use AI\n" +
            "in their recruitment processes, with tools like AI chatbots and screening systems saving time for employers.\n" +
            "Companies like Kirin Holdings and Fujitsu have adopted AI for interviews and application reviews. However, over half\n" +
            "of the surveyed companies are hesitant, citing concerns about accuracy and the value of human interaction. While many \n" +
            "students use AI to help with job applications, a significant portion also distrusts its ability to fairly evaluate candidates.\n" +
            "The findings reflect both growing interest in AI and ongoing skepticism about its role in hiring",
            new List<string>
            {
                "recruitment - /rɪˈkruːtmənt/",
                "accuracy - /ˈækjərəsiː/",
                "identify - /aɪˈdɛntəˌfaɪ/"

            },
            new Dictionary<string, string>
            {
                {"Google's ________ process is known for being very thorough and rigorous", "recruitment"}
            }

        ));
       

    }

}