using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Y4C2.Models;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.AspNetCore.Session;


namespace Y4C2.Controllers
{
    public class AccountController : Controller
    {
        AddContentDBContext DBcontext;
        public AccountController(AddContentDBContext context)
        {
            DBcontext = context;
        }
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignUp(Account add)
        {

            if (ModelState.IsValid)
            {
                DBcontext.Add(add);
                DBcontext.SaveChanges();
                ModelState.Clear();

                //ViewBag.Message = add.Username + " " + "successfully registered!";

            }
            //else
            //{
                //throw new Exception();
            //}

            return RedirectToAction(nameof(Login));
        }
        
        
        public IActionResult Login()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Account search, string returnUrl)
        {
            //ViewData["ReturnUrl"] = returnUrl;
            

            var usr = DBcontext.Account.Where(u => u.Username == search.Username && u.Password == search.Password).FirstOrDefault(); //Select(u => new { search.RoleId });

            //if (!String.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
            //return Redirect(returnUrl);

            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {

                if (!ModelState.IsValid && usr != null)
                {
                    if (usr.RoleId == 1)
                    {
                        return RedirectToAction(nameof(AdminDashboard));
                    }
                    else
                    {
                        //Console.WriteLine(usr);

                        //Session["Username"] = search.Username;
                        HttpContext.Session.SetString("User", search.Username);

                        return RedirectToAction(nameof(StudentDashboard));

                    }

                }
                else
                {
                    //return new BadRequestObjectResult(ModelState);
                    ModelState.AddModelError("", "Invalid username and/or password");
                    return View(search);
                }
            }

        }



        public ActionResult StudentDashboard()
        {
            //ViewBag.sessionv = HttpContext.Session.GetString("User");
            return View(DBcontext.AC.ToList());
        }

        public ActionResult AdminDashboard()
        {
            return View();
        }

    }
}