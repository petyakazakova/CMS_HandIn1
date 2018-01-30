using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace PersonClass_HandIn2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        // STATIC - belongs to a class; shared to all instances of the class
        //static ArrayList array1 = new ArrayList();    // non-generic: oldschool way

        private static List<Person> ourpersonlist = new List<Person>(); // <Person> data type

        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (Person newperson in ourpersonlist)
            {
                ListBox1.Items.Add(newperson.ToString());
            }
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string name = TextBoxFname.Text;
            int age = Convert.ToInt32(TextBoxAge.Text); //type casting
            string password = TextBoxPass.Text;

            // instantiate new object
            // instanciate Person class with var = by creating a NEW instance of Person
            // new is an operator
            Person p = new Person(name, age, password); //constructor with 3 arguments
            ourpersonlist.Add(p);

            FillListBoxControlsWithPeopleInfo(); 
        }

        private void FillListBoxControlsWithPeopleInfo()
        {
            ListBox1.Items.Clear();
            ListBox2.Items.Clear();
            ListBox3.Items.Clear();


            foreach (Person p in ourpersonlist)
            {
                ListBox1.Items.Add(p.ToString());

                //nested if statement
                if (p.Age < 18) //condition
                {
                    ListBox2.Items.Add(p.Name); //execute
                }

                else
                {
                    ListBox3.Items.Add(p.Name);
                }
            }
        } 

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            ourpersonlist.RemoveAt(0);
            //call method after each change
            FillListBoxControlsWithPeopleInfo();
        }
        
        protected void ButtonDeleteSelected_Click(object sender, EventArgs e)
        {
            int selected = ListBox1.SelectedIndex;
            ourpersonlist.RemoveAt(selected);
            //call method after each change
            FillListBoxControlsWithPeopleInfo();
        }
    }
}