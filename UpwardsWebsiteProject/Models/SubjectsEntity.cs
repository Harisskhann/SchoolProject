using System;
using System.ComponentModel.DataAnnotations;

namespace UpwardsWebsiteProject.Models
{
    public class SubjectsEntity
    {

        [Key]
        public int SubjectId { get; set; }
        public String SubjectName { get; set; }


    }
}
