using Entekhab.Applications.Commands;
using Entekhab.Domain;
using Entekhab.OvetimePolicies;
using MediatR;
using System.Net.WebSockets;

namespace Entekhab.Applications.CommanHandlers
{
    public class UpdatePersonInfoCommandHandler : IRequestHandler<UpdatePersonInfoCommand,Guid>
    {
        private readonly IPersonInfoRepository _repository;

        public UpdatePersonInfoCommandHandler(IPersonInfoRepository repository)
        {
            _repository = repository;
        }
        public async Task<Guid> Handle(UpdatePersonInfoCommand command, CancellationToken cancellationToken)
        {
            var personInfo = await _repository.GetAsync(command.Id);
            if (personInfo == null)
            {
                throw new Exception("اطلاعات مورد نظر یافت نشد");
            }

            var salaryAfterTax = OvertimeCalculator.CalculateSalary(command.BasicSalary, command.Allowance, command.Transportation, command.Tax);

            personInfo.Update
                (
                command.Name,
                command.Family,
                command.Date,
                command.BasicSalary,
                command.Allowance,
                command.Transportation,
               salaryAfterTax
                );

           await _repository.SaveEntityChanges();

            return personInfo.Id;
        }
    }
}
