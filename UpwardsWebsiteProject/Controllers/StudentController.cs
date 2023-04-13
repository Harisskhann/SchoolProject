using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using UpwardsWebsiteProject.Models;
using System.Linq;
using System.Collections.Generic;

namespace UpwardsWebsiteProject.Controllers
{
    public class StudentController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly ProjectDbContext _Db;
        public StudentController(ProjectDbContext Db)
        {
            _Db = Db;
        }
        public IActionResult StudentList()
        {
            return View(_Db.tblStudent.ToList());
        }

        //public IActionResult CreateSchool(SchoolEntity obj)
        //{
        //    return View(obj);
        //}

        //private void loadStudent()
        //{
        //    try
        //    {
        //        List<StudentEntity> StudentList = new List<StudentEntity>();
        //        StudentList = _Db.tblStudent.ToList();

        //        StudentList.Insert(0, new StudentEntity { StudentId = 0, Name = "Please Select" });
        //        //StudentList.Insert(0, new StudentEntity { StudentId = 0, FatherName = "Please Select" });
        //        //StudentList.Insert(0, new StudentEntity { StudentId = 0, Gender = "Please Select" });

        //        ViewBag.StudentList = StudentList;

        //    }
        //    catch (Exception ex)
        //    {


        //    }
        //}

      



        private void loadBranch()
        {
            try
            {
                List<BranchEntity> BranchList = new List<BranchEntity>();
                BranchList = _Db.tblBranch.ToList();

                BranchList.Insert(0, new BranchEntity { BranchId = 0, BranchName = "Please Select" });

                ViewBag.BranchList = BranchList;

            }
            catch (Exception ex)
            {


            }
        }

        private void loadSchool()
        {
            try
            {
                List<SchoolEntity> SchoolList = new List<SchoolEntity>();
                SchoolList = _Db.tblSchool.ToList();

                SchoolList.Insert(0, new SchoolEntity { SchoolId = 0, SchoolName = "Please Select" });

                ViewBag.SchoolList = SchoolList;

            }
            catch (Exception ex)
            {


            }
        }

        private void loadClass()
        {
            try
            {
                List<ClassEntity> ClassList = new List<ClassEntity>();
                ClassList = _Db.tblClass.ToList();

                ClassList.Insert(0, new ClassEntity { ClassId = 0, ClassName = "Please Select" });

                ViewBag.ClassList = ClassList;

            }
            catch (Exception ex)
            {


            }
        }

        private void loadSection()
        {
            try
            {
                List<SectionEntity> SectionList = new List<SectionEntity>();
                SectionList = _Db.tblSection.ToList();

                SectionList.Insert(0, new SectionEntity { SectionId = 0, SectionName = "Please Select" });

                ViewBag.SectionList = SectionList;

            }
            catch (Exception ex)
            {


            }
        }


        public async Task<IActionResult> AddStudent(StudentEntity obj)
        {
            
            loadSchool();
            loadBranch();
            loadClass();
            loadSection();
            
            return View(obj);
        }
        public async Task<IActionResult> SaveStudent(StudentEntity obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (obj.StudentId == 0)
                    {
                        _Db.tblStudent.Add(obj);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(obj).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }

                    return RedirectToAction("StudentList");
                }

                return View(obj);
            }
            catch (Exception ex)
            {

                return RedirectToAction("StudentList");
            }
        }

        public async Task<IActionResult> DeleteStudent(int StudentId)
        {
            try
            {
                var item = await _Db.tblStudent.FindAsync(StudentId)

;
                if (item != null)
                {
                    object value = _Db.tblStudent.Remove(item);
                    await _Db.SaveChangesAsync();
                }

                return RedirectToAction("StudentList");
            }
            catch (Exception ex)
            {

                return RedirectToAction("StudentList");
            }
        }
    }


}
