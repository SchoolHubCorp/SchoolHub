using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models
{
    public class Homework_pupil
    {
        public string homework_pupil_id { get; set; }
        public byte[] file { get; set; }
        public int homework_homework_id { get; set; }
        public int pupil_pupil_id { get; set; }
        public int course_class_pupil_grades_class_id { get; set; }
    }
}