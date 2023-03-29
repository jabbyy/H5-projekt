using H5_projekt_2023.Data;
using H5_projekt_2023.models;
using Microsoft.EntityFrameworkCore;

namespace H5_projekt_2023.Repo
{
    public class UserRepo
    {
        private readonly DatabaseContext _context;

        public UserRepo(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<List<UserInfo>> getAll(string UserId)
        {
            List<UserInfo> UserList = await _context.Users.Where(s => s.UserEmail == UserId).ToListAsync();
            return UserList;
        }
        public async Task<UserInfo> getSingle(int Id)
        {
            return await _context.Users.FindAsync(Id);
        }
        public async Task<UserInfo> DeleteItem(int Id)
        {
            var item = _context.Users.Find(Id);
            if(item != null) { _context.Users.Remove(item); await _context.SaveChangesAsync(); } return item;
        }

        public async Task<UserInfo> CreateItem(UserInfo userInfo)
        {
            try
            {
                _context.Users.Add(userInfo);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return userInfo;
        }
        public async Task<UserInfo> UpdateItem (int Id, UserInfo userInfo)
        {
            _context.Entry(userInfo).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return userInfo;
        }
    }
}
