using SolidCodeBase.Core.Models;

namespace SolidCodeBase.Core.Repositories
{
    

    public class UserRepository : BaseRepository<User>
    {
        public override void Add(User entity)
        {
            // Adding users
            base.Add(entity);
        }

        public override User Get(int id)
        {
            // User fetching operations
            return base.Get(id);
        }
    }
}