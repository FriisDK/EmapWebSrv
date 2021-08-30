using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using EMAPContext;
using EmapModel;
using EmapServer.Models;
using Microsoft.Extensions.Logging;


namespace EmapServer.Controllers
{
    [Route("Title")]
    public class TitleController : Controller
    {

        private ILogger Logger { get; }

        public TitleController(ILogger<TitleController> logger)
        {
            Logger = logger;
        }

        [HttpGet("GetTitles")]
        public IActionResult GetTitles()
        {
            var emapContext = new EMAPDataContext(DatabaseGlobalization.GetConnection().ConnectionString);
            var reponse = emapContext.LYRICs
                .Select(x => new Title { TitleId = x.UNIQUEID, TitleName = x.TITLE }).OrderBy(x => x.TitleName)
                .ToList();
                

            return Ok(reponse);
        }
        
        [HttpGet("GetTitleById")]
        public IActionResult GetTitleById()
        {
            var titleId = Request.Query["titleid"].FirstOrDefault();
            var emapContext = new EMAPDataContext(DatabaseGlobalization.GetConnection().ConnectionString);
            var response = emapContext.LYRICs.FirstOrDefault(x => x.UNIQUEID.ToString() == titleId);
            return Ok(response);
        }

        [HttpPost("SaveNewTitle")]
        public IActionResult SaveNewTitle([FromBody] SaveLyricsModel lyricModel)
        {
            /*var stream = new StreamReader(Request.Body);
            var body =  stream.ReadToEnd();
            var lyricModel = JsonSerializer.Deserialize<SaveLyricsModel>(body);*/
            if (lyricModel == null) return Ok();
            var emapContext = new EMAPDataContext(DatabaseGlobalization.GetConnection().ConnectionString);
            var newLyric = new LYRIC
            {
                TITLE = lyricModel.Title,
                LYRIC1 = lyricModel.Lyric
            };
            emapContext.LYRICs.InsertOnSubmit(newLyric);
            emapContext.SubmitChanges();

            return Ok(newLyric.UNIQUEID);
        }
    }
}
