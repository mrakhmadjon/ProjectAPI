using ProjectAPI.Models;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjectAPI.Service.interfaces
{
    public interface IUniverService
    {
        Task<UserModel> CreateAsync(UserModel model);
        Task<UserModel> GetAsync(Expression<Func<UserModel, bool>> predicate);
    }
}
