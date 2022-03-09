using ProjectAPI.Data.Contexts;
using ProjectAPI.Data.IRepositories;
using ProjectAPI.Models;

namespace ProjectAPI.Data.Repositories
{
    public class UniverRepository : GenericRepository<UserModel>, IUniverRepository
    {
        public UniverRepository(UniverDbContext dbContext) : base(dbContext)
        {

        }
    }
}
