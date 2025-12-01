using ProgrammingCSharp0407.Interfaces;
using ProgrammingCSharp0407.Models;


namespace ProgrammingCSharp0407.Services
{
    internal class UserService : BaseService<User>
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
