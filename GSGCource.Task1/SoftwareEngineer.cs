using System;


namespace GSGCource.Task1
{
    internal class SoftwareEngineer : Engineer
    {
        private string _language;
        public SoftwareEngineer(string name, int age, int yearsOfExpirence, string currentCampany, string language) : base(name, age, yearsOfExpirence, currentCampany)
        {
            _language = language;
        }

        protected internal override void FunctionalAnalysis()
        {
            Console.WriteLine("The software analysis was completed with success.");
        }

        protected internal override void RequirementsGathering()
        {
            Console.WriteLine("The software requirements were verified with success.");
        }

        protected internal override void Development()
        {
            Console.WriteLine(string.Format("The software development was finished using {0}.", this._language));
        }

        protected internal override void Testing()
        {
            Console.WriteLine("The software test was executed with success.");
        }

    }
}
