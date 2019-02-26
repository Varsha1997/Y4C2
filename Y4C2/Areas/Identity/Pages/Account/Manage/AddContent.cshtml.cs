using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Y4C2.Models;

namespace Y4C2.Areas.Identity.Pages.Account.Manage
{

    public class AddContentModel : PageModel
    {
        AddContentDBContext DBcontext;

        public AddContentModel (AddContentDBContext context)
        {
            DBcontext = context;
        }

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

        [HttpPost]
        public async Task<IActionResult> OnGetAsync(AddContent add)
        {
            if (ModelState.IsValid)
            {
                DBcontext.Add(add);
                DBcontext.SaveChanges();

            }
            else
            {
                throw new Exception();
            }
            return Redirect("/Identity/Account/Manage/PlayVideo");
            //return RedirectToAction(nameof("Identity/Account/Manage/PlayVideo"), new { id = add.Id });
        }

        //public ViewResult PlayVideo() => View();

        public async Task<ActionResult> OnPostAsync(int id)
        {
            var video = DBcontext.AC.FirstOrDefault(ac => ac.Id == id);
            if (video == null)
            {
                throw new Exception("Video does not exist.");
            }

            return Redirect("/Identity/Account/Manage/PlayVideo");

            //return Redirect(viewName: nameof(PlayVideo), model: video);
        }
    }
    }
