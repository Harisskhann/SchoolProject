using Microsoft.EntityFrameworkCore;

namespace UpwardsWebsiteProject.Models
{
    public class ProjectDbContext:DbContext
    {

        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {


        }

        public DbSet<SchoolEntity> tblSchool { get; set; }
        public DbSet<BranchEntity>tblBranch { get; set; }

        public DbSet<StudentEntity>tblStudent { get; set; }

        public DbSet<TeacherEntity> tblTeacher { get; set; }

        public DbSet<ClassEntity> tblClass { get; set; }

        public DbSet<ParentEntity> tblParent { get; set; }

        public DbSet<SectionEntity> tblSection { get; set; }

        public DbSet<SubjectsEntity> tblSubjects { get; set; }

        public DbSet<LoginEntity> TblLogin { get; set; }




    }


}

