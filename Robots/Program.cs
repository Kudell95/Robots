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
        //Initialise the board, will contain the list of available boards
        Board board = new Board();
        board.Init();

        //Main Loop
        while(true)
        {
            Console.WriteLine("Enter Command: ");
            string command = Console.ReadLine();


            //Process the commands entered
            switch(command.ToLower())
            {
                case "quit":
                case "q":
                case "exit":
                    return;
                case "move":
                    board.ActiveRobot.Move();
                    continue;
                case "right":
                    board.ActiveRobot.Right();
                    continue;
                case "left":
                    board.ActiveRobot.Left();
                    continue;
                case "report":
                    board.Report();
                    continue;
                case "clear":
                    Console.Clear();
                    continue;
            }

            if (command.ToLower().StartsWith("place"))
            {
                //process the parameters
                string  f = string.Empty;
                int x, y;
                string[] param = command.Split(' ')[1].Split(',');

                Int32.TryParse(param[0], out x);
                Int32.TryParse(param[1], out y);

                f = param[2];

                board.Place(x, y, f);


                continue;
            }

            


        }
        


     }
 }
