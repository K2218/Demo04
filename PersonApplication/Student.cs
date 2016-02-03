using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Student : Person
    {
      public string StudentID { get; set; }


      public Student()
        {
        
        }

        public Student(string firstname, string lastname, string address, string studentID)
            : base(firstname, lastname, address)
        {

        }

        public void StudentMethod()
        {
            Console.WriteLine("Learning OO");
        }

        //ylikirjoitetaan person luokassa oleva ToString() metodi
        public override string ToString()
        {
            // Person luokasta palautuu Firstname Lastname Ja address ja lisätään siihen StudentID
            return base.ToString() + " " + StudentID;
        }
    }
}
