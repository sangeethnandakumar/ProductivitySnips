using Contracts;
using Entities;
using Entities.Models;

namespace Repositorys
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(DataContext context) : base(context) { }

    }
}
