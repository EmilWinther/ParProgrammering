using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParProgrammering.Model
{
    public class MusicRecord
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        public int PublicationYear { get; set; }

        public MusicRecord()
        {

        }
        public MusicRecord(string title, string artist, int duration, int publicationYear)
        {
            title = Title;
            artist = Artist;
            duration = Duration;
            publicationYear = PublicationYear;
        }

        public override string ToString()
        {
            return $"{Title} by {Artist} published {PublicationYear} lasting {Duration}";
        }
    }
}