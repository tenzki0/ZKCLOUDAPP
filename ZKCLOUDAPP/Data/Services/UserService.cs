using Microsoft.EntityFrameworkCore;

namespace ZKCLOUDAPP
{
    public class UserService : IUserService
    {
        private readonly DataBaseContext _context;

        public UserService(DataBaseContext context)
        {
            _context = context;
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Users.FirstOrDefaultAsync(user => user.Id == id);
            _context.Users.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<User> GetByAsync(int id)
        {
            var result = await _context.Users.FirstOrDefaultAsync(user => user.Id == id);
            return result;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            var result = await _context.Users.ToListAsync();
            return result;
        }

        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User> UpdateAsync(int id, User user)
        {
            await AddAsync(user);
            await DeleteAsync(id); 
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
