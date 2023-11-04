using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpinionPoll
{
    public class Person
    {

        private string name;
        private int age;

        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }
        public Person(int age) : this() //constructor chaining
        {
            this.Age = age;
        }
        public Person(string name, int age) //constructor chaining
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

    }
}
