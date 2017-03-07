using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBooksChallengeASP.Models
{
    public class ComicBook
    {
        public int ComicBookId { get; set; }
        public string ComicTitle { get; set; }
        public int EpisodeNumber { get; set; }
        public string EpisodeTitle { get; set; }
        public List<Character> Characters { get; set; }


    }

    public class Character
    {
        public int CharacterId { get; set; }
        public string Name { get; set; }
    }

    public class ComicBookManager
    {
        public static List<ComicBook> GetComicBooks()
        {
            return new List<ComicBook>
            {
                new ComicBook{ComicBookId = 1, ComicTitle = "Andreas And", EpisodeNumber = 56, EpisodeTitle = "Ugly ducklings", Characters = new List<Character>{ new Character{CharacterId = 1, Name = "Andreas the first"}}},
                new ComicBook{ComicBookId = 2, ComicTitle = "Supper Dinner Lunch", EpisodeNumber = 1, EpisodeTitle = "Fox beats duck", Characters = new List<Character>{ new Character{CharacterId = 1, Name = "Andreas the first"}, new Character{CharacterId = 2, Name = "FoxyMaxi"}}},
                new ComicBook{ComicBookId = 3, ComicTitle = "Badoo", EpisodeNumber = 42, EpisodeTitle = "Hungry Again", Characters = new List<Character>{ new Character{CharacterId = 2, Name = "FoxyMaxi"}}}
            };
        }
    }
}