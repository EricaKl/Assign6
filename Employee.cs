namespace Assign6
{
    public class Employee
    {
        public int EmpId;
        public string EmpName;
        public string ReportingMgr;
        List<Employee> list = new List<Employee>();
        //List<Employee> Employees = new List<Employee>();

        //public Employee(int EmpId, string EmpName , string ReportingMgr)
        //{
        //    this.EmpId = EmpId;
        //    this.EmpName = EmpName;
        //    this.ReportingMgr = ReportingMgr;
        //}

        public Employee() { 
            EmpId = 1;
            EmpName = string.Empty;
            ReportingMgr = string.Empty;
        }
        public void Get()
        {
            Console.WriteLine("Enter Employee Id");
            EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            EmpName = Console.ReadLine();
            Console.WriteLine("Enter Reporting Manager");
            ReportingMgr = Console.ReadLine();
          
            //list.Add(new Employee
            //{
            //    EmpId = EmpId,
            //    EmpName = EmpName,
            //    ReportingMgr = ReportingMgr
            //});
        }

        //public void Display() 
        //{
        //    for (int i = 0; i<list.Count; i++)
        //    {
        //        Console.WriteLine($"Employee Id {list[i].EmpId}");
        //        Console.WriteLine($"Employee Name {list[i].EmpName}");
        //        Console.WriteLine($"Reporting Manager {list[i].ReportingMgr}");
        //    }
        //    Console.WriteLine("Total no of employees" + list.Count);
        //}
    }
}