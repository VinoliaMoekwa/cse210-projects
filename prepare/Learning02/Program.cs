using System;

 class Program
{
    static void Main(string[] args)
    {
    
      Job job1 = new Job();
      job1. _jobTitle= "Web Developer";
      job1._company = "Kinetic Energy";
      job1._startYear = 2018;
      job1._endYear = 2020;

      Job job2 = new Job();
      job2._jobTitle = "Full Stack Developer";
      job2._company = "Mukon";
      job2._startYear = 2022;
      job2._endYear =2023;

      Resume myResume = new Resume();
      myResume._name = "Ntombi Moekwa";

      myResume._jobs.Add(job1);
      myResume._jobs.Add(job2);

      myResume.Display();

    }
}

