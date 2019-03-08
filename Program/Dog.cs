using System;

namespace Pets
{
    class Dog : Pet
    {
        public Dog(string name, string owner, double weight) : base(string.Empty, name, owner, weight)

        {
            this.name = name;
            this.owner = owner;
            this.weight = weight;
        }

        public void Line()
        {
            Console.WriteLine("");
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setOwner(string owner)
        {
            this.owner = owner;
        }

        public void setWeight(double weight)
        {
            this.weight = weight;
        }

        public string bark(int num)
        {
            string bark = "";

            for (int counter = 0; counter <= num; counter++)
            {
                bark = "bark!" + bark;

            }
            return bark;
        }

        public string getTag()
        {
            return "if lost, call " + this.owner;
        }
    }
}
