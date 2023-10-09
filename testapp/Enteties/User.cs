using System.ComponentModel.DataAnnotations;
using System.Data;

namespace testapp.Enteties
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

 //  [EnumDataType(typeof(Roles))]
 
 //       public Roles Role { get; set; }

   //     public List<int> Basket { get; set; }
    }
}
