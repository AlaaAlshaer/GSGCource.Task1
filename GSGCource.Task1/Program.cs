using System;

namespace GSGCource.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = new CarEngineer("Alaa", 25, 4, "Kia");
            var y = new SoftwareEngineer("Ahmaed", 19, 1, "google", "Java");
            Console.WriteLine("-------CarEngineer--------");
            Console.WriteLine(x.Profile);
            x.FunctionalAnalysis();
            x.RequirementsGathering();
            x.Testing();
            x.Development();
            Console.WriteLine("-------SoftwareEngineer--------");
            y.FunctionalAnalysis();
            y.RequirementsGathering();
            y.Testing();
            y.Development();
        }
    }
}
