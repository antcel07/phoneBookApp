using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using phoneBookApp.Data;


namespace phoneBookApp.Operations
{
    public class Adding : Operations
    {
        public override void AddingOperation()
        {
            
            while (true)
            {
               
                Console.WriteLine("Lütfen isim giriniz:");
                string name=Console.ReadLine();
                Console.WriteLine("Lütfen soyisim giriniz:");
                string surname=Console.ReadLine();
                Console.WriteLine("Lütfen telefon numarasini giriniz:");
                string phonenumber=Console.ReadLine();
           

                ExistingNumber addingNewNumber=new ExistingNumber();
                addingNewNumber.AddNewNumber(name,surname,phonenumber);

                Console.WriteLine("Ekleme işimi başariyla tamamlandi.");
                Console.WriteLine("* Başka bir ekleme işi yapmak için: (1)");
                Console.WriteLine("* Ana menüye dönmek için: (2)");
                int choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 1)
                    continue;
                else if (choose == 2)
                    break;


            }

        }

    }
}