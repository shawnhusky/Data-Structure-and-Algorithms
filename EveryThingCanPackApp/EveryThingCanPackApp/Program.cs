using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveryThingCanPackApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Parcel p1 = new Parcel(5109, "Peggy", 15);
            Parcel p2 = new Parcel(2455, "Landy", 45);
            Parcel p3 = new Parcel(8119, "Andrea", 23);
            Parcel p4 = new Parcel(7633, "Dave", 34);
            Parcel p5 = new Parcel(8220, "Kathy", 56);

            LinkedList myLinkList = new LinkedList();

            myLinkList.AddParcelToFront(p5);
            myLinkList.AddParcelToFront(p4);
            myLinkList.AddParcelToFront(p3);
            myLinkList.AddParcelToFront(p2);
            myLinkList.AddParcelToFront(p1);

            //output

            Console.WriteLine("Displaying initial list:");
            Console.WriteLine("Displaying inventory...");

            myLinkList.DisplayInventory();

            Console.WriteLine("==============================");

            myLinkList.RemoveParcelAtPosition(2);
            myLinkList.DisplayInventory();

            Console.WriteLine("==============================");

            myLinkList.SortByCustomerName();
            myLinkList.DisplayInventory();

            Console.WriteLine("==============================");

            myLinkList.ParcelSwap(1,3);
            myLinkList.DisplayInventory();

            Console.WriteLine("==============================");

        }
    }
}
