namespace ZKCLOUDAPP
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetByAsync(int id);
        Task AddAsync(User user);
        Task<User> UpdateAsync(int id, User user);
        Task DeleteAsync(int id);
    }
}
