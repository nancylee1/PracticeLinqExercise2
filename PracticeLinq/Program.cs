using System.Linq;
//using System.Collections.Generic;

//Exercise 2 - PRACTICE LINQ:
//Use the list of Linq methods for help
//Create a new console app and name it PracticeLinq.
//Create a list of video game names...
//Order the list of games by length of the game name.
//Use the lambda expression in this exercise as well.
//use Method Syntax for this exercise


var games = new List<string>() { "Monopoly", "Clue", "Jenga", "Chess", "Checkers", "Backgammon" };

var gamesListLength = games.OrderBy(x => x.Length);

gamesListLength.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));

//foreach (var item in gamesListLength)
//{
//    Console.WriteLine(item);
//}

