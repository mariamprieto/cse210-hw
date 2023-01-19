using System;

public class Resume
{

    public string _personName;


    public List<Job> _jobs = new List<Job>();

    public void printDetails()
    {
        Console.WriteLine($"Name:{_personName}");
        Console.WriteLine($"Job:  ");
        foreach (Job job in _jobs)
        {
            // This calls the Display method on each job
            job.printJob();
        }

    }
}