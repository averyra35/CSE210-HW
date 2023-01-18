using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "(Intel)";
        job1._jobTitle = "Computer Engineer";
        job1._startYear = 2015;
        job1._endYear = 20;

        Job job2 = new Job();
        job2._company = "(Apple)";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2018;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Avery Anderson";
        myResume.jobs.Add(job1._jobTitle + " " + job1._company + " " + job1._startYear + "-" + job1._endYear);
        myResume.jobs.Add(job2._jobTitle + " " + job2._company + " " + job2._startYear + "-" + job2._endYear);
    }
    
}