using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MainDbContext = WebApp.DbContexts.MainDbContext;
using User = WebApp.Entities.User;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        public List<User> Users { get; set; }
        private readonly MainDbContext _context;

        public IndexModel(MainDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            try
            {
                Users = await _context.Users.ToListAsync();
            }
            catch (Exception e)
            {
                // Placeholder error handling
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
