using System.Threading.Tasks;
using ShopMarket.Application.Service.Interfaces;
using ShopMarket.DataLayer.Context;
using ShopMarket.DataLayer.Entities.Account;
using ShopMarket.DataLayer.Repository;

namespace ShopMarket.Application.Service.Implementation
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<User> _userRepository;

        public UserService(IGenericRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }


        public async ValueTask DisposeAsync()
        {
            await _userRepository.DisposeAsync();
        }
    }
}