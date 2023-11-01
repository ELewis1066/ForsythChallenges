using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    namespace Hard
    {
        public class Coins : Problem
        {
            public override string Name => "Hard.Coins";

            long CountNumberOfSolutions(int target, IEnumerable<int> coins)
            {
                var dp = new int[target + 1];
                dp[0] = 1;

                foreach (var coin in coins)
                {
                    for (var j = 0; j < dp.Length; j++)
                    {
                        if (coin <= j)
                            dp[j] += dp[(j - coin)];
                    }
                }
                return dp[target];
            }

            List<List<int>> CoinChangeWithCombinations(int target, IEnumerable<int> coins)
            {
                // We need a list of list to hold the solutions.
                List<List<int>> wallets = new List<List<int>>();

                // Initialize solution; each initial solution can have a single coin in it.
                foreach (var coin in coins)
                {
                    List<int> wallet = new List<int> { coin };
                    wallets.Add(wallet);
                }

                List<List<int>> newWallets = new List<List<int>>();
                List<List<int>> solutions = new List<List<int>>();

                while (wallets.Count > 0)
                {
                    foreach (var wallet in wallets)
                    {
                        var sum = wallet.Sum();
                        foreach (var coin in coins)
                        {
                            if (coin < wallet[^1]) continue;

                            if (sum + coin < target)
                            {
                                var newWallet = wallet.ToList();
                                newWallet.Add(coin);
                                newWallets.Add(newWallet);
                            }
                            else if (sum + coin == target)
                            {
                                var newWallet = wallet.ToList();
                                newWallet.Add(coin);
                                solutions.Add(newWallet);
                            }
                        }
                    }
                    wallets = newWallets;
                    newWallets = new List<List<int>>();
                }
                return solutions;
            }

            public override void Execute()
            {
                Console.WriteLine("Coin change Problem");
                Console.WriteLine("Enter comma separated list of coins, in pence e.g: 1, 2, 5, 10, 20, 50");
                string inCoins = Console.ReadLine();
                if (!string.IsNullOrEmpty(inCoins))
                {
                    Console.WriteLine("In pound and pence e.g. £1 or £1.50");
                    Console.Write("Enter number of £");
                    double targetPounds = Convert.ToDouble(Console.ReadLine());
                    int targetPence = (int)(targetPounds * 100);

                    var coins = inCoins.Replace(" ", string.Empty).Split(",").ToArray().Select(x => Convert.ToInt32(x));

                    var solutions = CoinChangeWithCombinations(targetPence, coins);
                    Console.WriteLine($"Your total of £{targetPounds} can be created in {solutions.Count} ways");
                    foreach (var solution in solutions)
                    {
                        solution.Sort();
                        var grouping = solution.GroupBy(x => x);
                        var output = grouping.Select(group => $"{group.Count()}x{group.Key}p");
                        Console.WriteLine(string.Join(",", output));
                    }
                }
            }
        }
    }
}
