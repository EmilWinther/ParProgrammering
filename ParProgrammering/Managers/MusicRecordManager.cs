using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParProgrammering.Model;

namespace ParProgrammering.Managers
{
    public class MusicRecordManager
    {
        private static int nextID = 1;
        private static List<MusicRecord> liste = new List<MusicRecord>
        {
            new MusicRecord{ID= nextID++, Title = "Bohemian Rhapsody", Artist = "Queen", Duration = 300, PublicationYear = 1975},
            new MusicRecord{ID= nextID++,Title = "Asmus Sang", Artist = "Asmus", Duration = 170, PublicationYear = 2021},
            new MusicRecord{ID= nextID++,Title = "Emilio", Artist = "Emil", Duration = 194, PublicationYear = 2028}

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
        public List<MusicRecord> GetByArtist(string artist)
        {
            List<MusicRecord> result = new List<MusicRecord>(liste);
            if (artist != null)
            {
                result = result.FindAll(data => data.Artist.Contains(artist, StringComparison.OrdinalIgnoreCase));
            }

            return result;
        }
        public List<MusicRecord> GetByYear(int year)
        {
            List<MusicRecord> result = new List<MusicRecord>(liste);
            if (year != null)
            {
                result = result.FindAll(data => data.PublicationYear.Equals(year));
            }

            return result;
        }

        public MusicRecord AddRecord(MusicRecord record)
        {
            liste.Add(record);
            return record;
        }

        public MusicRecord DeleteRecord(int id)
        {
            MusicRecord record = liste.Find(musicrecord1 => musicrecord1.ID == id);
            if (record == null) return null;
            liste.Remove(record);
            return record;
        }

        public MusicRecord UpdateRecord(int id, MusicRecord record)
        {
            MusicRecord record1 = liste.Find(MusicRecord1 => MusicRecord1.ID == id);
            if (record == null) return null;
            record1.Title = record.Title;
            record1.Artist = record.Artist;
            record1.Duration = record.Duration;
            record1.PublicationYear = record.PublicationYear;
            return record1;
        }
    }
}