using System;

namespace Delegetes
{
    public class Report
    {
        //delegate المفوض
        public delegate bool IllegibleSales(Employee e);
        public void ProcessEmployee(Employee[] employees, string title, IllegibleSales isillegible)
        {
            Console.WriteLine(title);
            Console.WriteLine("-----------------------------");

            foreach(var e in employees)
            {
                if(isillegible(e))
                {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.Gendr} | ${e.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }
        
    }
}
