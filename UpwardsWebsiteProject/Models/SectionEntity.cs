using System.ComponentModel.DataAnnotations;

namespace UpwardsWebsiteProject.Models
{
    public class SectionEntity
    {

        [Key]
        public int SectionId { get; set; }
        public int SchoolId { get; set; }

        public int BranchId { get; set; }

        public int ClassId { get; set; }

        public string SectionName { get; set; }

        public string ClassTeacher { get; set; }



    }
}
