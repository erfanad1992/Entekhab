using System.Linq.Expressions;

namespace Entekhab.Domain
{
    public interface IPersonInfoReadRepository
    {
        Task<PersonInfo> GetAsync(Guid id);

        Task<List<PersonInfo>> GetListAsync(string name, string family, DateTimeOffset startDate , DateTimeOffset endDate);
    }
}
