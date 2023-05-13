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
            decimal transportation
            )
        {
            Id = id;
            Name = name;
            Family = family;
            Date = date;
            BasicSalary = basicSalary;
            Allowance = allowance;
            Transportation = transportation;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public DateTimeOffset Date { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Allowance { get; set; }
        public decimal Transportation { get; set; }

    }
}
