using System;
using System.IO;
using PlateauNamespace;
using NewPositionNamespace;
using RoverNamespace;

namespace Mars_Rover
{
    class Program
    {
        static void Main()
        {
            string text = File.ReadAllText(@"C:\Users\Roxy Brown\source\repos\Mars_Rover\Mars_Rover\input.txt");

            string[] allText = text.Split(Environment.NewLine, StringSplitOptions.None);
            string plateau = allText[0];
            string currentPositionRoverOne = allText[1];
            string movementRoverOne = allText[2];
            string currentPositionRoverTwo = allText[3];
            string movementRoverTwo = allText[4];

            string[] plateauArray = plateau.Split(" ");
            int width = Convert.ToInt32(plateauArray[0]);
            int height = Convert.ToInt32(plateauArray[1]);

            string[] currentPositionRoverOneArray = currentPositionRoverOne.Split(" ");
            int xRoverOne = Convert.ToInt32(currentPositionRoverOneArray[0]);
            int yRoverOne = Convert.ToInt32(currentPositionRoverOneArray[1]);
            string positionRoverOne = currentPositionRoverOneArray[2];

            string[] currentPositionRoverTwoArray = currentPositionRoverTwo.Split(" ");
            int xRoverTwo = Convert.ToInt32(currentPositionRoverTwoArray[0]);
            int yRoverTwo = Convert.ToInt32(currentPositionRoverTwoArray[1]);
            string positionRoverTwo = currentPositionRoverTwoArray[2];

            string[] movementRoverOneArray = movementRoverOne.Split("");
            string[] movementRoverTwoArray = movementRoverTwo.Split("");

            Console.WriteLine("Welcome to the Rover changing station.\n");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"Input text is as follows: \nPlateau: {width}, {height} \nRover One Position: {xRoverOne} {yRoverOne} {positionRoverOne}\n" +
                $"Rover One Movement: {movementRoverOne}\nRover Two Position: {xRoverTwo} {yRoverTwo} {positionRoverTwo}\nRover Two Movement: {movementRoverTwo}\n");

            Plateau plateau1 = new Plateau(width, height);

            List<Rover> roverList = new List<Rover>();

            Rover newRover1 = new Rover(xRoverOne, yRoverOne, positionRoverOne);
            NewPosition.Move(movementRoverOneArray, ref newRover1, plateau1);

            roverList.Add(newRover1);

            Rover newRover2 = new Rover(xRoverTwo, yRoverTwo, positionRoverTwo);
            NewPosition.Move(movementRoverTwoArray, ref newRover2, plateau1);

            roverList.Add(newRover2);

            foreach (Rover rover in roverList)
            {
                Console.WriteLine($"New Position: {rover.posx} {rover.posy} {rover.direction}\n");
            }

            plateau1.printGrid(roverList);
        }
    }
}