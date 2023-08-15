using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models
{
    public class Pupil
    {
        public int pupil_id { get; set; }
        public int user_user_id { get; set; }
        public int class_class_id { get; set; }
    }
}