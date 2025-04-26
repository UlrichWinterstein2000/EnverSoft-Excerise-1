using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnverSoft
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //You have two arrays/lists as follows
            int[] list1 = new int[] { 1, 2, 3, 4, 5 };
            int[] list2 = new int[] { 3, 4, 5, 6, 7 };




            //a. Show the common elements in both lists. E.g the common elements are "3 4 5", because they are contained in both lists.

            var list3A = list1.Intersect(list2);
            Console.WriteLine(string.Join(" ", list3A));

            //Alternative Answer - not using linq

            var list3B = "";
            foreach (var item in list1)
            {
                if (list2.Contains(item))
                {
                    list3B += item + " ";
                }
            }
            Console.WriteLine(string.Join(" ", list3B));






            //b. Show the elements from list 1, but is not found in list2. E.g 1 2"

            var list4A = list1.Except(list2);
            Console.WriteLine(string.Join(" ", list4A));


            //Alternative Answer - not using linq

            var list4B = "";
            foreach (var item in list1)
            {
                if (!list2.Contains(item))
                {
                    list4B += item + " ";
                }
            }
            Console.WriteLine(string.Join(" ", list4B));




            //c. Complete here

            //Show the elements from list 2, but is not found in list1. E.g 6 7"

            var list5A = list2.Except(list1);
            Console.WriteLine(string.Join(" ", list5A));


            //Alternative Answer - not using linq

            var list5B = "";
            foreach (var item in list2)
            {
                if (!list1.Contains(item))
                {
                    list5B += item + " ";
                }
            }
            Console.WriteLine(string.Join(" ", list5B));






            Console.WriteLine("Press <ENTER> to continue");
            Console.ReadLine();
        }
    }
}
