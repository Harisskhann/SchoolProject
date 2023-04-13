using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace UpwardsWebsiteProject.Models
{
    public class SchoolEntity
    {
        [Key]
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }

        public string SchoolWebsite { get; set; }

        public string SchoolMail { get; set; }



    }
}
