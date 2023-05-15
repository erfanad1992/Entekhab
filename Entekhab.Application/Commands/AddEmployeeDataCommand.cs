﻿using MediatR;

namespace Entekhab.Applications.Commands
{
    public class AddEmployeeDataCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public DateTimeOffset Date { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Allowance { get; set; }
        public decimal Transportation { get; set; }
        public int tax { get; set; }
    }
}
