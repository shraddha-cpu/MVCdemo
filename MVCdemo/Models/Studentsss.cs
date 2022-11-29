using System.ComponentModel.DataAnnotations;

namespace MVCdemo.Models
{
    public class Studentsss
    {
        [Required(ErrorMessage ="Rollno is requied")]
        [Display(Name = "Roll No")]
        public  int RollNO { get; set; }

        [Required(ErrorMessage = "Name is requied")]
        [MaxLength(40,ErrorMessage ="name must have less than 40 character")]
        [Display(Name = "Student name")]

        public string? Name { get; set; }

        [Required(ErrorMessage = "Email is requied")]
        [DataType(DataType.EmailAddress,ErrorMessage ="email is not in proper format")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Age is requied")]
        [Range(18,60,ErrorMessage ="age is must in between 18 to 60")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Password is requied")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
