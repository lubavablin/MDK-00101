using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Students
    {
        private string name_;
        private int age_;
        private double avg_;
        private int numberBilet_;
        public Students(string name, int age, double avg, int numberBilet)
        {
            name_ = name;
            age_ = age;
            avg_ = avg;
            numberBilet_ = numberBilet;
        } 
        public string Name 
        {
            get { return name_; }
        }
        public int Age
        {
            get { return age_;  }
        }
        public double Avg
        {
            get { return avg_; }
        }
        public double Number
        {
            get { return numberBilet_; }
        }
    }

}

