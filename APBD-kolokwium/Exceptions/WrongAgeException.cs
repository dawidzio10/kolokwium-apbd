using System;

namespace APBD_kolokwium.Exceptions
{
    public class WrongAgeException : Exception
    {
        public WrongAgeException()
        {

        }
        public WrongAgeException(string? message) : base (message)
        {

        }
    }
}
