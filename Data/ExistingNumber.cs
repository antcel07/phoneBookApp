using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phoneBookApp.Data
{
    public class ExistingNumber
    {
     public static List<Person> peopleList = new List<Person>();

         static ExistingNumber()
        {
            peopleList.Add(new Person("Furkan", "Yilmaz", "05555555555"));
            peopleList.Add(new Person("Flip", "Ksaci", "05555555554"));
            peopleList.Add(new Person("İsa", "Balaban", "05555555553"));
            peopleList.Add(new Person("Samet", "Sinyol", "05555555552"));
            peopleList.Add(new Person("Arda", "Turan", "05555555551"));
            peopleList.Add(new Person("Acil", "Ambulans", "112"));
            peopleList.Add(new Person("Acil", "Polis", "155"));
            peopleList.Add(new Person("Bilinmeyen", "Numaralar", "11880"));
        }
      

       //burada kaydetme işlemini yaparız addingden gelen verileri tutup peopleList  listesine ekleriz
      public void AddNewNumber(string name,string surname,string phonenumber)
        {
            peopleList.Add(new Person(name,surname,phonenumber));
        }

        public Person FindNameOrSurname(string name)
        {
            var item=peopleList.Find(x=>x.Name==name || x.Surname==name);
            return item;
        }

        public void DeletePerson(Person person)
        {
            peopleList.Remove(person);

        }

        public void EditingNumber(Person person)
        {
             Console.WriteLine("İsim:");
             person.Name=Console.ReadLine();
              Console.WriteLine("Soyisim:");
             person.Surname=Console.ReadLine();
              Console.WriteLine("Numara:");
             person.PhoneNumber=Console.ReadLine();
        }

        public void ListeningPerson()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("*************************");
        foreach(Person person in peopleList)
        {
            Console.WriteLine("İsim: "+ person.Name  );
            Console.WriteLine("Soyisim: "+ person.Surname);
            Console.WriteLine("Telefon Numarasi: ", person.PhoneNumber);

        }
        
        }
       public List<Person> SearchToNameSurname(string name)
        {
         var item = peopleList.FindAll(x => x.Name.Equals(name) || x.Surname.Equals(name));
            return item;

        }

        public List<Person> SearchToNumber(string number)
        {
           var item = peopleList.FindAll(x => x.PhoneNumber == number);
            return item;
        }
   




    }

}