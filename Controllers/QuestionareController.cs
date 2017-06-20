using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using aspnetcoreapp.Repositories;
using Data;

namespace aspnetcoreapp.Controllers
{
    public class QuestionareController : Controller
    {
        private readonly IRepository<QuestionareEntity> _questionareRepo;
        private readonly IRepository<QuestionEntity> _questionRepo;

        public QuestionareController(IRepository<QuestionareEntity> _repo, IRepository<QuestionEntity> _questionRepo)
        {
            this._questionareRepo = _repo;
            this._questionRepo = _questionRepo;
        }

        public ActionResult Add(string name)
        {
            var result = _questionareRepo.Add(new QuestionareEntity { Name = name, RespondendsNumber = 0 });

            return View(result);
        }

        public ActionResult Read(int id)
        {
            return View(id);
        }

        public JsonResult GetById(int id)
        {
            var result = _questionareRepo.GetById(id);
            return Json(result);
        }

        public JsonResult GetList()
        {
            var list = _questionareRepo.GetAll();
            return Json(list);
        }

        public JsonResult Save(int questionareId, int questionType, string question, string[] options)
        {
            var questionOptions = new List<QuestionOptionEntity>();

            foreach (var option in options)
            {
                questionOptions.Add(new QuestionOptionEntity { OptionText = option });
            }

            var result = _questionRepo.Add(new QuestionEntity { Question = question, QuestionareId = questionareId, Type = questionType, QuestionOptions = questionOptions });
            return Json("");
        }
    }
}
