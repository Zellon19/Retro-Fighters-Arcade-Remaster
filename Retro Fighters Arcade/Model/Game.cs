using Retro_Fighters_Arcade.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retro_Fighters_Arcade.Model
{
    internal class Game
    {
        private int _id;
        private string _name;
        private string _genre;
        private string _description;
        private string _year;
        private string _console;
        private string _developer;
        private static List<Game> _gameList = new GameController().GetGames();

        public int Id
        { 
            get => _id; set => _id = value;
        }
        public string Name
        {
            get => _name; set => _name = value;
        }
        public string Genre
        {
            get => _genre; set => _genre = value;
        }
        public string Description
        {
            get => _description; set => _description = value;
        }
        public string Year
        {
            get => _year; set => _year = value;
        }
        public string Console
        {
            get => _console; set => _console = value;
        }
        public string Developer
        {
            get => _developer; set => _developer = value;
        }
        public List<Game> GameList() => _gameList;

        // searches locally, for in-class-use
        private Game? SearchGame()
        {
            foreach (Game? game in _gameList)
                if (game.Id.Equals(this.Id)) return game;

            return null;
        }

        // search using an object
        public Game? SearchGame(Game pGame)
        {
            foreach(Game? game in _gameList)
                if(game.Id.Equals(pGame.Id)) return game;

            return null;
        }


        public Game(int pId, string pName, string pGenre, string pYear, string pSummary, string pConsole, string pDeveloper)
        {
            _id = pId;
            _name = pName;
            _genre = pGenre;
            _description = pSummary;
            _year = pYear;
            _console = pConsole;
            _developer = pDeveloper;
        }
        public Game()
        {

        }
    }
}
