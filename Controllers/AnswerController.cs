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
    public class AnswerController : Controller
    {
        IRepository<QuestionareEntity> _repo;
        IRepository<AnswerEntity> _answerRepo;
        public AnswerController(IRepository<QuestionareEntity> _repo, IRepository<AnswerEntity> _answerRepo)
        {
            this._repo = _repo;
            this._answerRepo = _answerRepo;
        }

        public JsonResult Save(int optionId, int questionId)
        {
            var answer = new AnswerEntity()
            {
                OptionId = optionId,
                QuestionId = questionId
            };

            var result = _answerRepo.Add(answer);

            return Json(result);
        }

        public JsonResult IncrementRespondendsNumber(int id)
        {
            _repo.IncrementQuestionareNumber(id);

            return Json("");
        }
    }
}
