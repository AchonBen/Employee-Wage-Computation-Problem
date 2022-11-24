using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class UC4_EmployeeWageSwitchCase
    {
        public static void EmployeeWage()
        {
            const int IS_PART_TIME = 1; //Constant Variables
            const int IS_FULL_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;  //Variables
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3); //Computation

            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    Console.WriteLine("Employee is Part Time");
                    break;

                case IS_FULL_TIME:
                    empHrs = 8;
                    Console.WriteLine("Employee is Full Time");
                    break;

                default:
                    empHrs = 0;
                    Console.WriteLine("Employee is Absent");
                    break;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage:" + empWage);
        }
    }
}
