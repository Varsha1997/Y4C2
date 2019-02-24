using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
namespace Y4C2.Areas.Identity.Pages.Account.Manage
{
    public class AddContentModel : PageModel
    {
            public void OnGet()
            {
            }
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

        }
    }
    }
