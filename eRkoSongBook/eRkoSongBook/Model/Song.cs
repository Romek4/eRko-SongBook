using System;
using System.Collections.Generic;
using System.Text;

namespace eRkoSongBook.Model
{
    class Song
    {
        public string SongName { get; set; }
        public string SongText { get; set; }

        public Song() { }

        public Song(string songName, string songText)
        {
            SongName = songName;
            SongText = songText;
        }
    }
}
