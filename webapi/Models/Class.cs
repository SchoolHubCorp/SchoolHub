using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models
{
    public class Class
    {
        public int class_id { get; set; }
        public string classname { get; set; }
        public string plan { get; set; }
    }
}