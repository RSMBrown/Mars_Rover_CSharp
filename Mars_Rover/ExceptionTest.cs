using RoverNamespace;

namespace ExceptionTestNamesapce
{

    internal class RoverListTest : List<string>
    {
        private List<Rover>? roverList;
        private int height;
        private int width;

        public List<string> ValidationTest(List<Rover> roverList, int height, int width)
        {
            this.roverList = roverList;
            this.height = height;
            this.width = width;

            List<string> ValidationErrors = new List<string>();

            for (int i = 0; i < roverList.Count; i++)
            {
                if (roverList[i].posx < 0 || roverList[i].posx > width || roverList[i].posy > height || roverList[i].posy < 0)
                {
                    ValidationErrors.Add($"Rover movement makes rover {i + 1} fall off the Plateau. Please try again.");
                }
            }

            return ValidationErrors;
        }
    }
}

