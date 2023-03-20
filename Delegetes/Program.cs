namespace Delegetes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emps = new Employee[]
            {
                new Employee {Id=1, Name="Issam A", Gendr="M", TotalSales=65000m},
                new Employee {Id=2,Name="Reem A",Gendr="F",TotalSales=50000m},
                new Employee {Id=3,Name="Suzn A",Gendr="F",TotalSales=65000m},
                new Employee {Id=4,Name="Nada A",Gendr="F",TotalSales=40000m},
                new Employee {Id=5,Name="Ali A",Gendr="M",TotalSales=42000m},
                new Employee {Id=6,Name="Hossam A",Gendr="M",TotalSales=30000m},
                new Employee { Id = 7, Name = "Suzn A", Gendr = "F", TotalSales = 16000m },
                new Employee { Id = 8, Name = "Suzn A", Gendr = "F", TotalSales = 15000m }
            };

            var report = new Report();
            report.ProcessEmployee(emps, "Employee with Sales >= $60000 ", e => e.TotalSales >= 60000m) ;
            report.ProcessEmployee(emps, "Employee with Sales $60000 > Sales > $30000 ", e => e.TotalSales >= 30000m && e.TotalSales < 60000m);
            report.ProcessEmployee(emps, "Employee with Sales < $30000 ", e => e.TotalSales < 30000m);


            Console.ReadKey();

        }

    }

}