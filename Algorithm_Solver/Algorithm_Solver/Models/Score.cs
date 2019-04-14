using System.ComponentModel.DataAnnotations;

namespace Algorithm_Solver.Models
{
    public class Score
    {
        [Key]
        public string NickName { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
    }
}
