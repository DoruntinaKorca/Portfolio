using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Portfolio.Database;
using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PortfolioContext _context;

        public IndexModel(ILogger<IndexModel> logger, PortfolioContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IEnumerable<Project> Projects { get; set; }
        public async Task OnGet()
        {
            Projects = await _context.Projects.ToListAsync();
        }
    }
}
