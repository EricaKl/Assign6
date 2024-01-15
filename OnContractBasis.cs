using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign6
{
    public class OnContractBasis : Employee
    {
        public DateOnly ContractDate;
        public string Duration;
        public float Charges;
        List<OnContractBasis> list = new List<OnContractBasis>();

        public OnContractBasis()
        {
           // ContractDate;

        }
        //public OnContractBasis(DateOnly ContractDate, string Duration, float Charges ) 
        //{
        //    this.ContractDate = ContractDate;
        //    this.Duration = Duration;
        //    this.Charges = Charges; 
        //}

        public void Get()
        {

            base.Get();
            Console.WriteLine("Enter Contract date");
            ContractDate =DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Enter Duration");
            Duration = Console.ReadLine();
            Console.WriteLine("Enter Charges");
            Charges = float.Parse(Console.ReadLine());
            list.Add(new OnContractBasis
            {
                EmpId = EmpId,
                EmpName = EmpName,
                ReportingMgr = ReportingMgr,
                ContractDate = ContractDate,
                Duration = Duration,
                Charges = Charges         
            });
        }

        public void Display()
        {
            //base.Display();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"Employee Id {list[i].EmpId}");
                Console.WriteLine($"Employee Name {list[i].EmpName}");
                Console.WriteLine($"Reporting Manager {list[i].ReportingMgr}");
                Console.WriteLine($"Contract Date {list[i].ContractDate}");
                Console.WriteLine($"Duration is {list[i].Duration}");
                Console.WriteLine($"charges are {list[i].Charges}");
            }
            Console.WriteLine("Total no of employees" + list.Count);

        }

        
    }
}
