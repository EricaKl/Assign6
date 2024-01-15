using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign6
{
    internal class MainClass
    {
        static void Main()
        {
            int employeeadd = 0;
            int choice = 0;
            Console.WriteLine("Employee required to add (OnContractBasis/OnPayRollBasis)");
            Console.WriteLine("Choose:");
            Console.WriteLine("1.OnContract");
            Console.WriteLine("2.OnPayRoll");
            choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    {
                        OnContractBasis contractBasis = new OnContractBasis();
                        Console.WriteLine("How many employees' you required to add ");
                        
                        employeeadd = int.Parse(Console.ReadLine());
                        for (int i = 0; i < employeeadd; i++)
                        {
                            contractBasis.Get();
                        }
                        Console.WriteLine("Added Employees'.........");
                        contractBasis.Display();
                        break;
                    }
                case 2: 
                    {
                        break;
                    }
            }
            //Console.WriteLine("How many Employees' you required to add  ");
            //employeeadd = int.Parse(Console.ReadLine());

            //Employee e = new Employee();
            //for(int i = 0; i < employeeadd; i++)
            //{
            //    e.Get();
            //}
            //Console.WriteLine();
            //Console.WriteLine("Employees' Addded ");
            //e.Display();
        }
    }
}
