using System;
using System.Collections.Generic;
using System.Text;

namespace _5BorderControl
{
    public class Citizen : IIdentifiable
    {
        private string name;
        private int age;
        private string id;
        public Citizen(string name, int age ,string id, string birthdate)
        {
            this.age = age;
            this.name = name;
            this.Birthdate = birthdate;
            this.id = id;
        }


        


      

        public string Birthdate  { get; private set; }
}
}
