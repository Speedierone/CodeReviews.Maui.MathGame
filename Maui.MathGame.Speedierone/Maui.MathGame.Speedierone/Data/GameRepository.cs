using Maui.MathGame.Speedierone.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui.MathGame.Speedierone.Data
{
    public class GameRepository
    {
        string _dpPath;
        private SQLiteConnection conn;

        public GameRepository(string dpPath)
        {
            _dpPath = dpPath;
        }

        public void Init()
        {
            conn = new SQLiteConnection(_dpPath);
            conn.CreateTable<Game>();
        }

        public List<Game> GetAllGames()
        {
            Init();
            return conn.Table<Game>().ToList();
        }

        public void Add(Game game)
        {
            Init();
            conn = new SQLiteConnection(_dpPath);
            conn.Insert(game);
        }

        public void Delete(int id)
        {
            conn = new SQLiteConnection(_dpPath);
            conn.Delete(new Game{ Id = id });
        }
    }
}
