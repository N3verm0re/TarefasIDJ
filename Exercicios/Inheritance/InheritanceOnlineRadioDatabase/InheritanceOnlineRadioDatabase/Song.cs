using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOnlineRadioDatabase
{
    class Song
    {
        private string artistName;
        private string songName;
        private int lengthMinutes;
        private int lengthSeconds;

        public string ArtistName
        {
            get
            {
                return this.artistName;
            }
            set
            {
                if(value.Length <= 3 || value.Length >= 20) { throw new InvalidArtistNameException(); }
                this.artistName = value;
            }
        }

        public string SongName
        {
            get
            {
                return this.songName;
            }
            set
            {
                if(value.Length <= 3 || value.Length >= 30) { throw new InvalidSongNameException(); }
                this.songName = value;
            }
        }

        public int LengthMinutes
        {
            get
            {
                return this.lengthMinutes;
            }
            set
            {
                if(value < 0 || value > 14) { throw new InvalidSongMinutesException(); }
                this.lengthMinutes = value;
            }
        }

        public int LengthSeconds
        {
            get
            {
                return this.lengthSeconds;
            }
            set
            {
                if(value < 0 || value > 59) { throw new InvalidSongSecondsException(); }
                this.lengthSeconds = value;
            }
        }

        public Song(string songInfo)
        {
            string[] parameters = songInfo.Split(';', StringSplitOptions.RemoveEmptyEntries);
            string[] parametersLength = parameters[2].Split(':', StringSplitOptions.RemoveEmptyEntries);
            this.ArtistName = parameters[0];
            this.SongName = parameters[1];
            this.LengthMinutes = Int32.Parse(parametersLength[0]);
            this.LengthSeconds = Int32.Parse(parametersLength[1]);
        }

        public override string ToString()
        {
            string classString = $"Artist Name: {this.ArtistName}{Environment.NewLine}" +
                $"Song Name: {this.SongName}{Environment.NewLine}" +
                $"Song Length: {this.LengthMinutes}:{this.LengthSeconds}";
            return classString;
        }
    }
}
