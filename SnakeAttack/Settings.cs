using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAttack
{

    public enum Direction
    {
        Right, 
        Left, 
        Up, 
        Down,
    };
    public class Settings
    {
        public static int Width { get; set; }
        public static int Length { get; set; }
        public static int Speed {get; set;}

        public static int Points { get; set; }
        public static int Score { get; set; }
        public static bool GameOver { get; set; }

        public static Direction direction { get; set; }
        public enum Direction { Right, Left, Up, Down }
        public int Row { get; set; }
        public int Column { get; set; }

        public Settings()
        {

        }

        public Settings (int width, int length, int speed, int points, int score, bool gameOver, int row, int column) //Direction?
        {
            Width = width;
            Length = length;
            Speed = speed;
            Score = score;
            GameOver = gameOver;
            Row = row;
            Column = column;

        }
    }
}
