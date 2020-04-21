using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOnlineRadioDatabase
{
    class InvalidSongSecondsException : InvalidSongException
    {
        public InvalidSongSecondsException() : base("Song seconds should be between 0 and 59.") { }
        public InvalidSongSecondsException(string exceptionMessage) : base(exceptionMessage) { }
    }
}
