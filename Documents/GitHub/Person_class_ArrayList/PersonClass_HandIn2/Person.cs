using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonClass_HandIn2
{
    // declare
    public class Person
    {
        //auto-implemented properties with parameters
        public int Age { get; set; } 
        public string Name { get; set; }
        public string Password { get; set; }

        // constructor
        //'this' is a reference to the object instance
        public Person(string name, int age, string password)
        {
            this.Name = name;
            this.Age = age;
            this.Password = password;
        }

        // METHOD (access modifier + return type + method name + list of parameters) - a section of statements that is executed when the method is called
        public override string ToString() //Method requires no data in this case -> () are empty
        {
            return Name + ", age " + Age + " years, pass:" + Password;
        }

    }

}