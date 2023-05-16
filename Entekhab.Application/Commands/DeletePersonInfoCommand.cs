using MediatR;

namespace Entekhab.Applications.Commands
{
    public class DeletePersonInfoCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
    }
}
