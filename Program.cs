using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using phoneBookApp.Operations;


namespace phoneBookApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz?");
            Console.WriteLine("******************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayi Silmek");
            Console.WriteLine("(3) Varolan Numarayi Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");

            Console.WriteLine("**********************");
            Console.Write("Lütfen secimnizi giriniz: ");


            int choose=Convert.ToInt32(Console.ReadLine());

            switch(choose){

                case 1: 
                Adding adding=new Adding();
                adding.AddingOperation();
                break;
            }

               switch(choose){

                case 2: 
                Deleting deleting=new Deleting();
                deleting.DeletingOperation();
                break;
        }

              switch(choose){

                case 3: 
                Editing editing=new Editing();
                editing.EditingOperation();
                break;
        }

               switch(choose){

                case 4: 
                Listening listening=new Listening();
                listening.ListeningOperation();
                break;
        }

          switch(choose){

                case 5: 
                Searching searching=new Searching();
                searching.SearchingOperation();
                break;
        }

    }
    }
    }

