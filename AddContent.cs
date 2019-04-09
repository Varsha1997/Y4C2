
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Y4C2.Models
{
    public class AddContent
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Video { get; set; }
        public string Audio { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Html)]
        public string BlogContent { get; set; }
        public string BlogTitle { get; set; }
        public string BlogAuthor { get; set; }
        public string ArchiveStatus { get; set; }

        public virtual IList<Survey> Survey { get; set; }


    }
}
