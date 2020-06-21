using System;

namespace APBD_kolokwium.Exceptions
{
    public class NotExistsException : Exception
    {
        public NotExistsException()
        {

        }
        public NotExistsException(string? message) : base (message)
        {

        }
    }
}
