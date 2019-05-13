using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace exam_poo
{
    public class JPAException : Exception
    {
        public JPAException(string message) : base(message)
        {

        }

        public JPAException(string message, Exception innerException) : base(message, innerException)
        {

        }

        public JPAException(SerializationInfo info, StreamingContext context) 
        {

        }

        public override string ToString()
        {
            string info = DateTime.Now.ToLocalTime()+Message+StackTrace;

            if (InnerException != null)
            {
                info += InnerException.Message;
            }

            return info;
        }
    }
}
