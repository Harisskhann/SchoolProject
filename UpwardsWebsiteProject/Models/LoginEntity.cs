using System.ComponentModel.DataAnnotations;

namespace UpwardsWebsiteProject.Models
{
    public class LoginEntity
    {
        [Key]

        public int LoginId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
