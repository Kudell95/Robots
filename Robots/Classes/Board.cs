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

        //could potentially also store a 2d array of board spaces, limiting one robot to a space.


        public void Place(int x, int y, string f)
        {

            if ((x > 5 || x < 0) || (y > 5 || y < 0))
            {
                Console.WriteLine(string.Format("failed to Place robot at x:{0} y:{1}", x, y));
                return;
            }

            Robot.DirTypes dir = (Robot.DirTypes)Enum.Parse(typeof(Robot.DirTypes), f.ToLower());
            Vector2 pos = new Vector2(x, y);
            Robots.Add(new Robot() { Id = Robots.Count + 1, Position = pos, Direction = dir });
            ActiveRobot = Robots.Last();

        }

        public void SelectRobot(int id)
        {
            Robot robot = Robots.FirstOrDefault(i => i.Id == id);
            if (robot != null) //check if the id is valid first, 
                ActiveRobot = robot;
        }

        public void Report()
        {
            foreach (Robot robot in Robots)
            {
                Console.WriteLine(string.Format("Robot {0} report: x:{1} y:{2} facing:{3}", robot.Id, robot.Position.X, robot.Position.Y, robot.Direction.ToString()));
            }
        }

    }
}
