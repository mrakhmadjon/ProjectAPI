using ProjectAPI.Data.IRepositories;
using ProjectAPI.Models;
using ProjectAPI.Service.interfaces;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjectAPI.Service.Services
{
    public class UniverService : IUniverService
    {
        private readonly IUniverRepository _univerRepository;
        public UniverService(IUniverRepository univerRepository)
        {
            _univerRepository = univerRepository;
        }

        public Task<UserModel> CreateAsync(UserModel model)
        {
            return _univerRepository.CreateAsync(model);
        }

        public Task<UserModel> GetAsync(Expression<Func<UserModel, bool>> predicate)
        {
            return _univerRepository.GetAsync(predicate);
        }
    }
}
