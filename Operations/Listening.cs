using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using phoneBookApp.Data;


namespace phoneBookApp.Operations
{
    public class Listening : Operations
    {
        public override void ListeningOperation()
        {
          while(true){
          
            ExistingNumber callList =new ExistingNumber();
            callList.ListeningPerson();
             Console.WriteLine("* Ana menüye dönmek için: (1)");
                Console.WriteLine("* Listeyi tekrar görmek için: (2)");
                string choose = Console.ReadLine();
                if (choose == "1")
                    break;
                else if (choose == "2")
                    continue;


          }
        }

    }

}