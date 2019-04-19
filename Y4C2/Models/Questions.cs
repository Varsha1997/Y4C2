using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Y4C2.Models
{
    public class Questions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Survey")]
        public int SurveyId { get; set; }

        public string Question { get; set; }
        public string Type { get; set; }
        public int QNumber { get; set; }
        public IList<Answer> Answer {get; set;}
        public Survey Surveys { get; set; }
    }
}
