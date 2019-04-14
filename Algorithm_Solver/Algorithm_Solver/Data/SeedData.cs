using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Algorithm_Solver.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Algorithm_SolverContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Algorithm_SolverContext>>()))
            {
                if (context.AlgorithmTask.Any())
                {
                    return;
                }

                context.AlgorithmTask.AddRange(
                    new AlgorithmTask
                    {
                        Name = "Square",
                        Input = "5",
                        Output = "25"
                    },

                    new AlgorithmTask
                    {
                        Name = "Fibonacci",
                        Input = "9",
                        Output = "34"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
