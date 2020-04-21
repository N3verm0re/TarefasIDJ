using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOnlineRadioDatabase
{
    class InvalidArtistNameException : InvalidSongException
    {
        public InvalidArtistNameException() : base("Artist name should be between 3 and 20 symbols.") { }
        public InvalidArtistNameException(string exceptionMessage) : base(exceptionMessage) { }
    }
}
