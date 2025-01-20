using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the first job instance
        Job job1 = new()
        {
            _jobTitle = "Project Manager",
            _company = "PrimeHub Solution",
            _startYear = 2024,
            _endYear = 2025
        };

        // Create the second job instance
        Job job2 = new()
        {
            _jobTitle = "Social Media Manager",
            _company = "Pixel Palace",
            _startYear = 2022,
            _endYear = 2025
        };

        // Create the resume instance
        Resume myResume = new()
        {
            _name = "Eli Ibitamuno"
        };

        // Add jobs to the resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display the resume
        myResume.Display();
    }
}