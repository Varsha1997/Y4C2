using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Y4C2.Models;
using Microsoft.EntityFrameworkCore;

namespace Y4C2.Controllers
{
    public class SurveyController : Controller
    {
        AddContentDBContext DBContext;
        public SurveyController(AddContentDBContext context)
        {
            DBContext = context;
        }

        public IActionResult Index()
        {
            IList<Questions> questions = DBContext.Questions.Include(q => q.Surveys).ToList();
            return View(questions);
        }

        [HttpGet]
        public ActionResult CreateSurvey()
        {

            return View();
        }

        [HttpPost]
        public   ActionResult CreateSurvey(int NewThemeId = 0)
        {
            var questionOne = Request.Form["QuestionOne"].ToString();
            var questionTwo = Request.Form["QuestionTwo"].ToString();
            var questionThree = Request.Form["QuestionThree"].ToString();
            var typeOne = Request.Form["typeOne"].ToString();
            var typeTwo = Request.Form["typeTwo"].ToString();
            var typeThree = Request.Form["typeThree"].ToString();
            var surveyNew = new Survey();
            var questions = new List<Questions>();
            surveyNew.ThemeId = NewThemeId;

            if (questionOne != null)
            {
                questions.Add(new Questions
                {
                    Question = questionOne,
                    Type = typeOne,
                    SurveyId = surveyNew.Id
                });
            }

            if (questionTwo != null)
            {
                questions.Add(new Questions
                {
                    Question = questionTwo,
                    Type = typeTwo,
                    SurveyId = surveyNew.Id
                });
            }

            if (questionThree != null)
            {
                questions.Add(new Questions
                {
                    Question = questionThree,
                    Type = typeThree,
                    SurveyId = surveyNew.Id

                });
            }

            surveyNew.Question = questions;
            /**   if(ModelState.IsValid) 

               {
                   DBContext.Add(newSurvey);
                   DBContext.SaveChanges();
               }
           
               else
               {
                   throw new Exception();
               }*/
            return RedirectToAction("ViewSurvey", new { id =  surveyNew.Id});
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Questions newQuestion)
        {
            if (ModelState.IsValid)
            {
                DBContext.Add(newQuestion);
                DBContext.SaveChanges();

            }
            else
            {
                throw new Exception();
            }

            return RedirectToAction("ViewSurvey");
        }

        public ActionResult ViewSurvey()
        {
            return View();
        }
    }
}