using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models
{
    public class Homework
    {
        public int homework_id { get; set; }
        public byte[] homework_file { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime deadline { get; set; }
        public string course_class_course_class_id { get; set; }
    }
}