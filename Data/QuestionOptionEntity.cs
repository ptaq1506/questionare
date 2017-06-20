using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class QuestionOptionEntity : EntityBase
    {
        public string OptionText { get; set; }
        public int QuestionId { get; set; }

        public virtual QuestionEntity Question { get; set; }
    }
}
