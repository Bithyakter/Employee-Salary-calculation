using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    public class Salary
    {
        public float basicSalary;
        public float housrRent;
        public float medicalAllowance;
        public float conveyance;

        double  bsPercent;
        double hrPercent;
        double maPercent;
        double caPercent;

        /*--------Overtime Calculate---------*/
        public float overtime;    
        public double overtimeRet;
        public double totalOvertimeRet;

        public double CalculateSalary(float basicSalary)
        {
            this.bsPercent = 0.50;       //50 % Basic salary
            this.hrPercent = 0.20;       //20% House Rent
            this.maPercent = 0.25;       //25% Medical Allowance
            this.caPercent = 0.05;       //5% Conveyance

            this.basicSalary = basicSalary;
            this.housrRent = Convert.ToInt32(basicSalary * hrPercent);
            this.medicalAllowance = Convert.ToInt32(basicSalary * maPercent);
            this.conveyance = Convert.ToInt32(basicSalary * caPercent);
            var totalSalary = this.basicSalary + this.housrRent + this.medicalAllowance + this.conveyance;
            this.currency = Currency.BDT;
            return totalSalary;
        }

        public double CalculateByOverTime(double overtime)
        {
            this.overtime = basicSalary;
            var ot = (((overtime / 30) / 8) * 2 * 8);
            return ot;
        }

        public Currency currency;
    }
    public enum Currency
    {
        BDT, RS, USD, ERO, CNY, YEN
    }
}
