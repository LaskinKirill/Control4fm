using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control4fm
{
    class Person1
    {
        private String name;
        private int pin;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int PIN
        {
            get { return pin; }
            set { pin = value; }
        }

        public Person1()
        {

        }
        public Person1(String n, int p)
        {
            this.Name = n;
            this.PIN = p;           
        }

       
    }  
}

