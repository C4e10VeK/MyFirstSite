using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SiteKustiX.Models;
using SiteKustiX.Models.DataBase;

namespace SiteKustiX.Pages
{
    public class Index : PageModel
    {
        private readonly PostsContext _context;
        public IEnumerable<Posts> Postses { get; set; }

        public Index(PostsContext db)
        {
            _context = db;
        }

        public void OnGet()
        {
            var posts = _context.Postses.AsNoTracking().ToList();
            Postses = posts;
            Postses = Postses.Reverse();
        }
    }
}