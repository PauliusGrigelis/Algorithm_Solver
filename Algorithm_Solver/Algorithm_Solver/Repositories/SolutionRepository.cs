using Algorithm_Solver.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Algorithm_Solver.Repositories
{
    public class SolutionRepository : IDisposable
    {
        protected readonly Algorithm_SolverContext Context;
        private string responseString;

        public SolutionRepository(Algorithm_SolverContext context)
        {
            this.Context = context;
        }

        public AlgorithmTask findAlgorithmTaskById(int id)
        {
            return Context.AlgorithmTask.Find(id);
        }

        public JObject buildJson(string code, AlgorithmTask algorithmTask)
        {
            string json = JsonConvert.SerializeObject(new { language = "csharp", versionIndex = "2", clientId = "dd7ccab4d307574f22845f30196539c5",
                clientSecret = "3160598aed4b13b152867b03d946a6afb234af261cac4b547fc723a003a30823", script = code, stdin = algorithmTask.Input});

            return new JObject(JObject.Parse(json));
        }

        public async Task<Solution> solveAlgorithm(string code, int taskId, string nickName)
        {
            // TODO: consider constructor
            Solution solution = new Solution();
            solution.selectedTask = findAlgorithmTaskById(taskId);
            solution.algorithmTasks = Context.AlgorithmTask.ToList();
            solution.output = await postToCompileCode(code, solution.selectedTask);
            solution.code = code;
            solution.nickName = nickName;

            if (solution.output == solution.selectedTask.Output) { solution.status = Solution.Status.Success; }
            else { solution.status = Solution.Status.Error; }

            // Create or update score record
            Score score = Context.Score.Find(nickName);
            if (score == null)
            {
                score = new Score();
                score.NickName = nickName;
                if (solution.status == Solution.Status.Success) { score.Wins++; }
                else if (solution.status == Solution.Status.Error) { score.Losses++; }
                Context.Score.Add(score);
            }
            else
            {
                if (solution.status == Solution.Status.Success) { score.Wins++; }
                else if (solution.status == Solution.Status.Error) { score.Losses++; }
            }
            return solution;
        }


        public async Task<String> postToCompileCode(string code, AlgorithmTask algorithmTask)
        {

            var client = new HttpClient();
            HttpContent cont = new StringContent(JsonConvert.SerializeObject(buildJson(code, algorithmTask)), Encoding.UTF8, "application/json");

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("Host", "api.jdoodle.com");

            var response = await client.PostAsync("https://api.jdoodle.com/v1/execute", cont);
            responseString = await response.Content.ReadAsStringAsync();

            return JObject.Parse(responseString)["output"].ToString();

        }

        public void Dispose()
        {
            Context.SaveChanges();
            Context?.Dispose();
        }

    }
}
