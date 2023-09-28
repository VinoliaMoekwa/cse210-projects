using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "Apple";
        job1._jobTitle = "Developer";
        job1._startYear = 2015;
        job1._endYear = 2020;

        Job job2 = new Job();

        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2021;
         job1._endYear = 2023;

         job1.DisplayJob();
         job2.DisplayJob();

        Resume myResume = new Resume();
        myResume._name ="Ntombi Moekwa";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
    }
    
}