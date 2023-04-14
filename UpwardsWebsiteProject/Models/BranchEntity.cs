


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UpwardsWebsiteProject.Models
{
    public class BranchEntity
    {
        [Key]

        public int BranchId { get; set; }
        public string BranchName { get; set; }

        public string BranchAddress { get; set; }

        public string BranchPhone { get; set; }

        public int SchoolId { get; set; }

        [NotMapped]
        public string SchoolName { get; set; }

    }
}
