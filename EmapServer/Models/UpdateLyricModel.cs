using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmapServer.Models
{
    public class UpdateLyricsModel
    {
        public int TitleId { get; set; }
        public string Title { get; set; }
        public string Lyric { get; set; }
    }
}