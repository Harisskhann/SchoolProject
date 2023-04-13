using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using UpwardsWebsiteProject.Models;
using System.Linq;
using System.Collections.Generic;

namespace UpwardsWebsiteProject.Controllers
{
    public class TeacherController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly ProjectDbContext _Db;
        public TeacherController(ProjectDbContext Db)
        {
            _Db = Db;
        }
        public IActionResult TeacherList()
        {
            return View(_Db.tblTeacher.ToList());
        }

        //public IActionResult CreateSchool(SchoolEntity obj)
        //{
        //    return View(obj);
        //}

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



        //public async Task<IActionResult> AddTeacher(TeacherEntity obj)
        //{
        //    loadSchool();
        //    return View(obj);
        //}
















        public async Task<IActionResult> AddTeacher(TeacherEntity obj)
        {
            loadSubjects();
            loadBranch();
            loadSchool();
            return View(obj);
        }






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

        private void loadSubjects()
        {
            try
            {
                List<SubjectsEntity> SubjectsList = new List<SubjectsEntity>();
                SubjectsList = _Db.tblSubjects.ToList();

                SubjectsList.Insert(0, new SubjectsEntity { SubjectId = 0, SubjectName = "Please Select" });

                ViewBag.SubjectsList = SubjectsList;

            }
            catch (Exception ex)
            {


            }
        }



        //public async Task<IActionResult> AddTeacher(TeacherEntity obj)
        //{
        //    loadSchool();
        //    return View(obj);
        //}
















        //public async Task<IActionResult> AddTeacher(TeacherEntity obj)
        //{
        //    loadBranch();
        //    return View(obj);
        //}
        public async Task<IActionResult> SaveTeacher(TeacherEntity obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (obj.TeacherId == 0)
                    {
                        _Db.tblTeacher.Add(obj);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(obj).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }

                    return RedirectToAction("TeacherList");
                }

                return View(obj);
            }
            catch (Exception ex)
            {

                return RedirectToAction("TeacherList");
            }
        }

        public async Task<IActionResult> DeleteTeacher(int TeacherId)
        {
            try
            {
                var item = await _Db.tblTeacher.FindAsync(TeacherId)

;
                if (item != null)
                {
                    object value = _Db.tblTeacher.Remove(item);
                    await _Db.SaveChangesAsync();
                }

                return RedirectToAction("TeacherList");
            }
            catch (Exception ex)
            {

                return RedirectToAction("TeacherList");
            }
        }
    }
}
