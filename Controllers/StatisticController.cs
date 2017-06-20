using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Data;
using aspnetcoreapp.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace aspnetcoreapp.Controllers
{
    public class StatisticController : Controller
    {
        private readonly IRepository<QuestionareEntity> _questionareRepo;
        private readonly IRepository<QuestionEntity> _questionRepo;

        public StatisticController(IRepository<QuestionareEntity> _repo, IRepository<QuestionEntity> _questionRepo)
        {
            this._questionareRepo = _repo;
            this._questionRepo = _questionRepo;
        }

        public ActionResult Index(int id)
        {
            return View(id);
        }

        // GET: Statistic
        public JsonResult GetByQuestionareId(int id)
        {
            var result = _questionareRepo.GetById(id);
            return Json(result);
        }

        public JsonResult GetStatByQuestionOption(int id)
        {
            var result = _questionRepo.GetStatisticByQuestionOption(id);
            return Json(result);
        }
    }
}
