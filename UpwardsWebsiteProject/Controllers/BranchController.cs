using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using UpwardsWebsiteProject.Models;
using System.Linq;
using System.Collections.Generic;

namespace UpwardsWebsiteProject.Controllers
{
    public class BranchController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly ProjectDbContext _Db;
        public BranchController(ProjectDbContext Db)
        {
            _Db = Db;
        }

        public IActionResult BranchList()
        {

            try
            {


                var BranchList = from a in _Db.tblBranch
                                 join b in _Db.tblSchool on a.SchoolId equals b.SchoolId
                                 //join c in _Db.tblStudent on a.StudentId equals c.StudentId
                                 //into Book
                                 //from b in Book.DefaultIfEmpty()




                                 select new BranchEntity
                                 {


                                     BranchId = a.BranchId,
                                     BranchName = a.BranchName,
                                     BranchAddress = a.BranchAddress,
                                     BranchPhone = a.BranchPhone,
                                     SchoolId = a.SchoolId,
                                     SchoolName = b == null ? "" : b.SchoolName,


                                 };


                return View(BranchList);
            }
            catch (Exception ex)
            {
                return View();

            }

        }

        //private IActionResult View(object value)
        //{
        //    throw new NotImplementedException();
        //}

        //public IActionResult CreateBranch(BranchEntity obj)
        //{
        //    return View(obj);
        //}


        //Method to Load Categories in Add Item View Page

        private async void loadSchool()
        {
            try
            {
                List<SchoolEntity> SchoolList = new List<SchoolEntity>();
                SchoolList =await _Db.tblSchool.ToListAsync();

                SchoolList.Insert(0, new SchoolEntity { SchoolId = 0, SchoolName = "Please Select" });

                ViewBag.SchoolList = SchoolList;

            }
            catch (Exception ex)
            {


            }
        }



        public async Task<IActionResult> AddBranch(BranchEntity obj)
        {
            loadSchool();
            return View(obj);
        }
        public async Task<IActionResult> SaveBranch(BranchEntity obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (obj.BranchId == 0)
                    {
                        _Db.tblBranch.Add(obj);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(obj).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }

                    return RedirectToAction("BranchList");
                }

                return View(obj);
            }
            catch (Exception ex)
            {

                return RedirectToAction("BranchList");
            }
        }

        public async Task<IActionResult> DeleteBranch(int BranchId)
        {
            try
            {
                var item = await _Db.tblBranch.FindAsync(BranchId)

;
                if (item != null)
                {
                    _Db.tblBranch.Remove(item);
                    await _Db.SaveChangesAsync();
                }

                return RedirectToAction("BranchList");
            }
            catch (Exception ex)
            {

                return RedirectToAction("BranchList");
            }
        }
    }
}
