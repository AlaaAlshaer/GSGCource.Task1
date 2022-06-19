using System;

namespace GSGCource.Task1
{
    public abstract class Engineer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int YearsOfExpirence { get; set; }
        public string CurrentCampany { get; set; }
        public string Profile
        {
            get { return string.Format
                    ("{0}, I have {1} years old , {2} year(s) of experiencee, current working at {3}.",
                  Name,Age,YearsOfExpirence,CurrentCampany);
            }
        }


        public Engineer(string name, int age, int yearsOfExpirence, string currentCampany)
        {
            Name = name;
            Age = age; 
            YearsOfExpirence = yearsOfExpirence;
            CurrentCampany = currentCampany;
        }

        protected void Release(string profile)
        {
            Console.WriteLine("This project has been released by: " + profile);
        }


        public abstract void FunctionalAnalysis();

        public abstract void RequirementsGathering();

        public abstract void Development();

        public abstract void Testing();
        public  int Salary(int hoursNum, int hourCost) { return hoursNum * hourCost; }


    }
}
