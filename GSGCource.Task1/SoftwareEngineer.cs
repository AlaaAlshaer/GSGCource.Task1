using System;


namespace GSGCource.Task1
{
    public class SoftwareEngineer : Engineer
    {
        public string Language;
        public SoftwareEngineer(string name, int age, int yearsOfExpirence, string currentCampany, string language) : base(name, age, yearsOfExpirence, currentCampany)
        {
            Language = language;
        }

        public override void FunctionalAnalysis()
        {
            Console.WriteLine("The software analysis was completed with success.");
        }

        public override void RequirementsGathering()
        {
            Console.WriteLine("The software requirements were verified with success.");
        }

        public override void Development()
        {
            Console.WriteLine(string.Format("The software development was finished using {0}.", Language));
        }

        public override void Testing()
        {
            Console.WriteLine("The software test was executed with success.");
        }

    }
}
