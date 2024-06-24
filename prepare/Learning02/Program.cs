using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job("BloomTech", "Back-end Engineer", 2025, 2050);
        job1._Company = "BloomTech";
        job1._JobTitle = "Back-end Engineer";
        job1._StartYear = 2025;
        job1._EndYear = 2050;


        Job job2 = new Job("Amazon", "Front-end Engineer", 2024, 2080);
        job2._Company = "Amazon";
        job2._JobTitle = "Front-end Engineer";
        job2._StartYear = 2024;
        job2._EndYear = 2080;

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();


        Resume myResume = new Resume();
        myResume._Name = "Albert Pessima";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        myResume.DisplayResumeDetails();
        

    }
}