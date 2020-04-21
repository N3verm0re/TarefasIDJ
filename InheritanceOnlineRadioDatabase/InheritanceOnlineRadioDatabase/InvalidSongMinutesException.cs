using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOnlineRadioDatabase
{
    class InvalidSongMinutesException : InvalidSongLengthException
    {
        public InvalidSongMinutesException() : base("Song minutes should be between 0 and 14.") { }
        public InvalidSongMinutesException(string exceptionMessage) : base(exceptionMessage) { }
    }
}
