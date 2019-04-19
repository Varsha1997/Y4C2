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
        [Route("/Survey/CreateSurvey/{NewThemeId:int}")]
        public async Task<ActionResult> CreateSurvey(int NewThemeId = 0)
        {
            var questionOne = Request.Form["QuestionOne"].ToString();
            var questionTwo = Request.Form["QuestionTwo"].ToString();
            var questionThree = Request.Form["QuestionThree"].ToString();
            var typeOne = Request.Form["typeOne"].ToString();
            var typeTwo = Request.Form["typeTwo"].ToString();
            var typeThree = Request.Form["typeThree"].ToString();


            var questions = new List<Questions>();

            var theme = await DBContext.AC.FirstOrDefaultAsync(ac => ac.Id == NewThemeId);

            /* var theme2 = DBContext.AC.ToList();
           var idSearch = 0;
            //for each them find its id, if the id matches the one passed above, s
            foreach(var item in theme2)
            {
                if(item.Id == NewThemeId)
                {
                    idSearch = item.Id;
                }
            }
            */
            var surveyOne = new Survey();

            AddContent AC = DBContext.AC.Find(NewThemeId);
            surveyOne.Theme = AC;
            surveyOne.addContentId = NewThemeId;
            //  surveyOne.Theme = DBContext.AC.Find(NewThemeId);
            //  surveyOne.Theme.Id = NewThemeId;
            //commented out because not working
            /*
            var surveyNew = new Survey
            {
                Theme = theme
            };
            */
            // DBContext.Add(surveyNew);
            DBContext.Add(surveyOne);
            await DBContext.SaveChangesAsync();


            Questions qOne = new Questions();
            Questions qTwo = new Questions();
            Questions qThree = new Questions();

            if (!string.IsNullOrWhiteSpace(questionOne))
            {
                qOne.Question = questionOne;
                qOne.Type = typeOne;
                qOne.SurveyId = surveyOne.Id; //surveyNew.Id;
                qOne.QNumber = 1;
            }
            if (!string.IsNullOrWhiteSpace(questionTwo))
            {


                qTwo.Question = questionTwo;
                qTwo.Type = typeTwo;
                qTwo.SurveyId = surveyOne.Id; //surveyNew.Id;
                qTwo.QNumber = 2;
            }

            if (!string.IsNullOrWhiteSpace(questionThree))
            {


                qThree.Question = questionThree;
                qThree.Type = typeThree;
                qThree.SurveyId = surveyOne.Id; //surveyNew.Id;
                qThree.QNumber = 3;
            }

            // surveyNew.Question = questions; 
            surveyOne.Question = questions;

            if (ModelState.IsValid)
            {

                if (!string.IsNullOrWhiteSpace(questionOne))
                    DBContext.Add(qOne);

                if (!string.IsNullOrWhiteSpace(questionTwo))
                {
                    DBContext.Add(qTwo);
                }

                if (!string.IsNullOrWhiteSpace(questionThree))
                {
                    DBContext.Add(qThree);
                }
                DBContext.SaveChanges();
            }

            else
            {
                throw new Exception();
            }

            return RedirectToAction("ViewSurvey", new { id = surveyOne.Id });//surveyNew.Id });
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

        [HttpGet]
        [Route("/Survey/ViewSurvey/{SurveyId:int}")]
        public ActionResult ViewSurvey(int SurveyId = 0)
        {

            ViewBag.SurveyId = SurveyId;

            return View(DBContext.Questions.ToList());
        }

        [Route("/Survey/CompleteSurvey/{ThemeId:int}")]
        public ActionResult CompleteSurvey(int themeId = 0)
        {
            /*
            //using theme(AC) id, find survey with matching theme id
            //after that survey is found get survey id and pass to view
            var surveys = DBContext.Survey.ToList();

            var surveyID = 0;
            foreach (var item in surveys)
            {

               // if (item.ThemeId == themeId)
               if(item.addContentId == themeId)
                {
                    ViewBag.Message = "The survey for this theme is displayed below!";
                    surveyID = item.Id;
                }

                else
                {
                    ViewBag.Message = "There is no Survey for this theme.";

                }   
            }
                ViewBag.SurveyID = surveyID;
            return View(DBContext.Questions.ToList());
            */
            return View();
        }
    }
}