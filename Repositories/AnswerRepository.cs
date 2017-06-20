using aspnetcoreapp;
using aspnetcoreapp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Data;

namespace DAL.Repositores
{
    public class AnswerRepository : IRepository<AnswerEntity>
    {
        private readonly DatabaseContext _db;

        public AnswerRepository(DatabaseContext db)
        {
            _db = db;
        }

        public AnswerEntity Add(AnswerEntity item)
        {
            var result = _db.Add(item);
            _db.SaveChanges();

            return result.Entity;
        }

        public void Delete(AnswerEntity item)
        {
            throw new NotImplementedException();
        }

        public void Edit(AnswerEntity item)
        {
            throw new NotImplementedException();
        }

        public IQueryable<AnswerEntity> FindBy(Expression<Func<AnswerEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public List<AnswerEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public AnswerEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int GetStatisticByQuestionOption(int id)
        {
            throw new NotImplementedException();
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
