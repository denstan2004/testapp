using Microsoft.AspNetCore.Mvc;
using testapp.DAL.Repositories;
using testapp.Enteties;

namespace testapp.Controllers
{
    [Route("Home")]
    public class HomeController:Controller
    {
        private readonly UserRepository userRepository;

        public HomeController(UserRepository userRepository)
        {    
            this.userRepository = userRepository;
        }

        [HttpGet("getAll/Clothes")]
        public List<int> getallInt()
        {
           return userRepository.SelectAll();
        }
        [HttpPost("add/User")]
        public void saveUser([FromBody] User user)
        {
             userRepository.Create(user);
          
        }

    }
}
