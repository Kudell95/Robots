using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Robots.Classes
{
    public class Robot
    {
        public Vector2 Position;
        public DirTypes Direction;
        public int Id;


        public enum DirTypes
        {
            North,
            East,
            South,
            West
        }

        public void Right()
        {
            Direction = (DirTypes)(((int)Direction + 1) % 4);
            Console.WriteLine(string.Format("Robot {0} x:{1} y:{2} facing:{3}", Id, Position.X, Position.Y, Direction.ToString()));

        }

        public void Left()
        {
            Direction = (DirTypes)(((int)Direction - 1) % 4);
            Console.WriteLine(string.Format("Robot {0} x:{1} y:{2} facing:{3}", Id, Position.X, Position.Y, Direction.ToString()));

        }

        public void Move()
        {
            switch (Direction)
            {
                case DirTypes.North:
                    if(ValidateNewPos(new Vector2(Position.X, Position.Y - 1)))
                        Position = new Vector2(Position.X, Position.Y - 1);
                    break;
                case DirTypes.East:
                    if (ValidateNewPos(new Vector2(Position.X + 1, Position.Y)))
                        Position = new Vector2(Position.X + 1, Position.Y);
                        break;
                case DirTypes.South:
                    if (ValidateNewPos(new Vector2(Position.X, Position.Y + 1)))
                        Position = new Vector2(Position.X, Position.Y + 1);
                    break;
                case DirTypes.West:
                    if (ValidateNewPos(new Vector2(Position.X - 1, Position.Y)))
                        Position = new Vector2(Position.X - 1, Position.Y);
                    break;
            }

            Console.WriteLine(string.Format("Robot {0} x:{1} y:{2} facing:{3}", Id, Position.X, Position.Y, Direction.ToString()));

        }

        private bool ValidateNewPos(Vector2 pos)
        {
            //If two robots couldn't be on the same square, this validation would probably need to move to the board
            if ((pos.X > Board.MAXSIZE || pos.X < 1) || (pos.Y > Board.MAXSIZE || pos.Y < 1))
                return false;

            return true;
        }

    }


    
}
