using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Animals
    {

        private string color;
        private int age;
        private string name;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Animals(string Name,string Color,int Age)
        {
            this.name = Name;
            this.color = Color;
            this.age = Age;
        }

        public override string ToString()
        {
            return $"Name:{name} Color:{color} Age:{Age}\n";
        }




    }
}
