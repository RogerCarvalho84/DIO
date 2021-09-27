//using _05_ByteBank;

using System;
using System.Runtime.Serialization;

namespace ByteBank
{
    [Serializable]
    internal class argumentexception : Exception
    {
        public argumentexception()
        {
        }

        public argumentexception(string message) : base(message)
        {
        }

        public argumentexception(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected argumentexception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}