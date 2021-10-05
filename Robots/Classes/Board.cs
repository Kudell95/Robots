using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Robots.Classes
{
    public class Board
    {
        public static int MAXSIZE = 5;
        public Robot ActiveRobot;
        public List<Robot> Robots = new List<Robot>();

        public BoardSpace[,] spaces;

        public void Init()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    //spaces[i, j] = new BoardSpace();
                }
            }
        }

        public void Place(int x, int y, string f)
        {

            if ((x > 5 || x < 1) || (y > 5 || y < 1))
            {
                Console.WriteLine(string.Format("failed to Place robot at x:{0} y:{1}", x, y));
                return;
            }

            Robot.DirTypes dir = (Robot.DirTypes)Enum.Parse(typeof(Robot.DirTypes), f.ToLower());
            Vector2 pos = new Vector2(x, y);
            Robots.Add(new Robot() { Id = Robots.Count + 1, Position = pos, Direction = dir });
            ActiveRobot = Robots.Last();
            Console.WriteLine(string.Format("Placed robot at x:{0} y:{1}", x, y));

        }

        public void Report()
        {
            foreach (Robot robot in Robots)
            {
                Console.WriteLine(string.Format("Robot {0} x:{1} y:{2} facing:{3}", robot.Id, robot.Position.X, robot.Position.Y, robot.Direction.ToString()));
            }
        }

    }
}
