using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using UpwardsWebsiteProject.Models;
using System.Linq;
using System.Collections.Generic;

namespace UpwardsWebsiteProject.Controllers
{
    public class ParentController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly ProjectDbContext _Db;
        public ParentController(ProjectDbContext Db)
        {
            _Db = Db;
        }
        public IActionResult ParentList()
        {
            return View(_Db.tblParent.ToList());
        }

        //public IActionResult CreateSchool(SchoolEntity obj)
        //{
        //    return View(obj);
        //}

        private void loadStudent()
        {
            try
            {
                List<StudentEntity> StudentList = new List<StudentEntity>();
                StudentList = _Db.tblStudent.ToList();

                StudentList.Insert(0, new StudentEntity { StudentId = 0, Name = "Please Select" });

                ViewBag.StudentList = StudentList;

            }
            catch (Exception ex)
            {


            }
        }

        public async Task<IActionResult> AddParent(ParentEntity obj)
        {   loadStudent();
            return View(obj);
        }
        public async Task<IActionResult> SaveParent(ParentEntity obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (obj.ParentId == 0)
                    {
                        _Db.tblParent.Add(obj);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(obj).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }

                    return RedirectToAction("ParentList");
                }

                return View(obj);
            }
            catch (Exception ex)
            {

                return RedirectToAction("ParentList");
            }
        }

        public async Task<IActionResult> DeleteParent(int ParentId)
        {
            try
            {
                var item = await _Db.tblParent.FindAsync(ParentId);

                if (item != null)
                {
                    object value = _Db.tblParent.Remove(item);
                    await _Db.SaveChangesAsync();
                }

                return RedirectToAction("ParentList");
            }
            catch (Exception ex)
            {

                return RedirectToAction("ParentList");
            }
        }
    }
}

    

