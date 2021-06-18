using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("INPUT INFORMATION\n================================");

                Console.Write("\nEnter ID: ");
                string id = Console.ReadLine();

                Console.WriteLine("\nEnter First Name: ");
                string firstName = Console.ReadLine();

                Console.WriteLine("\nEnter Last Name: ");
                string lastName = Console.ReadLine();

                Console.WriteLine("\nEnter Email");
                string email = Console.ReadLine();

                Console.WriteLine("\nEnter Phone Number: ");
                string phone = Console.ReadLine();

                Console.Write("\nEnter Date of Birth (mm/dd/yyyy): ");
                DateTime dateOfBarth = Convert.ToDateTime(Console.ReadLine());

                Console.Write("\nJoining Date (mm/dd/yyyy): ");
                DateTime JoiningDateTime = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("\nDESIGNATIONS:\n================================\n1. CEO\n2. President\n3. SoftwareEngineer\n4. TraineeEngineer\n5. ProjectManager\n6. SystemEngineer\n7. WebDeveloper\n8. QualityAnalyst");
                Console.Write("\nInput any one serial number of the designations given above: ");
                int deg = Int32.Parse(Console.ReadLine());

                Employee anEmployee = new Employee(id, firstName, lastName, email, phone, dateOfBarth, JoiningDateTime, deg);
                Console.Write("\nGive roles of the employee (Seperate by comma[,]): ");

                string[] roles = anEmployee.GetRole(Console.ReadLine());

                Console.WriteLine("\n\nOUTPUTS\n================================");
                Console.WriteLine("\nEmployee ID: " + anEmployee.ID + "\nName: " + anEmployee.GetFullName() + "\nDate of Birth: " +
                    anEmployee.dateOfBirth.ToShortDateString() + "\nJoining Date: " + anEmployee.JoiningDateTime.ToShortDateString() + "\nDesignation: " +
                    anEmployee.Designation + "\nAge: " + anEmployee.GetAge() + "\n\nRole plays:\n==========");

                for (int i = 0; i < roles.Length; i++)
                {
                    Console.WriteLine((i + 1).ToString() + ". " + roles[i].Trim());
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            doSalary();
            Console.ReadLine();
        }

        static void doSalary()
        {
            Console.WriteLine("\n\nSALARY CALCULATE: \n================================");
            Console.WriteLine("Input Basic Salary: ");
            var bs = Console.ReadLine();
            Salary s = new Salary();

            var bsReturn = s.CalculateSalary(Convert.ToInt32(bs));
            var overTime = s.CalculateSalary(Convert.ToInt32(bs));

            Console.WriteLine(">> Basic Salary:         {0}/= {1}", s.basicSalary, s.currency);
            Console.WriteLine(">> House Rent:           {0}/= {1}", s.housrRent, s.currency);
            Console.WriteLine(">> Medical Allowance:    {0}/= {1}", s.medicalAllowance, s.currency);
            Console.WriteLine(">> Conveyance Allowance: {0}/= {1}", s.conveyance, s.currency);
            Console.WriteLine(">> Over Time:            {0}/= {1}", overTime, s.currency);
            Console.WriteLine("......................................");
            Console.WriteLine("   Gross Salary:         {0}/= {1}", bsReturn, s.currency);
        }
    }
}
