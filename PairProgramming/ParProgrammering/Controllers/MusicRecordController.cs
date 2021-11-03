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
    public class MusicRecordController : ControllerBase
    {
        private readonly MusicRecordManager _manager = new MusicRecordManager();

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public IEnumerable<MusicRecord> GetAll()
        {
            return _manager.GetAllRecords();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        [Route("title/{title}")]
        public IEnumerable<MusicRecord> GetByTitle(string title)
        {
            return _manager.GetByTitle(title);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        [Route("artist/{artist}")]
        public IEnumerable<MusicRecord> GetByArtist(string artist)
        {
            return _manager.GetByArtist(artist);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        [Route("year/{year}")]
        public IEnumerable<MusicRecord> GetByYear(int year)
        {
            return _manager.GetByYear(year);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [HttpPost]
        public ActionResult<MusicRecord> AddRecord(MusicRecord record)
        {
            _manager.AddRecord(record);
            return Created("https://parprogrammeringresttestalexasmus.azurewebsites.net/music/" + record.ID, record);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpPut]
        public ActionResult<MusicRecord> UpdateRecord(int id, MusicRecord record)
        {
            return _manager.UpdateRecord(id, record);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpDelete]
        public ActionResult<MusicRecord> DeleteRecord(int id)
        {
            if (_manager.DeleteRecord(id) == null)
            {
                return NoContent();
            }
            return Accepted("https://parprogrammeringresttestalexasmus.azurewebsites.net/music/" + id);
        }
    }
}
