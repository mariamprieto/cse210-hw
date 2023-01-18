using System;
public class Job{
    public string _jobTitle = "";
    public string _jobCompany = "";
    public string _jobYears = "";
    public Job (){

    }
    public void printJob(){
        Console.WriteLine($"{_jobTitle} ({_jobCompany}) {_jobYears}");

    }
    }

