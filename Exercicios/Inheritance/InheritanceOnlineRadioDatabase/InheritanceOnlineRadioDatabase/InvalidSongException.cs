using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOnlineRadioDatabase
{
    class InvalidSongException : Exception
    {
        public InvalidSongException() : base("Invalid song.") { }
        
        public InvalidSongException(string exceptionMessage) : base(exceptionMessage) { }
    }
}