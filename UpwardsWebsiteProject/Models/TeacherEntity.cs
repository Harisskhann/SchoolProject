using System.ComponentModel.DataAnnotations;

namespace UpwardsWebsiteProject.Models
{
    public class TeacherEntity
    {
        [Key]
        public int TeacherId { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string Gender { get; set; }

        public string Email { get; set; }

        public string Qualification { get; set; }

        public string Subjects { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        public string Experience { get; set; }

        public int SchoolId { get; set; }

        public int BranchId { get; set; }

       
    }

}
