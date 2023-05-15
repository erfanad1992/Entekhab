using Entekhab.Applications.Commands;
using Entekhab.Domain;
using Entekhab.OvetimePolicies;
using MediatR;

namespace Entekhab.Applications.CommanHandlers
{
    public class AddEmployeeDataCommandHandler : IRequestHandler<AddEmployeeDataCommand,Guid>
    {
        private readonly IPersonInfoRepository _repository;
        public AddEmployeeDataCommandHandler(IPersonInfoRepository repository)
        {
            _repository = repository;
        }
        public async Task<Guid> Handle(AddEmployeeDataCommand command, CancellationToken cancellationToken)
        {
            OvertimeCalculator overtimeCalculator= new OvertimeCalculator();
             var salaryAfterTax =   overtimeCalculator.CalculateSalary(command.BasicSalary,command.Allowance,command.Transportation,command.tax);
            var personInfo = new PersonInfo
                (
                Guid.NewGuid(),
                command.Name,
                command.Family,
                command.Date,
                command.BasicSalary,
                command.Allowance,
                command.Transportation,
                salaryAfterTax
                );
           await _repository.InsertAsync( personInfo );
            return personInfo.Id;
        }
    }
}
