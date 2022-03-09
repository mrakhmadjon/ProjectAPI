using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Models;
using ProjectAPI.Service.interfaces;
using System.Threading.Tasks;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUniverService _univerService;
        public UserController(IUniverService univerService)
        {
            _univerService = univerService;
        }

        [HttpPost]
        public Task<UserModel> Create(UserModel user)
        {
            return _univerService.CreateAsync(user);
        }

        [HttpGet("{id}")]
        public Task<UserModel> Get(long id)
        {
            return _univerService.GetAsync(p => p.Id.Equals(id));
        }

    }
}
