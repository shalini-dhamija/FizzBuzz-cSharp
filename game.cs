// var game = new Game();
// var emily = new User
// {
//     Id = 1,
//     Username = "emily1234",
//     Password = "myExtremePassword",
// };
// game.Users.Add(emily);
// Console.WriteLine($"Current level: {emily.CurrentLevel.Name}");
// Console.WriteLine("About to complete a level...");
// emily.AdvanceLevel(score: 123);
// Console.WriteLine("About to complete a level...");
// emily.AdvanceLevel(score: -5);
// Console.WriteLine("About to complete a level...");
// emily.AdvanceLevel(score: 2000);

// class Game
// {
//     public List<User> Users { get; } = new List<User>();
//     public static readonly List<Level> Levels = new List<Level>
//     {
//         new Level
//         {
//             Number = 1,
//             Name = "Forest Level",
//         },
//         new Level
//         {
//             Number = 2,
//             Name = "Desert Level",
//         },
//         new Level
//         {
//             Number = 3,
//             Name = "Snowy Level",
//         },
//     };
// }

// class User
// {
//     public int Id { get; set; }
//     public required string Username { get; set; }
//     public required string Password { private get; set; }
//     public Level CurrentLevel { get; private set; } = Game.Levels.First();

//     public void AdvanceLevel(int score)
//     {
//         if (CurrentLevel == Game.Levels.Last())
//         {
//             Console.WriteLine("You've finished the game!");
//         }
//         else
//         {
//             // Set high score if previous high score has been beaten
//             if (score > CurrentLevel.HighScore)
//             {
//                 CurrentLevel.HighScore = score;
//                 Console.WriteLine("Congratulations! New high score.");
//             }

//             // Advance to the next the level
//             var currentLevelIndex = Game.Levels.IndexOf(CurrentLevel);
//             CurrentLevel = Game.Levels[currentLevelIndex + 1];
//             Console.WriteLine($"You are now on level {CurrentLevel.Number}: {CurrentLevel.Name}.");
//         }
//     }
// }

// class Level
// {
//     public required int Number { get; set; }
//     public required string Name { get; set; }
//     public int HighScore { get; set; } = 0;
// }
