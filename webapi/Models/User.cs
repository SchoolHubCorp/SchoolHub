using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models
{
    [Table("school.user")]
    public class User
    {
        public int user_id { get; set; }
        public string first_name { get; set; }
    }
}
