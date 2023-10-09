using Microsoft.EntityFrameworkCore;
using testapp.Enteties;

namespace testapp.DAL.Repositories
{
    public class UserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

      public  List<int> SelectAll()
        {
          List<User> users= _context.User.ToList();
           List<int> ints= new List<int>(); 
            foreach(User user in users)
            {
                ints.Add(user.Id);
            }
            return ints;
        }
    }
}
