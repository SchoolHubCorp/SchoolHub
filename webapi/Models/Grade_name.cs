using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models
{
    public class Grade_name
    {
        public int grade_type_id { get; set; }
        public string type { get; set; }
    }
}