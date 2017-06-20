using aspnetcoreapp;
using aspnetcoreapp.Repositories;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DAL.Repositores
{
    public class QuestionRepository : IRepository<QuestionEntity>
    {
       private readonly DatabaseContext _db;

        public QuestionRepository(DatabaseContext db)
        {
            _db = db;
        }

        public QuestionEntity Add(QuestionEntity item)
        {
            var result = _db.Add(item);
            _db.SaveChanges();

            return result.Entity;
        }

        public void Delete(QuestionEntity item)
        {
            throw new NotImplementedException();
        }

        public void Edit(QuestionEntity item)
        {
            throw new NotImplementedException();
        }

        public IQueryable<QuestionEntity> FindBy(Expression<Func<QuestionEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public List<QuestionEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public QuestionEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int GetStatisticByQuestionOption(int id)
        {
            var result = _db.AnswerSet.Count(x => x.OptionId == id);

            return result;
        }

        public void IncrementQuestionareNumber(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}