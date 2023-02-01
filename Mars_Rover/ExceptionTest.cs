using RoverNamespace;
using System.Xml.Schema;
using System.IO;

namespace ExceptionTestNamesapce
{

    internal class Validations : List<string>
    {
        private List<Rover>? roverList;
        private int height;
        private int width;
        private string[] args;

        public List<string> RoverTest(List<Rover> roverList, int height, int width)
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

        public List<string> ValidateFile(string[] args)
        {
            this.args = args;

            List<string> errors = new List<string>();

            if (args.Length != 1)
            {
                errors.Add("Please enter a single File to use for the program.");
            }

            if (!(File.Exists(args[0])))
            {
                errors.Add("Please make sure that argument is a File of the correct format.");
            }

            return errors;
        }
    }
}

