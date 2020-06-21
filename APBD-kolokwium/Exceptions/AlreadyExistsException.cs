using System;

namespace APBD_kolokwium.Exceptions
{
    public class AlreadyExistsException : Exception
    {
        public AlreadyExistsException()
        {

        }
        public AlreadyExistsException(string? message) : base (message)
        {

        }
    }
}
