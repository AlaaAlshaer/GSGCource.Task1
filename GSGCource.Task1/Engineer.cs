using System;

namespace GSGCource.Task1
{
    public abstract class Engineer
    {
        private string _name ;
        private int _age;
        private int _yearsOfExpirence;
        private string _currentCampany;
        public string Profile
        {
            get { return string.Format
                    ("{0}, I have {1} years old , {2} year(s) of experiencee, current working at {3}.",
                  _name,_age,_yearsOfExpirence,_currentCampany);
            }
        }


        public Engineer(string name, int age, int yearsOfExpirence, string currentCampany)
        {
            _name = name;
            _age = age; 
            _yearsOfExpirence = yearsOfExpirence;
            _currentCampany = currentCampany;
        }

        protected void Release(string profile)
        {
            Console.WriteLine("This project has been released by: " + profile);
        }


        protected internal abstract void FunctionalAnalysis();

        protected internal abstract void RequirementsGathering();

        protected internal abstract void Development();

        protected internal  abstract void Testing();


    }
}
