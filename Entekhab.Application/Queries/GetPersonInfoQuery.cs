using MediatR;

namespace Entekhab.Applications.Queries
{
    public class GetPersonInfoQuery : IRequest<GetPersonInfoQueryResult>
    {
        public Guid Id { get; set; }
    }
}
