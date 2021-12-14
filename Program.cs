using System;
using System.Linq;

namespace linqTutorial
{
    class Program
    {
        static void Main(string[] args)
        { var customers = new List<Customer>(
            new Customer { Id = 1 Name = "Amazon" },
           new Customer { Id = 2 Name = "Target" },
           new Customer { Id = 3 Name = "Microsoft" }
         };
        var orders = new List<Order>()
        {
            new Order {Id = 1, Description = "First Order", Sales = 1000, CustomerId=1},
            {Id = 2, Description = "Sec Order", Sales = 2000, CustomerId=3}
            {Id = 3, Description = "Third Order", Sales = 3000, CustomerId=2}
        };
        var CustOrd = from o in orders
                      join c from customers

                             on o.CustomerId equals c.Id
                      select new { o, c };
        foreach(var co in CustOrd)
            {Console.WriteLine($"{co.c.Name) | {co.o.Descrition} | {co.c.Sales}");}
        {
            int[] ints = new int[]
           {
                620, 849, 649, 989, 993, 524, 216, 173, 136, 482,
                842, 308, 251, 572, 150, 797, 611, 489, 934, 310,
                985, 764, 484, 816, 753, 925, 289, 231, 486, 761,
                621, 981, 103, 482, 917, 124, 276, 839, 476 ,789,
                582, 631, 841, 398, 521, 796, 199, 941, 782, 953,
                412, 362, 424, 336, 812, 344, 579, 570, 212, 483,
                250, 829, 835, 429, 833, 992, 657, 461, 782, 498,
                829, 648, 189, 579, 645, 584, 989, 254, 859, 321,
                991, 421, 151, 350, 687, 491, 568, 548, 403, 836,
                303, 104, 538, 426, 150, 843, 943, 864, 694, 639
           };
            Console.WriteLine($"Average is {ints.Average()}");
           // var sum = ints.Sum() - ints.Min() - ints.Max();
            //var avg = sum / (ints.Count() - 2.0);
            //Console.WriteLine($"Fingers crossed {avg}");
            //lambda way to order all numbers in desc order for values below avg
            // var lowInts = ints.Where(i => i < ints.Average()).OrderByDescending(i => i);
            // foreach (var i in lowInts)
            //Console.WriteLine($"{i}");

                        //TRYING TO ORDER BY DESC USING QUERE IS NOT WORKING
            //var queave = from v in ints
              //            where v < ints.Average()
                //          orderby v descending
             //             select v;
            //foreach (var a in queave)
           // { Console.WriteLine($"{queave}"); }



        }
    }
}