using PlateauNamespace;
using NewPositionNamespace;
using RoverNamespace;
using ExceptionTestNamesapce;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(args[0]);

            Console.WriteLine("Welcome to the Rover changing station.\n");
            Console.WriteLine("-----------------------------------------------------");

            string[] allText = text.Split(Environment.NewLine, StringSplitOptions.None);
            string plateau = allText[0];

            string[] plateauArray = plateau.Split(" ");
            int width = Convert.ToInt32(plateauArray[0]);
            int height = Convert.ToInt32(plateauArray[1]);

            Plateau plateau1 = new Plateau(width, height);

            Console.WriteLine($"Input text is as follows: \nPlateau: {width}, {height}");

            List<Rover> roverList = new List<Rover>();

            for (int i = 0; i <= allText.Length - 2; i += 2)
            {
                string currentPositionRover = allText[i + 1];
                string movementRover = allText[i + 2];

                string[] currentPositionRoverArray = currentPositionRover.Split(" ");
                int xRover = Convert.ToInt32(currentPositionRoverArray[0]);
                int yRover = Convert.ToInt32(currentPositionRoverArray[1]);
                string positionRover = currentPositionRoverArray[2];

                char[] movementRoverArray = movementRover.ToCharArray();

                Console.WriteLine($"Rover Position: {xRover} {yRover} {positionRover}\n" +
                $"Rover Movement: {movementRover}\n");


                Rover newRover = new Rover(xRover, yRover, positionRover);
                NewPosition.Move(movementRoverArray, ref newRover, plateau1);

                roverList.Add(newRover);
            }

            RoverListTest roverTest = new RoverListTest();
            List<string> validationList = roverTest.ValidationTest(roverList, height, width);
            
            if (validationList.Count == 0)
            {
                foreach (Rover rover in roverList)
                {
                    Console.WriteLine($"{rover.posx} {rover.posy} {rover.direction}");
                }

                plateau1.printGrid(roverList);

            }
            else
            {
                foreach (string output in validationList)
                {
                    Console.WriteLine(output);
                }
            }

            

        }
    }
}