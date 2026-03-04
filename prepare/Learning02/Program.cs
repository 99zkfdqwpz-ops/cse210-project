using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "pixel games";
        job1._startYear = 2019;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Amazon";
        job2._startYear = 2008;
        job2._endYear = 2016;

        Resume myResume = new Resume();
        myResume._name = "Carter Macham";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}