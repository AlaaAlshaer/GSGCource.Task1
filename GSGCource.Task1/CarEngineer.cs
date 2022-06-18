using System;


namespace GSGCource.Task1
{
    internal class CarEngineer : Engineer
    {
        public CarEngineer(string name, int age, int yearsOfExpirence, string currentCampany) : base(name, age, yearsOfExpirence, currentCampany)
        {
        }


        protected internal override void FunctionalAnalysis()
        {
            Console.WriteLine("The car features were analyzed with success.");
        }

        protected internal override void RequirementsGathering()
        {
            Console.WriteLine("The car details were verified with success.");
        }

        protected internal override void Development()
        {
            Console.WriteLine("The car manufacturing was finished with success.");
        }

        protected internal override void Testing()
        {
            Console.WriteLine("The car test was executed with success.");
        }
    }
}
