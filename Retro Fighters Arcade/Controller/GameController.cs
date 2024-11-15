using Retro_Fighters_Arcade.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Retro_Fighters_Arcade.Controller
{
    internal class GameController
    {
        private readonly string _connectionString =
            "Server=localhost;Database=retrofighters;User Id=root;Password=";
        /*
          * we do
          * some little
          * sql shenanigans
          * in here
          * and magic shit
          * bc i do NOT have the database lol <= now i do have the db >D
          * 
          */

        public List<Game> GetGames()
        {
            var games = new List<Game>();
            using MySqlConnection connection = new(this._connectionString);
            string query = "SELECT * FROM game";
            MySqlCommand command = new(query, connection); // create the mysql command

            try {
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader()) 
                {
                    while (reader.Read()) // we read each column for each row that has data and create a game with it
                    {
                        var id = reader.GetInt32("Id");
                        var name = reader.GetString("Name");
                        var genre = reader.GetString("Genre");
                        var launchYear = reader.GetString("LaunchYear");
                        var summary = reader.GetString("Summary");
                        var console = reader.GetString("Console");
                        var developer = reader.GetString("Developer");
                        Game game = new(id, name, genre, launchYear, summary, console, developer);
                        games.Add(game); //simply adds the game to the list
                    } 
                }
                Console.WriteLine("DONE!!!!!!!!");
                return games;
            } catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
                return null;
            }
        }
    }
}
