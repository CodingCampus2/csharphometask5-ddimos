using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class SuperVirus : Task5.Virus
    {
        public SuperVirus():
            base(false)
        { 
        }
        public override DateTime DateTimeOfCreation
        {
            get => DateTime.Now;
        }
        public override string VictimName{ get; set; }
        public override float KillProbability
        {
            get => _killProbability;
            set
            {
                float doubleProb = value * 2.0f ;
                _killProbability = (doubleProb >= 1.0f) ? 1.0f : doubleProb;
            }
        }
        public override string Name
        {
            get => _name;
            set => _name = value.Replace("virus", "supervirus");
        }

        private float _killProbability;
        private string _name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task5, Task5.Virus> TaskSolver = task =>
            {
                Task5.Virus virus = new SuperVirus();
                return virus;
            };
            Task5.CheckSolver(TaskSolver);
        }
    }
}
