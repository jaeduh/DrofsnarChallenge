using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdManMazeChallenge
{
    public class Drofsnar
    {
        private int _points = 5000;

        public int Points { get { return _points; } }

        private int _lives = 3;
        
        public int Lives { get { return _lives; } }

        public void AddPoints(int points)
        {
            _points = (_points + points);
            //return _points; would be needed if current value was being sought out at the moment
        }
        public void AddLives(int lives)
        {
            if (Points > 10000)
            {
            _lives = (_lives + lives);
            }
        }
    }
}
