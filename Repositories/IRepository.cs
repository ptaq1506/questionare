using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace aspnetcoreapp.Repositories
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        List<T> GetAll();
        int GetStatisticByQuestionOption(int id);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        T Add(T item);
        void Edit(T item);
        void Delete(T item);
        void Save();
        void IncrementQuestionareNumber(int id);
    }
}
