using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("MovieId")]
        public virtual Movie MyMovie {get;set;}

        [ForeignKey("UserId")]
        public virtual User MyUser { get; set; }

        [ForeignKey("MovieId")]
        public virtual Expression MyExpression { get; set; }

    }
}
