namespace SolidCodeBase.Core.Interfaces
{
    public interface IBaseRepository<T>
    {
        void Add(T entity);
        T Get(int id);
    }
}