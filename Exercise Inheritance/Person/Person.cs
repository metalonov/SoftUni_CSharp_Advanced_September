
namespace Person;
    public class Person
    {
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        private string name;
        private int age;


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public virtual int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value>0)
                {
                    age = value;
                }
            } 
        }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}
