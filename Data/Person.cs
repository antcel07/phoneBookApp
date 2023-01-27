using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace phoneBookApp.Data
{
    public class Person
    {
     public string Name { get; set; }
      public string Surname { get; set; }
       public string PhoneNumber { get; set; }

public Person(string name,string surname,string phonenumber)
{
Surname=surname;
Name=name;
PhoneNumber=phonenumber;

}

    }

}