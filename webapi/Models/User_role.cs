using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models
{
    public class User_role
    {
        public int user_role_id { get; set; }
        public int user_user_id { get; set; }
        public int role_role_id { get; set; }
    }
}