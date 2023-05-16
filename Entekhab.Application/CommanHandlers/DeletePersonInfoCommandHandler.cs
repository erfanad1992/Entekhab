using Entekhab.Applications.Commands;
using Entekhab.Domain;
using MediatR;

namespace Entekhab.Applications.CommanHandlers
{
    public class DeletePersonInfoCommandHandler : IRequestHandler<DeletePersonInfoCommand, Guid>
    {
        private readonly IPersonInfoRepository _repository;

        public DeletePersonInfoCommandHandler(IPersonInfoRepository repository)
        {
            _repository = repository;
        }
        public async Task<Guid> Handle(DeletePersonInfoCommand command, CancellationToken cancellationToken)
        {
            var personInfo =await _repository.GetAsync(command.Id);
            if (personInfo is null)
            {
                throw new Exception("موجودیت مورد نظر یافت نشد");

            }
            _repository.Remove(personInfo);

            return personInfo.Id;
        }
    }
}
