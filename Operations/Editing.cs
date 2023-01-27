using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using phoneBookApp.Data;


namespace phoneBookApp.Operations
{
    public class Editing : Operations
    {
        public override void EditingOperation()
        {
            while(true){
                   Console.WriteLine("Lütfen güncellemek istediğiniz kişinin adini yada soyadini bilgilerini giriniz");
                   string editInput=Console.ReadLine();

                   ExistingNumber editingPerson=new ExistingNumber();
                   var item=editingPerson.FindNameOrSurname(editInput);

                      if(item!=null)
                {



                    Console.WriteLine($"{item.Name}"+" "+$"{item.Surname} adli kisi yeni değerlerini giriniz");
                    editingPerson.EditingNumber(item);
                    
                     Console.WriteLine("Güncelleme işlemi tamamlandi.");
                    Console.WriteLine("* Yeni bir güncelleme işi yapmak için: (1)");
                    Console.WriteLine("* Ana menüye dönmek için: (2)");

                    string choose = Console.ReadLine();

                    if (choose == "1")
                        continue;
                    else if (choose == "2")
                        break;
                }

                else
                {
                    Console.WriteLine("Aradiginiz kriterlerde bir kişi bulunamadi.");
                    Console.WriteLine("* Tekrar denemek için: (1)");
                    Console.WriteLine("* Ana menüye dönmek için: (2)");

                    string choose = Console.ReadLine();

                    if (choose == "1")
                        continue;
                    else if (choose == "2")
                        break;
                }
                   
                }




            }
        }

        }

    
