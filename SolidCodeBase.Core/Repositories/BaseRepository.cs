namespace SolidCodeBase.Core.Repositories
{
    public class BaseRepository<T>
    {
        public virtual void Add(T entity)
        {
            // Addition operations
        }

        public virtual T Get(int id)
        {
            // Fetch operations
            return default;
        }
    }
}