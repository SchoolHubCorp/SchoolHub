using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models
{
    public class Course_class
    {
        public string course_class_id { get; set; }
        public int course_course_id { get; set; }
        public int class_class_id { get; set; }
        public int user_user_id { get; set; }
    }
}