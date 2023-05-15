using Entekhab.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Entekhab.Infrastructure.EfPersistance.PersonInfos
{
    public class PersonInfoRepository : IPersonInfoRepository
    {
        protected DbContext Context;
        protected DbSet<PersonInfo> DbSet;

        public PersonInfoRepository(DbContext context)
        {
            Context = context;
            DbSet = context.Set<PersonInfo>();
        }

        public async Task<PersonInfo> GetAsync(Guid id)
        {
           return await DbSet.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<PersonInfo> GetAsync(Expression<Func<PersonInfo, bool>> predicate)
        {
            return await DbSet.SingleOrDefaultAsync(predicate);

        }

        public async Task<IList<PersonInfo>> GetListAsync(Expression<Func<PersonInfo, bool>> predicate)
        {
            return await DbSet.Where(predicate).ToListAsync();
        }

        public async  Task InsertAsync(PersonInfo personInfo)
        {
            await  DbSet.AddAsync(personInfo);
        }

        public async Task<bool> IsExistsAsync(Expression<Func<PersonInfo, bool>> predicate)
        {
            return await DbSet.AnyAsync(predicate);
        }

        public  void Remove(PersonInfo personInfo)
        {
            DbSet.Remove(personInfo);
        }
    }
}
