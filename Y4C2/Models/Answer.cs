using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Y4C2.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        public string Response { get; set; }
        [ForeignKey("Questions")]
        public int QuestionId { get; set; }

        public virtual Questions Question { get; set; }
        public Account User { get; set; }
    }
    }



