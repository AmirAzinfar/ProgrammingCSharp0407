
using ProgrammingInCshrpBaseBackend.Interfaces;
using ProgrammingInCshrpBaseBackend.Models;


namespace ProgrammingInCshrpBaseBackend.Services
{
    public class UserService : BaseService<User>
    {
        private List<User> users = new List<User>();
        public void Add(User user)
        {
            users.Add(user); 
        }
        public List<User> GetAll()
        {
            return users;
        }
            
    }
}
