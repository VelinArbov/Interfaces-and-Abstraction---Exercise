using System;
using System.Collections.Generic;
using System.Text;

namespace _03Ferrari
{
    public class Driver : IFerrari
    {
        public Driver(string name)
        {
            this.Name = name;
        }



        public string Name { get; private set; }

        public override string ToString()
        {
            return $"488-Spider/Brakes!/Gas!/{this.Name}";
        }
    }
}
