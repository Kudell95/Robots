using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robots.Classes;

 class Program
 {
        
     static void Main(string[] args)
     {
        //Initialise the board, will contain the list of available robots + active robot
        Board board = new Board();

        Console.WriteLine("Enter Commands - type help for list of commands:");

        //Main Loop
        while(true)
        {
            string command = Console.ReadLine();


            //Process the commands entered
            switch(command.ToLower())
            {
                case "quit":
                case "q":
                case "exit":
                    return;
                case "move":
                    if(board.ActiveRobot != null)
                        board.ActiveRobot.Move();
                    continue;
                case "right":
                    if (board.ActiveRobot != null)
                        board.ActiveRobot.Right();
                    continue;
                case "left":
                    if (board.ActiveRobot != null)
                        board.ActiveRobot.Left();
                    continue;
                case "report":
                    board.Report();
                    continue;
                case "clear":
                    Console.Clear();
                    continue;
                case "reset":
                    board = new Board();
                    Console.Clear();
                    Console.WriteLine("Enter Commands:");
                    continue;
                case "help":
                case "?":
                    Console.WriteLine("quit\nplace {x},{y},{f}\nrobot {id}\nmove\nright\nleft\nreport\nclear\nreset");
                    break;
            }


            //process the more complicated commands outside of the switch statement
            if (command.ToLower().StartsWith("place"))
            {
                //ensure a param has been entered first
                if (command.Split(' ').Count() <= 1)
                {
                    Console.WriteLine("Failed to Place robot, no parameters entered");
                    continue;
                }

                int x, y;
                string[] param = command.Split(' ')[1].Split(',');

                //ensure all parameters are supplied and valid
                if (param.Length != 3
                    || string.IsNullOrEmpty(param[0])
                    || string.IsNullOrEmpty(param[1])
                    || string.IsNullOrEmpty(param[2]))
                {
                    Console.WriteLine("Failed to Place robot, not enough parameters or values are invalid");
                    continue;
                }

                Int32.TryParse(param[0], out x);
                Int32.TryParse(param[1], out y);

                //process the parameters
                string f = param[2];

                board.Place(x, y, f.ToLower());


                continue;
            }

            if(command.ToLower().StartsWith("robot"))
            {
                //ensure a param has been entered first
                if (command.Split(' ').Count() <= 1)
                {
                    Console.WriteLine("Failed to Place robot, no parameters entered");
                    continue;
                }

                string[] param = command.Split(' ')[1].Split(',');

                //ensure the parameter is supplied.
                if (param.Length != 1 || string.IsNullOrEmpty(param[0]))
                {
                    Console.WriteLine("Failed to Place robot, not enough parameters or values are invalid");
                    continue;
                }

                int id;
                Int32.TryParse(param[0], out id);
                board.SelectRobot(id);
                continue;
            }

            


        }
        


     }
 }
