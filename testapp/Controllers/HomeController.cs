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
            List<int> list = new List<int>();
            list.Add(2);
            return list;
        }

    }
}
