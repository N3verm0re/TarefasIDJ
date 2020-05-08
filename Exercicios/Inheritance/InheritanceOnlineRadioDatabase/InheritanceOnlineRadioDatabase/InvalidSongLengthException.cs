using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOnlineRadioDatabase
{
    class InvalidSongLengthException : InvalidSongException
    {
        public InvalidSongLengthException() : base("Invalid song length.") { }
        public InvalidSongLengthException(string exceptionMessage) : base(exceptionMessage) { }
    }
}
