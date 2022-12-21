using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Shedule:Time
    {
        private string discipline;
        private int office;

        public Shedule(string discipline, int office ,int hours, int minutes, int seconds) : base(hours, minutes, seconds)
        {
            this.discipline = discipline;
            this.office = office;
        }

        public string Discipline
        {
            get => discipline; 
            set{discipline = value;}
        }

        public bool SomeMethod(int hours,int minutes) {
            if (Hours==hours&& Minutes == minutes)
            {
                return true;
            }
            return false;
        }
    }
}
