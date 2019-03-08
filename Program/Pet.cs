using System;

namespace Pets
{
    class Pet
    {
        public string type;
        public string name;
        public string owner;
        public double weight;

        public Pet(string type, string name, string owner, double weight)

        {
            this.type = type;
            this.name = name;
            this.owner = owner;
            this.weight = weight;
        }

        public void Line()
        {
            Console.WriteLine("");
        }

        public void setType(string type)
        {
            this.type = type;
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

        public string getTag()
        {
            return "if lost, call " + this.owner;
        }
    }
}


