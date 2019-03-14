using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelDBREST.DBUtil;
using ModelLib.model;

namespace TjekREST
{
    class Program
    {
        static void Main(string[] args)
        {
            
             //Hotel
            
             ManageHotel hmgr = new ManageHotel();

            Console.WriteLine("Alle hoteller");
            foreach (Hotel h in hmgr.Get())
            {
                Console.WriteLine(h);
            }

            Console.WriteLine("Et hotel no3");
            Console.WriteLine(hmgr.Get(3));

            Console.WriteLine("opret hotel");
            Console.WriteLine(hmgr.Post(new Hotel(100, "peters", "vejen 3")));
            Console.WriteLine(hmgr.Get(100));

            Console.WriteLine("ændre hotel");
            Console.WriteLine(hmgr.Put(100, new Hotel(100, "pouls", "gaden 3")));
            Console.WriteLine(hmgr.Get(100));

            Console.WriteLine("Slet hotel 100");
            Console.WriteLine(hmgr.Delete(100));
            Console.WriteLine(hmgr.Get(100));

            
              //Guest
             
            ManageGuest gmgr = new ManageGuest();

            Console.WriteLine("Alle gæster");
            foreach (Guest g in gmgr.Get())
            {
                Console.WriteLine(g);
            }

            Console.WriteLine("En Gæst no4");
            Console.WriteLine(gmgr.Get(4));

            Console.WriteLine("opret gæst");
            Console.WriteLine(gmgr.Post(new Guest(100, "peter", "vejen 3")));
            Console.WriteLine(gmgr.Get(100));

            Console.WriteLine("ændre gæst");
            Console.WriteLine(gmgr.Put(100, new Guest(100, "poul", "gaden 3")));
            Console.WriteLine(gmgr.Get(100));

            Console.WriteLine("Slet gæst 100");
            Console.WriteLine(gmgr.Delete(100));
            Console.WriteLine(gmgr.Get(100));


            
             //Room
            
            ManageRoom rmgr = new ManageRoom();

            Console.WriteLine("Alle værelser");
            foreach (Room r in rmgr.Get())
            {
                Console.WriteLine(r);
           }

            Console.WriteLine("En værelse no4");
            Console.WriteLine(rmgr.Get(4,1));

            Console.WriteLine("opret værelse");
            Console.WriteLine(rmgr.Post(new Room(400, 4, 'S', 234.4)));
            Console.WriteLine(rmgr.Get(4,400));

            Console.WriteLine("ændre værelse");
            Console.WriteLine(rmgr.Put(100, 4, new Room(400, 4, 'F', 287.5)));
            Console.WriteLine(rmgr.Get(4,400));

            Console.WriteLine("Slet værelse 100");
            Console.WriteLine(rmgr.Delete(4, 400));
            Console.WriteLine(rmgr.Get(4, 400));

            
              //Guest
             
            ManageBooking bmgr = new ManageBooking();

            Console.WriteLine("Alle bookninger");
            foreach (Booking b in bmgr.Get())
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("En bookning no4");
            Console.WriteLine(bmgr.Get(4));

            Console.WriteLine("opret bookning");
            Console.WriteLine(bmgr.Post(new Booking(100, 4,1,5,DateTime.Parse("2019-03-07"), DateTime.Parse("2019-03-09"))));
            
            //Console.Write("Give latest / highest b-no : ");
            //int bno = Int32.Parse(Console.ReadLine());
            //Console.WriteLine(bmgr.Get(bno));

            Console.WriteLine("ændre bookning ");
            Console.WriteLine(bmgr.Put(100, new Booking(100, 5, 2, 2, DateTime.Parse("2019-03-17"), DateTime.Parse("2019-03-19"))));
            Console.WriteLine(bmgr.Get(100));

            Console.WriteLine("Slet bookning ");
            Console.WriteLine(bmgr.Delete(100));
            Console.WriteLine(bmgr.Get(100));

            // Facilities

            ManageFacilities fmgr = new ManageFacilities();

            Console.WriteLine("Alle facilities");
            foreach (Facilities f in fmgr.Get())
            {
                Console.WriteLine(f);
            }

            Console.WriteLine();
            Console.WriteLine("Printer facility nr1:");
            Console.WriteLine(fmgr.Get(1));

            Console.WriteLine("Opretter en faciltiy:");
            Console.WriteLine(fmgr.Post( new Facilities(15, 10,"Golfbane")));
            
            Console.WriteLine(fmgr.Get(15));

            Console.WriteLine("Opdatere facility:");
            Console.WriteLine(fmgr.Put(15, new Facilities(15, 10,"Golfbane UPDATE")));
            Console.WriteLine(fmgr.Get(15));

            Console.WriteLine("Sletter facility:");
            Console.WriteLine(fmgr.Delete(15));
            Console.WriteLine("Prøver at printe slettet facility: ");
            Console.Write(fmgr.Get(15));


            /*
            ManageGuest m = new ManageGuest();
            foreach (var guest in m.Get())
            {
                Console.WriteLine(guest.Name);
            }



            ManageBooking b = new ManageBooking();

            Booking b1 = b.Get(4);

            Console.WriteLine(b1.ToString());

            ManageHotel hotel = new ManageHotel();

            Hotel hotel1 = hotel.Get(2);

            Console.WriteLine(hotel1.Name);

    */

            Console.ReadLine();
        }
    }
}
