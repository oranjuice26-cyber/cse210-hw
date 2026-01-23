using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Vice President of Marketing";
        job1._company = "Coca Cola";
        job1._startYear = 2019;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "President of Marketing";
        job2._company = "Pepsi";
        job2._startYear = 2024;
        job2._endYear = 2026;

        Resume exampleResume = new Resume();
        exampleResume._name = "Lova O. Soda";

        exampleResume._jobs.Add(job1);
        exampleResume._jobs.Add(job2);

        exampleResume.Display();
    }
}