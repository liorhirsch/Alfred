using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class UserExperience
    {
        public int MovieId { get; set; }
        public int UserId { get; set; }
        public int ExpressionId { get; set; }
        public int Precentage { get; set; }


        public virtual Movie MyMovie {get;set;}

        public virtual User MyUser { get; set; }

        public virtual Expression MyExpression { get; set; }

    }
}
