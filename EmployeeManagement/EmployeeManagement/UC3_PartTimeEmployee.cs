using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class UC3_PartTimeEmployee
    {
        public static void EmployeeWage()
        {
            //Constant
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            //Variables
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();   //Computations
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_TIME)
            {
                empHrs = 8;
                Console.WriteLine("Employee is PartTime");
            }
            else if (empCheck == IS_FULL_TIME)
            {
                empHrs = 16;
                Console.WriteLine("Employee is FullTime");
            }
            else
            {
                empHrs = 0; //Default
                Console.WriteLine("Employee is Absent");
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage:" + empWage);
        }
    }
}
