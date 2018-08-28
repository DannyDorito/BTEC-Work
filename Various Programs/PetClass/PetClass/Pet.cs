using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PethTheDogeClassbut
{
    class Pet
    {
        private string name;
        private int health;
        private int hunger;
        private int hygine;
        private int age;

        public Pet(string nam)
        {
           this.name = nam;
           this.age = 1;
           this.health = 50;
           this.hunger = 50;
           this.hygine = 50;
        }
        public int HEALTH
        {
            get { return health; }
            set { health = value; }
        }
        public int HUNGER
        {
            get { return hunger; }
            set { hunger = value; }
        }
        public int HYGINE
        {
            get { return hygine; }
            set { hygine = value; }
        }
        public int AGE
        {
            get { return age; }
            set { age = value; }
        }
        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
    }
}
