using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using ParProgrammering.Managers;
using ParProgrammering.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ParProgrammering.Controllers
{
    [ApiController]
    [Route("Music")]
    public class MusicRecordController
    {
        private readonly MusicRecordManager _manager = new MusicRecordManager();

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public IEnumerable<MusicRecord> GetAll()
        {
            return _manager.GetAllRecords();
        }
        [HttpGet]
        [Route("title/{title}")]
        public IEnumerable<MusicRecord> GetByTitle(string title)
        {
            return _manager.GetByTitle(title);
        }
        [HttpGet]
        [Route("artist/{artist}")]
        public IEnumerable<MusicRecord> GetByArtist(string artist)
        {
            return _manager.GetByArtist(artist);
        }
        [HttpGet]
        [Route("year/{year}")]
        public IEnumerable<MusicRecord> GetByYear(int year)
        {
            return _manager.GetByYear(year);
        }

        [HttpPost]
        public MusicRecord AddRecord(MusicRecord record)
        {
            return _manager.AddRecord(record);
        }

        [HttpPut]
        [Route("{id}")]
        public MusicRecord UpdateRecord(int id, MusicRecord record)
        {
            return _manager.UpdateRecord(id, record);
        }

        [HttpDelete]
        [Route("{id}")]
        public MusicRecord DeleteRecord(int id)
        {
            return _manager.DeleteRecord(id);
        }
    }
}
