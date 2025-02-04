﻿using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Gaming.XboxLive.Storage;

namespace Maui.MathGame.Speedierone.Models
{
    [SQLite.Table("game")]
    public class Game
    {
        [PrimaryKey, AutoIncrement, SQLite.Column("Id")]
        public int Id { get; set; }
        public GameOperation Type { get; set; }
        public int Score { get; set; }
        public DateTime DatePlayed { get; set; }
        public string TimeTaken { get; set; }
        public string Difficulty { get; set; }
        public string GameAmount { get; set; }
    }

    public enum GameOperation
    {
        Addition,
        Subtraction,
        Multiplication,
        Division,
    }
}
