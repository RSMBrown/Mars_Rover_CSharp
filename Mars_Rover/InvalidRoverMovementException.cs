using System.Runtime.Serialization;

namespace MarsRover
{
    [Serializable]
    internal class InvalidRoverMovementException : Exception
    {
        public InvalidRoverMovementException()
        {
        }

        public InvalidRoverMovementException(string? message) : base(message)
        {
        }

        public InvalidRoverMovementException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidRoverMovementException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}