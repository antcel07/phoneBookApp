using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using phoneBookApp.Data;


namespace phoneBookApp.Operations
{
    public class Searching : Operations
    {
        public override void SearchingOperation()
        {
            while(true){

                Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz");
                Console.WriteLine("******************************************");
                Console.WriteLine("İsim veya soyisime göre arama yapmak için:(1)");
                Console.WriteLine("Telefon numarasina göre arama yapmak için:(2)");
                int choose=Convert.ToInt32(Console.ReadLine());
                           
            if(choose==1)
            {
                ExistingNumber searchingPeople=new ExistingNumber();
                 Console.WriteLine("Arama yapilacak ismi ve ya soyismi giriniz:");
                 List<Person>allSearchingPeople=searchingPeople.SearchToNameSurname(Console.ReadLine());

                 foreach (Person person in allSearchingPeople)
                 {
                      Console.WriteLine("Arama sonuçlariniz:");
                        Console.WriteLine("*******************");
                        Console.WriteLine($"İsim: {person.Name}");
                        Console.WriteLine($"Soyisim: {person.Surname}");
                        Console.WriteLine($"Numara: {person.PhoneNumber}");
                        Console.WriteLine("-");
                 }

            }
           else if(choose==2)
            {
                 ExistingNumber searchingPeople=new ExistingNumber();
                 Console.WriteLine("Arama yapilacak numarayi giriniz:");
                 List<Person>allSearchingPeople=searchingPeople.SearchToNumber(Console.ReadLine());

                 foreach (Person person in allSearchingPeople)
                 {
                      Console.WriteLine("Arama sonuçlariniz:");
                        Console.WriteLine("*******************");
                        Console.WriteLine($"İsim: {person.Name}");
                        Console.WriteLine($"Soyisim: {person.Surname}");
                        Console.WriteLine($"Numara: {person.PhoneNumber}");
                        Console.WriteLine("-");
                 }

                 
                    Console.WriteLine("* Yeni bir arama yapmak için: (1)");
                    Console.WriteLine("* Ana menüye dönmek için: (2)");
                    string choose1 = Console.ReadLine();
                    if (choose1 == "1")
                        continue;
                    else if (choose1 == "2")
                        break;
    
            }


        }

        }

    }

}