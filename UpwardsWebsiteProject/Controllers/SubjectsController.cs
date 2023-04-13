using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using UpwardsWebsiteProject.Models;
using System.Linq;
using System.Collections.Generic;

namespace UpwardsWebsiteProject.Controllers
{
    public class SubjectsController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly ProjectDbContext _Db;
        public SubjectsController(ProjectDbContext Db)
        {
            _Db = Db;
        }
        public IActionResult SubjectsList()
        {
            return View(_Db.tblSubjects.ToList());
        }

        //private IActionResult View(object value)
        //{
        //    throw new NotImplementedException();
        //}

        //public IActionResult CreateBranch(BranchEntity obj)
        //{
        //    return View(obj);
        //}

        private void loadSubject()
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

        public async Task<IActionResult> AddSubjects(SubjectsEntity obj)
        {
            loadSubject();
            return View(obj);
        }
        public async Task<IActionResult> SaveSubjects(SubjectsEntity obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (obj.SubjectId == 0)
                    {
                        _Db.tblSubjects.Add(obj);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(obj).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }

                    return RedirectToAction("SubjectsList");
                }

                return View(obj);
            }
            catch (Exception ex)
            {

                return RedirectToAction("SubjectsList");
            }
        }

        public async Task<IActionResult> DeleteSubjects(int SubjectId)
        {
            try
            {
                var item = await _Db.tblSubjects.FindAsync(SubjectId)

;
                if (item != null)
                {
                    _Db.tblSubjects.Remove(item);
                    await _Db.SaveChangesAsync();
                }

                return RedirectToAction("SubjectsList");
            }
            catch (Exception ex)
            {

                return RedirectToAction("SubjectsList");
            }
        }
    }
}
