using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADbox_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var facebookClient = new FacebookClient();
            var facebookService = new FacebookService(facebookClient);
            var getAccountTask = facebookService.GetAccountAsync(FacebookSettings.AccessToken);

            Task.WaitAll(getAccountTask);
            var account = getAccountTask.Result;
            Console.WriteLine($"{account.ID} {account.FirstName}");

            var postOnWallTask = facebookService.PostOnWallAsync(FacebookSettings.AccessToken, "Hello from C# .NET Core!");
            Task.WaitAll(postOnWallTask);
            Console.Read();
        }
    }
}
