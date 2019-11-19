using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyTest
{
    class Cat : Animal
    {
        private string _name;

        public string Name
        {
            get { return _name + "-kissa"; }
            set {
                if ( value.Equals("Musti"))
                {
                    throw new ArgumentException("Invalid name!");
                }
                _name = value;
            }
        }
        private int _food;

        public int Food
        {
            get { return _food; }
            set { _food = value; }
        }

        public string MakeSound()
        {
            return "Meaouw";
        }
        public void Feed(int amountOfFood)
        {
            _food += amountOfFood;
        }

    }
}
