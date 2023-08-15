using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models
{
    public class Class_course_pupil_grades
    {
        public int class_course_pupil_grades_id { get; set; }
        public double grade { get; set; }
        public int semestr { get; set; }
        public int grade_name_grades_id { get; set; }
        public string course_class_course_class_id { get; set; }
        public int pupil_pupil_id { get; set; }
        public DateTime data { get; set; }
    }
}