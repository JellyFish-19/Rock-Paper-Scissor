using System;
using System.Diagnostics;

namespace RockPaperScissors
{
    class GameScreen 
    {
        private int _playerScore;
        private int _computerScore;

        public void Game (int input)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                __..,,... .,,,,,.               ");
            Console.WriteLine("            ''''        ,'        ` .           ");
            Console.WriteLine("                      ,'  ,.  ..      `  .      ");
            Console.WriteLine("                      `.,'      ..           `  ");
            Console.WriteLine("            __..,.             .  ..     .      ");
            Console.WriteLine("                   ` .       .  `.  .` `        ");
            Console.WriteLine("                       ,  `.  `.  `._|,..       ");
            Console.WriteLine("                         .  `.  `..'            ");
            Console.WriteLine("                          ` -'`''               ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Random random = new Random();
            _playerScore = 0;
            _computerScore = 0;
            int roundsPlayed = 0;

            while (roundsPlayed < input)
            {
                Console.WriteLine("\n");
                Console.WriteLine("       ---------------------------------------     ");
                Console.WriteLine("       | 1: Rock  |  2: Paper |  3: Scissors |     ");
                Console.WriteLine("       ---------------------------------------     ");
                Console.WriteLine("\n");

                Start:
                string playerChoiceValue = Console.ReadLine();

                if (!int.TryParse(playerChoiceValue, out int playerChoice))
                {
                    Console.Write("Wrong input, please try again: ");
                    goto Start;
                }
  
                int computerChoice = random.Next(1, 4);

                if (playerChoice == 1 && computerChoice == 1)
                {
                    Console.Clear();
                    roundsPlayed++;
                    ScoreBoard(_playerScore, _computerScore);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("             _.-._                _.-._        ");
                    Console.WriteLine("            | | | |-.            | | | |-.     ");
                    Console.WriteLine("           /|     ` |           / )|_|_|_|     ");
                    Console.WriteLine("          | |       |          | |-^-^-^-'     ");
                    Console.WriteLine("          |         |          |     ||  |     ");
                    Console.WriteLine("          \\         /          \\     '   /   ");
                    Console.WriteLine("           |       |            |       |      ");
                    Console.WriteLine("           |       |            |       |      ");
                    Console.WriteLine();
                    Console.WriteLine("                        DRAW                   ");
                }

                else if (playerChoice == 1 && computerChoice == 2)
                {
                    Console.Clear();
                    roundsPlayed++;
                    _computerScore++;
                    ScoreBoard(_playerScore, _computerScore);
                    Console.WriteLine("                                   .-.         ");
                    Console.WriteLine("                                 .-| |-.       ");
                    Console.WriteLine("                                 | | | |       ");
                    Console.WriteLine("                                 | | | |-.     ");
                    Console.WriteLine("             _.-._               | | | | |     ");
                    Console.WriteLine("            | | | |-.            |_|_|_| |     ");
                    Console.WriteLine("           /|     ` |           / )    `-|     ");
                    Console.WriteLine("          | |       |          | | `--   |     ");
                    Console.WriteLine("          |         |          |     ||  |     ");
                    Console.WriteLine("          \\         /          \\    '    /   ");
                    Console.WriteLine("           |       |            |       |      ");
                    Console.WriteLine("           |       |            |       |      ");
                    Console.WriteLine();                                              
                    Console.WriteLine("                        LOST                   ");
                }

                else if (playerChoice == 1 && computerChoice == 3)
                {
                    Console.Clear();
                    roundsPlayed++;
                    _playerScore++;
                    ScoreBoard(_playerScore, _computerScore);
                    Console.WriteLine("                                        _      ");
                    Console.WriteLine("                               _       /<)     ");
                    Console.WriteLine("                              (>\\     / /     ");
                    Console.WriteLine("                               \\ \\   / /     ");
                    Console.WriteLine("             _.-._              \\ \\ / /      ");
                    Console.WriteLine("            | | | |-.            \\_V_/ Y-.    ");
                    Console.WriteLine("           /|     ` |           / )  |_|_|     ");
                    Console.WriteLine("          | |       |          | |   `-^-'     ");
                    Console.WriteLine("          |         |          |     ||  |     ");
                    Console.WriteLine("          \\         /          \\     '   /   ");
                    Console.WriteLine("           |       |            |       |      ");
                    Console.WriteLine("           |       |            |       |      ");
                    Console.WriteLine();
                    Console.WriteLine("                        WON                    ");
                }

                else if (playerChoice == 2 && computerChoice == 1)
                {
                    Console.Clear();
                    roundsPlayed++;
                    _playerScore++;
                    ScoreBoard(_playerScore, _computerScore);
                    Console.WriteLine("              .-.                              ");
                    Console.WriteLine("            .-|U|-.                            ");
                    Console.WriteLine("            |U| |U|                            ");
                    Console.WriteLine("            | | | |-.                          ");
                    Console.WriteLine("            | | | |U|             _.-._        ");
                    Console.WriteLine("            | | | | |            | | | |-.     ");
                    Console.WriteLine("           /|     ` |           / )|_|_|_|     ");
                    Console.WriteLine("          | |       |          | |-^-^-^-'     ");
                    Console.WriteLine("          |         |          |     ||  |     ");
                    Console.WriteLine("          \\         /          \\     '   /   ");
                    Console.WriteLine("           |       |            |       |      ");
                    Console.WriteLine("           |       |            |       |      ");
                    Console.WriteLine();
                    Console.WriteLine("                        WON                    ");
                }

                else if (playerChoice == 2 && computerChoice == 2)
                {
                    Console.Clear();
                    roundsPlayed++;
                    ScoreBoard(_playerScore, _computerScore);
                    Console.WriteLine("              .-.                  .-.         ");
                    Console.WriteLine("            .-|U|-.              .-| |-.       ");
                    Console.WriteLine("            |U| |U|              | | | |       ");
                    Console.WriteLine("            | | | |-.            | | | |-.     ");
                    Console.WriteLine("            | | | |U|            | | | | |     ");
                    Console.WriteLine("            | | | | |            |_|_|_| |     ");
                    Console.WriteLine("           /|     ` |           / )    `-|     ");
                    Console.WriteLine("          | |       |          | | `--   |     ");
                    Console.WriteLine("          |         |          |     ||  |     ");
                    Console.WriteLine("          \\         /          \\    '    /   ");
                    Console.WriteLine("           |       |            |       |      ");
                    Console.WriteLine("           |       |            |       |      ");
                    Console.WriteLine();
                    Console.WriteLine("                        DRAW                   ");
                }

                else if (playerChoice == 2 && computerChoice == 3)
                {
                    Console.Clear();
                    roundsPlayed++;
                    _computerScore++;
                    ScoreBoard(_playerScore, _computerScore);
                    Console.WriteLine("              .-.                       _      ");
                    Console.WriteLine("            .-|U|-.            _       /<)     ");
                    Console.WriteLine("            |U| |U|           (>\\     / /     ");
                    Console.WriteLine("            | | | |-.          \\ \\   / /     ");
                    Console.WriteLine("            | | | |U|           \\ \\ / /      ");
                    Console.WriteLine("            | | | | |            \\_V_/ Y-.    ");
                    Console.WriteLine("           /|     ` |           / )  |_|_|     ");
                    Console.WriteLine("          | |       |          | |   `-^-'     ");
                    Console.WriteLine("          |         |          |     ||  |     ");
                    Console.WriteLine("          \\         /          \\     '   /   ");
                    Console.WriteLine("           |       |            |       |      ");
                    Console.WriteLine("           |       |            |       |      ");
                    Console.WriteLine();
                    Console.WriteLine("                        LOST                   ");
                }

                else if (playerChoice == 3 && computerChoice == 1)
                {
                    Console.Clear();
                    roundsPlayed++;
                    _computerScore++;
                    ScoreBoard(_playerScore, _computerScore);
                    Console.WriteLine("                   _                           ");
                    Console.WriteLine("          _       /<)                          ");
                    Console.WriteLine("         (>\\     / /                          ");
                    Console.WriteLine("          \\ \\   / /                          ");
                    Console.WriteLine("           \\ \\ / /                _.-._      ");
                    Console.WriteLine("            \\ V / Y-.            | | | |-.    ");
                    Console.WriteLine("           /|     ` |           / )|_|_|_|     ");
                    Console.WriteLine("          | |       |          | |-^-^-^-'     ");
                    Console.WriteLine("          |         |          |     ||  |     ");
                    Console.WriteLine("          \\         /          \\     '   /   ");
                    Console.WriteLine("           |       |            |       |      ");
                    Console.WriteLine("           |       |            |       |      ");
                    Console.WriteLine();
                    Console.WriteLine("                        LOST                   ");                 
                }

                else if (playerChoice == 3 && computerChoice == 2)
                {
                    Console.Clear();
                    roundsPlayed++;
                    _playerScore++;
                    ScoreBoard(_playerScore, _computerScore);
                    Console.WriteLine("                   _               .-.          ");
                    Console.WriteLine("          _       /<)            .-| |-.        ");
                    Console.WriteLine("         (>\\     / /             | | | |       ");
                    Console.WriteLine("          \\ \\   / /              | | | |-.    ");
                    Console.WriteLine("           \\ \\ / /               | | | | |    ");
                    Console.WriteLine("            \\ V / Y-.            |_|_|_| |     ");
                    Console.WriteLine("           /|     ` |           / )    `-|      ");
                    Console.WriteLine("          | |       |          | | `--   |      ");
                    Console.WriteLine("          |         |          |     ||  |      ");
                    Console.WriteLine("          \\         /          \\    '    /    ");
                    Console.WriteLine("           |       |            |       |       ");
                    Console.WriteLine("           |       |            |       |       ");
                    Console.WriteLine();
                    Console.WriteLine("                        WON                     ");
                }

                else if (playerChoice == 3 && computerChoice == 3)
                {
                    Console.Clear();
                    roundsPlayed++;
                    ScoreBoard(_playerScore, _computerScore);
                    Console.WriteLine("                   _                    _        ");
                    Console.WriteLine("          _       /<)          _       /<)       ");
                    Console.WriteLine("         (>\\     / /          (>\\     / /      ");
                    Console.WriteLine("          \\ \\   / /            \\ \\   / /     ");
                    Console.WriteLine("           \\ \\ / /              \\ \\ / /      ");
                    Console.WriteLine("            \\ V / Y-.            \\_V_/ Y-.     ");
                    Console.WriteLine("           /|     ` |           / )  |_|_|       ");
                    Console.WriteLine("          | |       |          | |   `-^-'       ");
                    Console.WriteLine("          |         |          |     ||  |       ");
                    Console.WriteLine("          \\         /          \\     '   /     ");
                    Console.WriteLine("           |       |            |       |        ");
                    Console.WriteLine("           |       |            |       |        ");
                    Console.WriteLine();
                    Console.WriteLine("                        DRAW                     ");
                }   
                else
                {
                    Console.Write("Wrong input, please try again: ");
                    goto Start;
                }
            }

            GameOverScreens scores = new GameOverScreens();

            if (_playerScore > _computerScore)
            {
                scores.PlayerWon(this);
            }
            else if (_playerScore < _computerScore)
            {
                scores.ComputerWon(this);
            }
            else if (_playerScore == _computerScore)
            {
                scores.Draw(this);
            }
        }

        private void ScoreBoard (int playerScore, int computerScore)
        {
            Console.WriteLine($"        -------------------------------------                  ");
            Console.WriteLine($"         Player's Score | Computer's score                     ");
            Console.WriteLine($"        -------------------------------------                  ");
            Console.WriteLine($"               {playerScore}        |         {computerScore}  ");
            Console.WriteLine($"        -------------------------------------                  ");
        }

        public void ScoreBoard()
        {
            ScoreBoard(_playerScore, _computerScore);
        }
    }
}
