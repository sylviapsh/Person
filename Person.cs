using System.Text;

namespace Person
{
    class Person
    {
        //Fields
        private string name;
        private int? age;

        //Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int? Age
        {
            get { return age; }
            set { age = value; }
        }

        //Constructor
        public Person(string name) : this(name, null) { }

        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            StringBuilder personBuild = new StringBuilder();
            personBuild.AppendFormat("Name: {0}", Name);
            personBuild.AppendLine();

            if (this.Age == null)
            {
                personBuild.AppendLine("Age: unspecified");
            }
            else
            {
                personBuild.AppendFormat("Age: {0}", this.Age);
                personBuild.AppendLine();
            }

            return personBuild.ToString();
        }
    }
}
