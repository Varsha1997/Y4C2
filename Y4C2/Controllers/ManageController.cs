using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Y4C2.Models;
using Microsoft.AspNetCore.Http;
using System.Data;

namespace Y4C2.Controllers
{
    public class ManageController : Controller
    {
        AddContentDBContext DBcontext;
        public ManageController(AddContentDBContext context)
        {
            DBcontext = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult AddContent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddContent(AddContent add)
        {
            if (ModelState.IsValid)
            {
                DBcontext.Add(add);
                DBcontext.SaveChanges();

            }
            else
            {
                throw new Exception();
            }
            return RedirectToAction(nameof(PlayVideo), new { id = add.Id });
        }

        //public ViewResult PlayVideo() => View();

        public ActionResult PlayVideo(int id)
        {
            var video = DBcontext.AC.FirstOrDefault(ac => ac.Id == id);
            if (video == null)
            {
                throw new Exception("Video does not exist.");
            }

            return View(viewName: nameof(PlayVideo), model: video);
        }

        public ActionResult Survey()
        {
            ViewBag.Title = "Survey";
            return View();
        }

        public ActionResult CreateSurvey()
        {
            return View();
        }

        public ActionResult StudentDashboard()
        {
            ViewBag.sessionv = HttpContext.Session.GetString("User");
            return View();
        }

        public ActionResult ManageContent()
        {
            return View(DBcontext.AC.ToList());
        }

        public ActionResult ContentDetails(int id = 0)
        {
            return View(DBcontext.AC.Find(id));
        }

        public ActionResult DeleteContent(int id = 0)
        {
            return View(DBcontext.AC.Find(id));
        }

        [HttpPost, ActionName("DeleteContent")]
        public ActionResult DeleteConfirm(int id)
        {
            AddContent post = DBcontext.AC.Find(id);
            DBcontext.AC.Remove(post);
            DBcontext.SaveChanges();
            return RedirectToAction("ManageContent");
        }

        public ActionResult Archive(int id = 0)
        {
            return View(DBcontext.AC.Find(id));
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Archive(AddContent content)
        {
            DBcontext.Entry(content).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            DBcontext.SaveChanges();
            return RedirectToAction("ManageContent");

        }

        public ActionResult Edit(int id = 0)
        {
            return View(DBcontext.AC.Find(id));
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(AddContent content)
        {
            DBcontext.Entry(content).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            DBcontext.SaveChanges();
            return RedirectToAction("ManageContent");

        }



    }
}