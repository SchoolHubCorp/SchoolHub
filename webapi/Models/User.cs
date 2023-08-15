using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models
{
    public class User
    {
        public int user_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string plan { get; set; }
        public int access_code { get; set; }
        public int pesel { get; set; }
    }
}