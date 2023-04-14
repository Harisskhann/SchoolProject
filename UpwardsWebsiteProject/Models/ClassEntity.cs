using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UpwardsWebsiteProject.Models
{
    public class ClassEntity
    {

        [Key]

        public int ClassId { get; set; }
        public int SchoolId { get; set; }

        public int BranchId { get; set; }

        public string ClassName { get; set; }

        [NotMapped]
        public string SchoolName { get; set; }

        [NotMapped]
        public string BranchName { get; set; }


    }
}
