using System.ComponentModel.DataAnnotations;

namespace UpwardsWebsiteProject.Models
{
    public class StudentEntity
    {
        [Key]
        public int StudentId { get; set; }

        public string Name { get; set; }

        public string FatherName { get; set; }

        public string FatherCnic { get; set; }

        public string Gender { get; set; }

        public string DOB { get; set; }

        public int Age { get; set; }

        public string Phone { get; set; }

        public string Landline { get; set; }

        public string Address { get; set; }

        public int SchoolId { get; set; }

        public int BranchId { get; set; }

        public int ClassId { get; set; }

        public int SectionId { get;set; }

    }
}
