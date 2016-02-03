﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }

        public Person()
        {

        }

        public Person(string firstname, string lastname, string address)
        {
            Firstname = firstname;
            Lastname = lastname;
            Address = address;
        }

        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + Address;
        }
    }
}
