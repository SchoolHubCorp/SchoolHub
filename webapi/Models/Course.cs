using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models
{
    public class Course
    {
        public int course_id { get; set; }
        public string name { get; set; }
    }
}