using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Algorithm_Solver.Models;

namespace Algorithm_Solver.Controllers
{
    public class ScoreController : Controller
    {
        private readonly Algorithm_SolverContext _context;

        public ScoreController(Algorithm_SolverContext context)
        {
            _context = context;
        }

        // GET: Score
        public async Task<IActionResult> Index()
        {
            return View(await _context.Score.OrderBy(loss => loss.Losses).OrderByDescending(win => win.Wins).ToListAsync());
        }
    }
}
