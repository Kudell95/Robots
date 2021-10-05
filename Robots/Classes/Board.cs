using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots.Classes
{
    public class Board
    {
        Robot ActiveRobot;
        List<Robot> Robots = new List<Robot>();

        public BoardSpace[,] spaces;

        public void Init()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    spaces[i, j] = new BoardSpace();
                }
            }
        }

    }
}
