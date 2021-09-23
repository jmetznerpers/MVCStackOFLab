using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoCStackOverflowLab.Models;

namespace FoCStackOverflowLab.Controllers
{
    public class QandA : Controller
    {
        public IActionResult Index()
        {            
            return View();
        }

        public IActionResult ViewQuestions()
        {
            List<Questions> quests = DAL.GetAllQuestions();
            return View(quests);
        }
        public IActionResult NewQuestion()
        {
            return View();
        }
        public IActionResult AddQuestion(Questions quest)
        {
            DAL.InsertQuestion(quest);
            return Redirect("/QandA/ViewQuestions");

        }
        public IActionResult ViewQuestion(int questid)
        {
            Questions questy = DAL.GetQuestion(questid);
            return View(questy);
        }
        public IActionResult EditQuestion(int questid)
        {
            Questions questy = DAL.GetQuestion(questid);
            return View(questy);
        }

        public IActionResult savequestion(Questions questy)
        {
            DAL.UpdateQuestion(questy);
            return Redirect($"/QandA/ViewQuestion?questid={questy.qid}");

        }
        public IActionResult ViewAnswer(int questid)
        {
            QuestionsAndAnswers qAns = DAL.GetQuestionsAndAnswers(questid);
            return View(qAns);
        }
        public IActionResult NewAnswer()
        {
            return View();
        }
        public IActionResult AddAnswer(QuestionsAndAnswer qanse)
        {
            int qid = qanse._quest.qid;
            DAL.InsertAnswer(qid);
            return Redirect("/QandA/ViewAnswer");
        }
    }
}
