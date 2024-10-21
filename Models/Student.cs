using System.ComponentModel.DataAnnotations;

namespace stuModel.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}