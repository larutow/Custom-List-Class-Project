using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class Cat
    {
        public string Name { get; set; }
        public string Color { get; set; }
       
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public Cat(string name, string color, int age)
        {
            Age = age;
            Color = color;
            Name = name;
        }

    }
}
