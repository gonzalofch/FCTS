using System.Runtime.Serialization;

namespace UnitTesting
{
    [Serializable]
    public class EmailNotProvidedException : Exception
    {
        public EmailNotProvidedException()
        {
        }

        public EmailNotProvidedException(string? message) : base(message)
        {
        }

        public EmailNotProvidedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected EmailNotProvidedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}