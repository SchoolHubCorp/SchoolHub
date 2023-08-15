using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models
{
    public class Parent_child
    {
        public int parent_child_id { get; set; }
        public int parent_user_id { get; set; }
        public int child_user { get; set; }
   }
}