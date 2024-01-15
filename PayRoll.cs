using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assign6
{
    public class PayRoll : Employee
    {
        public DateTime JoiningDate;
        public double Exp;
        public double BasicSalary;
        public double da;
        public double hra;
       
        public PayRoll(DateTime JoiningDate, double Exp , double BasicSalary, double da, double hra)
        {
            this.JoiningDate = JoiningDate;
            this.Exp = Exp;
            this.BasicSalary = BasicSalary;
            this.da = da;
            this.hra = hra;
        }

        public void Get()
        {
            base.Get();
            Console.WriteLine("Enter Joining date");
            JoiningDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Exp");
            Exp = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter BasicSalary");
            BasicSalary = double.Parse(Console.ReadLine());
            da = CalcDa(Exp, BasicSalary);
            hra = CalcHra(Exp, BasicSalary);
           // CalcSal(Exp, out da, out hra); 
            //Console.WriteLine("Enter Da");
            //da = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Hra");
            //hra = double.Parse(Console.ReadLine());

        }

        public void Display()
        {
            Console.WriteLine($"Joining date {JoiningDate}");
            Console.WriteLine($"Exp is {Exp}");
            Console.WriteLine($"Basic Salary  {BasicSalary}");
            Console.WriteLine($"Da is {da}");
            Console.WriteLine($"Hra is {hra}");
        }

     
        public double CalcDa(double Exp, double BasicSalary)
        {
            double da = 0; 
            if(Exp > 10)
            {
                da = (10 / 100) * BasicSalary;
               // hra = (8.5 / 100) * BasicSalary;

            }
            else if(Exp > 7 && Exp < 10)
            {
                da = (7/100) * BasicSalary;
               // hra = (6.5/100) * BasicSalary;

            }
            else if(Exp > 5 && Exp < 7)
            {
                da = (4.1 / 100) * BasicSalary;
                //hra = (3.8 / 100) * BasicSalary;
            }
            else if(Exp < 5)
            {
                da = (1.9 / 100) * BasicSalary;
               // hra = (2.0 / 100) * BasicSalary;
            }
            return da;
             
        }

        public double CalcHra(double Exp, double BasicSalary)
        {
            double hra = 0;
            if (Exp > 10)
            {
                hra = (8.5 / 100) * BasicSalary;
            }
            else if (Exp > 7 && Exp < 10)
            {
                hra = (6.5 / 100) * BasicSalary;
            }
            else if (Exp > 5 && Exp < 7)
            {
                hra = (3.8 / 100) * BasicSalary;
            }
            else if (Exp < 5)
            {
                hra = (2.0 / 100) * BasicSalary;
            }
            return hra;

        }
    }
}
