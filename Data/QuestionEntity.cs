using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class QuestionEntity : EntityBase
    {
        public string Question { get; set; }
        public int Type { get; set; }
        public int QuestionareId { get; set; }

        public virtual QuestionareEntity Questionare { get; set; }
        public virtual ICollection<QuestionOptionEntity> QuestionOptions { get; set; }
        public virtual ICollection<AnswerEntity> Answers { get; set; }
    }
}
