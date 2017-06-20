using aspnetcoreapp;
using aspnetcoreapp.Repositories;
using System;
using System.Linq;
using System.Linq.Expressions;
using Data;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DAL.Repositores
{
    public class QuestionareRepository : IRepository<QuestionareEntity>
    {
        private readonly DatabaseContext _db;

        public QuestionareRepository(DatabaseContext db)
        {
            _db = db;
        }

        public QuestionareEntity Add(QuestionareEntity item)
        {
            var result = _db.Add(item);
            _db.SaveChanges();

            return result.Entity;
        }

        public void Delete(QuestionareEntity item)
        {
            throw new NotImplementedException();
        }

        public void Edit(QuestionareEntity item)
        {
            _db.Update(item);
            _db.SaveChanges();
        }

        public IQueryable<QuestionareEntity> FindBy(Expression<Func<QuestionareEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public List<QuestionareEntity> GetAll()
        {
            return _db.QuestionareSet.ToList();
        }

        public QuestionareEntity GetById(int id)
        {
            var questionare = _db.QuestionareSet.Include(x => x.Questions).FirstOrDefault(x => x.Id == id);

            foreach (var question in questionare.Questions)
            {
                var q = _db.QuestionSet.Include(x => x.Answers).Include(x => x.QuestionOptions).FirstOrDefault(x => x.Id == question.Id);
                question.QuestionOptions = q.QuestionOptions;
                question.Answers = q.Answers;
            }

            return questionare;
        }

        public int GetStatisticByQuestionOption(int id)
        {
            throw new NotImplementedException();
        }

        public void IncrementQuestionareNumber(int id)
        {
            var questionare = _db.QuestionareSet.FirstOrDefault(x => x.Id == id);
            questionare.RespondendsNumber++;

            _db.SaveChanges();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
