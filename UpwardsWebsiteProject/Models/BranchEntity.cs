


using System.ComponentModel.DataAnnotations;

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
     
    }
}
