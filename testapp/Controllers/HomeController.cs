using Microsoft.AspNetCore.Mvc;
using testapp.DAL.Repositories;

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
            List<int> result = new List<int>();
            result.Add(1);
            return result;
        }

    }
}
