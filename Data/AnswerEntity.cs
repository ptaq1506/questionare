using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AnswerEntity : EntityBase
    {
        public string Answer { get; set; }
        public int QuestionId { get; set; }
        public int OptionId { get; set; }

        public virtual QuestionEntity Question { get; set; }
    }
}
