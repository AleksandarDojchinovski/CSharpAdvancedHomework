using Exercise03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03.Services
{
    public class AppService
    {

        public Computer computer = new();
        public User user = new();

        public void SelectMenu()
        {
            var userInput = 0;
            while (userInput != 3)
            {
                Console.Clear();
                Console.WriteLine("1. Play");
                Console.WriteLine("2. Stats");
                Console.WriteLine("3. Exit");

                 userInput = GetUserInput();
                switch (userInput)
                {
                    case 1:
                        Play();
                        break;
                    case 2:
                        Stats();
                        break;
                    case 3:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.ReadLine();
                        break;
                }
            }
        }
        public void Play() 
        {
            Console.WriteLine("Select: ");
            Console.WriteLine();
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissors");
            user.Rps = GetUserGame();
            computer.Rps = GetComputerRandom();
            
            Console.WriteLine($"Computer output: {computer.Rps}");
            Console.WriteLine($"Person output: {user.Rps}");

            Winner(user, computer);
            Console.ReadLine();
        }
        public  void Stats() 
        {
            Console.WriteLine($"User wins:{user.Score}");
            Console.WriteLine($"Computer wins: {computer.Score}");
            Console.WriteLine($"Draws: {user.Draw} ");
            var totalGames = user.Score + user.Draw + computer.Score;
            var percentage = user.Score/ (double)totalGames * 100;
            var losesPercentage = computer.Score / (double)totalGames * 100;
            Console.WriteLine($"Win percentage: {percentage} %");
            Console.WriteLine($"Losses percenage: {losesPercentage} %");

            Console.ReadLine();
        }
        private static RPS GetUserGame()
        {
            bool isNumber = int.TryParse(Console.ReadLine(), out int userInput);

            if (!isNumber || userInput > 3 || userInput < 1)
            {
                Console.WriteLine("Invalid input");
            }

            return (RPS)userInput;
        }
        private static int GetUserInput()
        {
            bool isNumber = int.TryParse(Console.ReadLine(), out int userInput);

            if (!isNumber || userInput > 3 || userInput < 1)
            {
                Console.WriteLine("Invalid input");
            }

            return userInput;
        }
        public static RPS GetComputerRandom()
        {
            Random random = new Random();
            var computerRandom = random.Next(1, 3);
            return (RPS)computerRandom;
        }

        public void Winner(User user, Computer computer)
        {
            if(user.Rps == computer.Rps)
            {
                Console.WriteLine("Draw");
                user.Draw++;
            }
            else if(user.Rps == RPS.Rock && computer.Rps == RPS.Paper)
            {
                computer.Score++;
                Console.WriteLine("The computer has won");
            }
            else if (user.Rps == RPS.Rock && computer.Rps == RPS.Scissors)
            {
                user.Score++;
                Console.WriteLine("You won");
            }
            else if (user.Rps == RPS.Paper && computer.Rps == RPS.Scissors)
            {
                computer.Score++;
                Console.WriteLine("The computer has won");
            }
            else if (user.Rps == RPS.Scissors && computer.Rps == RPS.Paper)
            {
                user.Score++;
                Console.WriteLine("You won");
            }
            else if (user.Rps == RPS.Paper && computer.Rps == RPS.Rock)
            {
                user.Score++;
                Console.WriteLine("You won");
            }
            else if (user.Rps == RPS.Scissors && computer.Rps == RPS.Rock)
            {
                computer.Score++;
                Console.WriteLine("The computer has won");
            }

        }
    }
}
