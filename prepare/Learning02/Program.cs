using System;

class Program
{
    static void Main(string[] args)
    {
        Job Job = new Job();
        Job._jobTitle = "Secretary";
        Job._jobCompany = "Apple";
        Job._jobYears = "2019-2022";
        Job.printJob();
        Job Job1= new Job();
        Job1._jobTitle = "Software Engineer";
        Job1._jobCompany = "Google";
        Job1._jobYears = "2008-2022";
        Job1.printJob();

        Resume myResume = new Resume();
        myResume._personName = "Rosa Blanco";
        myResume._jobs.Add(Job);
        myResume._jobs.Add(Job1);
        myResume.printDetails();



    }
}