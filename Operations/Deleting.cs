using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using phoneBookApp.Data;


namespace phoneBookApp.Operations
{
    public class Deleting : Operations
    {

        public override void DeletingOperation()
        {
            while(true)
            {
                Console.WriteLine("Lütfen silmek istediğiniz kişinin adini yada soyadini giriniz");
                string input=Console.ReadLine();

                ExistingNumber deletingNumber=new ExistingNumber();

                var item=deletingNumber.FindNameOrSurname(input);

                if(item!=null)
                {
                    Console.WriteLine($"{item.Name}"+" "+$"{item.Surname} adli kisi rehberden silinmek üzere onayliyor musunuz? (y/n)");
                    string response=Console.ReadLine();
                    if(response=="y" || response=="Y"){
                        deletingNumber.DeletePerson(item);
                         Console.WriteLine("Silme işlemi başariyla gerçekleşti.");
                        Console.WriteLine("* Başka bir silme işlemi yapmak için: (1)");
                        Console.WriteLine("* Ana menüye dönmek için: (2)");
                        int choose = Convert.ToInt32(Console.ReadLine());
                        if (choose == 1)
                            continue;
                        else if (choose == 2)
                            break;
                    }

                     else
                    {
                        Console.WriteLine("Silme işlemi iptal edildi.");
                        Console.WriteLine("* Başka bir silme işlemi yapmak için: (1)");
                        Console.WriteLine("* Ana menüye dönmek için: (2)");
                        int choose = Convert.ToInt32(Console.ReadLine());
                        if (choose == 1)
                            continue;
                        else if (choose == 2)
                            break;
                    }
                   
                }

                else{
                      Console.WriteLine("Kişi bulunamadi.");
                    Console.WriteLine("* Yeni bir arama yapmak için: (1)");
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

}