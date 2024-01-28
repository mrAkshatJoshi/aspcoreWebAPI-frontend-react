using System.ComponentModel.DataAnnotations;

namespace ReactAspCrud.Models
{
    public class Student
    {
        [Key]//using System.ComponentModel.DataAnnotations;
        public int id { get; set; }
        public string stname { get; set; }
        public string course { get; set; }

    }
}
