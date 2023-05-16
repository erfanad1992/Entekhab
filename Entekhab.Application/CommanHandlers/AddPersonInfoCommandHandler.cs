using Entekhab.Applications.Commands;
using Entekhab.Domain;
using Entekhab.OvetimePolicies;
using MediatR;

namespace Entekhab.Applications.CommanHandlers
{
    public class AddPersonInfoCommandHandler : IRequestHandler<AddPersonInfoCommand,Guid>
    {
        private readonly IPersonInfoRepository _repository;
        public AddPersonInfoCommandHandler(IPersonInfoRepository repository)
        {
            _repository = repository;
        }
        public async Task<Guid> Handle(AddPersonInfoCommand command, CancellationToken cancellationToken)
        {
          
            var salaryAfterTax = OvertimeCalculator.CalculateSalary(command.BasicSalary,command.Allowance,command.Transportation,command.Tax);
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
