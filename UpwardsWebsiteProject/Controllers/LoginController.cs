using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using UpwardsWebsiteProject.Models;
using System.Linq;

namespace UpwardsWebsiteProject.Controllers
{
    public class LoginController : Controller
    {

        private readonly ProjectDbContext _Db;
        public LoginController(ProjectDbContext Db)

        {
            _Db = Db;
        }
        //public IActionResult LoginList()
        //{
        //    return View(_Db.tblLogin.ToList());
        //}
        //public async Task<IActionResult> Login(LoginEntity obj)
        //{
        //    return View(obj);
        //}


        public IActionResult LoginList(string username, string password)
        {
            // Validate the username and password
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ModelState.AddModelError(string.Empty, "Username and password are required.");
                return View();
            }

            // Authenticate the user
            if (AuthenticateUser(username, password))
            {
                // Redirect to the dashboard if the user is authenticated
                return RedirectToAction("SchoolList", "School");
            }

            // Display an error message if the authentication failed
            ModelState.AddModelError(string.Empty, "Invalid username or password.");
            return RedirectToAction("LoginList", "login");
            //return View();
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Replace this with your actual authentication logic
            var user = _Db.TblLogin.FirstOrDefault(u => u.UserName == username && u.Password == password);
            if (user != null)
            {
                // Authentication succeeded
                return true;
            }

            // Authentication failed
            return false;
        }








        public async Task<IActionResult> SaveLogin(LoginEntity obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (obj.LoginId == 0)
                    {
                        _Db.TblLogin.Add(obj);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(obj).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }

                    return RedirectToAction("LoginList");
                }

                return View(obj);
            }
            catch (Exception ex)
            {

                return RedirectToAction("LoginList");
            }
        }

        public async Task<IActionResult> DeleteLogin(int LoginId)
        {
            try
            {
                var item = await _Db.TblLogin.FindAsync(LoginId)

;
                if (item != null)
                {
                    _Db.TblLogin.Remove(item);
                    await _Db.SaveChangesAsync();
                }

                return RedirectToAction("LoginList");
            }
            catch (Exception ex)
            {

                return RedirectToAction("LoginList");
            }
            //        private readonly ProjectDbContext _Db;
            //        public LoginController(ProjectDbContext Db)
            //        {
            //            _Db = Db;
            //        }

            //        public IActionResult LoginPage()
            //        {

            //            try
            //            {


            //                var LoginPage = from a in _Db.TblLogin
            //                                 join b in _Db.tblSchool on a.SchoolId equals b.SchoolId
            //                                 //join c in _Db.tblStudent on a.StudentId equals c.StudentId
            //                                 //into Book
            //                                 //from b in Book.DefaultIfEmpty()




            //                                 select new LoginEntity
            //                                 {


            //                                     LoginId = a.LoginId,
            //                                     UserName = a.UserName,
            //                                     Password = a.Password,
            //                                     BranchPhone = a.BranchPhone,
            //                                     SchoolId = a.SchoolId,
            //                                     SchoolName = b == null ? "" : b.SchoolName,


            //                                 };


            //                return View(BranchList);
            //            }
            //            catch (Exception ex)
            //            {
            //                return View();

            //            }

            //        }

            //        //private IActionResult View(object value)
            //        //{
            //        //    throw new NotImplementedException();
            //        //}

            //        //public IActionResult CreateBranch(BranchEntity obj)
            //        //{
            //        //    return View(obj);
            //        //}


            //        //Method to Load Categories in Add Item View Page

            //        private async void loadSchool()
            //        {
            //            try
            //            {
            //                List<SchoolEntity> SchoolList = new List<SchoolEntity>();
            //                SchoolList = await _Db.tblSchool.ToListAsync();

            //                SchoolList.Insert(0, new SchoolEntity { SchoolId = 0, SchoolName = "Please Select" });

            //                ViewBag.SchoolList = SchoolList;

            //            }
            //            catch (Exception ex)
            //            {


            //            }
            //        }



            //        public async Task<IActionResult> AddBranch(BranchEntity obj)
            //        {
            //            loadSchool();
            //            return View(obj);
            //        }
            //        public async Task<IActionResult> SaveBranch(BranchEntity obj)
            //        {
            //            try
            //            {
            //                if (ModelState.IsValid)
            //                {
            //                    if (obj.BranchId == 0)
            //                    {
            //                        _Db.tblBranch.Add(obj);
            //                        await _Db.SaveChangesAsync();
            //                    }
            //                    else
            //                    {
            //                        _Db.Entry(obj).State = EntityState.Modified;
            //                        await _Db.SaveChangesAsync();
            //                    }

            //                    return RedirectToAction("BranchList");
            //                }

            //                return View(obj);
            //            }
            //            catch (Exception ex)
            //            {

            //                return RedirectToAction("BranchList");
            //            }
            //        }

            //        public async Task<IActionResult> DeleteBranch(int BranchId)
            //        {
            //            try
            //            {
            //                var item = await _Db.tblBranch.FindAsync(BranchId)

            //;
            //                if (item != null)
            //                {
            //                    _Db.tblBranch.Remove(item);
            //                    await _Db.SaveChangesAsync();
            //                }

            //                return RedirectToAction("BranchList");
            //            }
            //            catch (Exception ex)
            //            {

            //                return RedirectToAction("BranchList");
            //            }
            //        }

        }
    }
}
