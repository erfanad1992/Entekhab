namespace Entekhab.Domain
{
    public class PersonInfo
    {
        private PersonInfo()
        {

        }
        public PersonInfo(
            Guid id,
            string name,
            string family,
            DateTimeOffset date,
            decimal basicSalary,
            decimal allowance,
            decimal transportation,
            decimal salaryAfterTax)
        {
            Id = id;
            Name = name;
            Family = family;
            Date = date;
            BasicSalary = basicSalary;
            Allowance = allowance;
            Transportation = transportation;
            SalaryAfterTax = salaryAfterTax;
        }

      

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public DateTimeOffset Date { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Allowance { get; set; }
        public decimal Transportation { get; set; }
        public decimal SalaryAfterTax { get; set; }

        public void Update(
          string name,
          string family,
          DateTimeOffset date,
          decimal basicSalary,
          decimal allowance,
          decimal transportation,
          decimal salaryAfterTax
          )
        {
            Name = name;
            Family = family;
            Date = date;
            BasicSalary = basicSalary;
            Allowance = allowance;
            Transportation = transportation;
            SalaryAfterTax = salaryAfterTax;
        }


    }
}
