using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Algorithm_Solver.Models;
using Microsoft.AspNetCore.Http;
using Algorithm_Solver.Repositories;

namespace Algorithm_Solver.Controllers
{
    public class SolutionController : Controller
    {
        private readonly Algorithm_SolverContext _context;

        public SolutionController(Algorithm_SolverContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            Solution solution = new Solution();
            solution.algorithmTasks = await _context.AlgorithmTask.ToListAsync();
            solution.status = Solution.Status.Initial;

            return View(solution);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> ValidateSolutionAsync(Solution model, int taskId)
        {
            Solution solution = new Solution();

            // In case user edits value from browser || .Any()
            solution.selectedTask = _context.AlgorithmTask.Find(taskId);

            using (var solutionRepository = new SolutionRepository(_context))
            {
                if (ModelState.IsValid && solution.selectedTask != null)
                {
                     solution = await solutionRepository.solveAlgorithm(model.code, taskId, model.nickName);
                }
                else
                {
                    solution.code = model.code;
                    solution.nickName = model.nickName;
                    solution.algorithmTasks = await _context.AlgorithmTask.ToListAsync();
                }
            }

            return View(nameof(Index), solution);

        }        
    }
}