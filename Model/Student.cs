using System.ComponentModel.DataAnnotations;

namespace BasicAPI.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RollNo { get; set; }
        public string MobileNo { get; set; }
        public string DOB { get; set; }


    }
}
