using Microsoft.EntityFrameworkCore;

namespace Algorithm_Solver.Models
{
    public class Algorithm_SolverContext : DbContext
    {
        public Algorithm_SolverContext (DbContextOptions<Algorithm_SolverContext> options)
            : base(options)
        {
        }

        public DbSet<AlgorithmTask> AlgorithmTask { get; set; }
        public DbSet<Score> Score { get; set; }

    }
}
