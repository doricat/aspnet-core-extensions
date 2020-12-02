using System;
using System.Runtime.Serialization;

namespace WebApi.Filter
{
    [Serializable]
    public class FilterException : Exception
    {
        public FilterException()
        {
        }

        public FilterException(string message) : base(message)
        {
        }

        public FilterException(string message, Exception inner) : base(message, inner)
        {
        }

        protected FilterException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}