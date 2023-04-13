using System.ComponentModel.DataAnnotations;

namespace UpwardsWebsiteProject.Models
{
    public class ClassEntity
    {

        [Key]

        public int ClassId { get; set; }
        public int SchoolId { get; set; }

        public int BranchId { get; set; }

        public string ClassName { get; set; }


    }
}
