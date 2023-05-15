namespace Entekhab.OvetimePolicies
{
    public class OvertimeCalculator
    {
        public decimal CalcurlatorC(decimal baseSalary, decimal allowance)
        {
       
            return 0; 
        }

        public decimal CalcurlatorB(decimal baseSalary, decimal allowance)
        {
            
            return baseSalary + allowance;  
        }

        public decimal CalcurlatorA(decimal baseSalary, decimal allowance)
        {
      
            return 0;  
        }

        public decimal CalculateSalary(decimal baseSalary, decimal allowance, decimal transportation, decimal tax)
        {
            OvertimeCalculator overtimeCalculator = new OvertimeCalculator();

            decimal overtime = overtimeCalculator.CalcurlatorB(baseSalary, allowance);
            decimal taxedSalary = baseSalary + allowance + transportation - overtime;
            decimal salaryAfterTax = taxedSalary - (taxedSalary * tax);

            return salaryAfterTax;
        }

    }
}

