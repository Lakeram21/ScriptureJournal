using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages_Scripture
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; } = default!;

        //added code for the Book Search
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Books  { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Book { get; set; }


        // Added stuff for the Note Search
        [BindProperty(SupportsGet = true)]
        public string NoteString { get; set; }

        public async Task OnGetAsync()
        {
            var scriptures = from s in _context.Scripture
                 select s;

            // IQueryable<string> genreQuery = from m in _context.Scripture
            //                         orderby m.Notes
            //                         select m.Notes;

            if (!string.IsNullOrEmpty(NoteString))
            {
                scriptures = scriptures.Where(s => s.Notes.Contains(NoteString));
            }
              if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.Book.Contains(SearchString));
            }

            Scripture = await scriptures.ToListAsync();
        }
    }
}
