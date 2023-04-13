using System.ComponentModel.DataAnnotations;

namespace UpwardsWebsiteProject.Models
{
    public class ParentEntity
    {
        [Key]

        public int ParentId { get; set; }
        public string ParentName { get; set; }

        public string ParentPhone { get; set; }

        public string ParentCnic { get; set; }

        public int  StudentId { get; set;}

    }
}
