using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Y4C2.Models
{
    public class Survey
    {
        
        [Key]
        public int Id { get; set; }

       //[ForeignKey("Account")]
        //public int UserId { get; set; }

        //[ForeignKey("AC")]
        //public int ThemeId { get; set; }
        public int addContentId { get; set; }
        public IList<Questions> Question { get; set; }
        //public virtual IList<AddContent> Themes  { get; set; }
        public virtual AddContent Theme { get; set; }
        //public IList<Account> Users { get; set; }//
    }
}
