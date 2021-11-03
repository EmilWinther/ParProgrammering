using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParProgrammering.Model;

namespace ParProgrammering.Managers
{
    public class MusicRecordManager
    {
        private static List<MusicRecord> liste = new List<MusicRecord>
        {
            new MusicRecord{Title = "Bohemian Rhapsody", Artist = "Queen", Duration = 300, PublicationYear = 1975},
            new MusicRecord{Title = "Asmus Sang", Artist = "Asmus", Duration = 170, PublicationYear = 2021},
            new MusicRecord{Title = "Emilio", Artist = "Emil", Duration = 194, PublicationYear = 2028}

        };

        public List<MusicRecord> GetAllRecords()
        {
            return new List<MusicRecord>(liste);
        }
        public List<MusicRecord> GetByTitle(string title)
        {
            List<MusicRecord> result = new List<MusicRecord>(liste);
            if (title != null)
            {
                result = result.FindAll(data => data.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
            }

            return result;
        }
        public MusicRecord GetByArtist(string artist)
        {
            return liste.Find(record => record.Artist == artist);
        }
        public MusicRecord GetByYear(int year)
        {
            return liste.Find(record => record.PublicationYear == year);
        }
    }
}