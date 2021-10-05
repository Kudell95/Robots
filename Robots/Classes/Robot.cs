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
        public Vector2 Position { get; set; }
        public DirTypes Direction { get; set; }
        public int Id { get; set; }


        public enum DirTypes
        {
            north,
            east,
            south,
            west
        }

        public void Right()
        {
            Direction = (DirTypes)(((int)Direction + 1) % 4);
        }

        public void Left()
        {
            //this looks ugly, but needed to wrap backwards when subtracting for the dir types.
            //could probably be simplified
            Direction = (DirTypes)(((((int)Direction) - 1) % 4 + 4) % 4);

        }

        public void Move()
        {
            switch (Direction)
            {
                case DirTypes.north:
                    if(ValidateNewPos(new Vector2(Position.X, Position.Y + 1)))
                        Position = new Vector2(Position.X, Position.Y + 1);
                    break;
                case DirTypes.east:
                    if (ValidateNewPos(new Vector2(Position.X + 1, Position.Y)))
                        Position = new Vector2(Position.X + 1, Position.Y);
                        break;
                case DirTypes.south:
                    if (ValidateNewPos(new Vector2(Position.X, Position.Y - 1)))
                        Position = new Vector2(Position.X, Position.Y - 1);
                    break;
                case DirTypes.west:
                    if (ValidateNewPos(new Vector2(Position.X - 1, Position.Y)))
                        Position = new Vector2(Position.X - 1, Position.Y);
                    break;
            }


        }

        private bool ValidateNewPos(Vector2 pos)
        {
            //If two robots couldn't be on the same square, this validation would probably need to move to the board
            if ((pos.X > Board.MAXSIZE || pos.X < 0) || (pos.Y > Board.MAXSIZE || pos.Y < 0))
                return false;

            return true;
        }

    }


    
}
