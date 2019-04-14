using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Algorithm_Solver.Models
{
    public class Solution
    {
        public enum Status { Initial = 1, Success = 2, Error = 3 }

        public List<AlgorithmTask> algorithmTasks { get; set; }
        public AlgorithmTask selectedTask { get; set; }
        public Status status { get; set; }
        public string output { get; set; }
        public string code { get; set; }

        [Required(ErrorMessage = "Nickame is required")]
        public string nickName { get; set; }

    }
}
