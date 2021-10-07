# Robots

Simple program to simulate controlling a robot on a table, the robot will follow commands entered.

The available commands are:


Command | Action
------------ | -------------
Place {x},{y},{North,East,South,West} | Places a robot at the given x,y coord's, facing the direction entered.
Move | Move's the robot forward one space in the facing direction.
Right | Rotate's the robot 90° to the right.
Left | Rotate's the robot 90° to the left.
Robot {id} | Select a robot based on it's id, the id will be incremented when a robot is placed.
Report | List's the position and facing direction of all the robots currently on the table.
Quit/q/exit | Close the application.
Clear | Clear's the console.
Reset | Reset's the table


