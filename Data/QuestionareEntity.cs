
using System.Collections.Generic;

namespace Data
{
    public class QuestionareEntity : EntityBase
    {
        public QuestionareEntity()
        {
            this.Questions = new List<QuestionEntity>();
        }

        public string Name { get; set; }
        public int RespondendsNumber {get;set;}

        public virtual ICollection<QuestionEntity> Questions { get; set; }
    }
}
