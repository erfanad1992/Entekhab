using System.Linq.Expressions;

namespace Entekhab.Domain
{
    public interface IPersonInfoRepository
    {
        Task<PersonInfo> GetAsync(Guid id);
        Task<PersonInfo> GetAsync(Expression<Func<PersonInfo, bool>> predicate);
        Task<IList<PersonInfo>> GetListAsync(Expression<Func<PersonInfo, bool>> predicate);
        Task InsertAsync(PersonInfo personInfo);
        Task<bool> IsExistsAsync(Expression<Func<PersonInfo, bool>> predicate);
        void Remove(PersonInfo personInfo);

        Task SaveEntityChanges();


    }
}
