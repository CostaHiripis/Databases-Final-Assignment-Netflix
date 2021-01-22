using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB.Tables
{
    public class Film
    {
        [BsonId]
        public int FilmID { get; set; }
        public string FilmName { get; set; }
        public string FilmDirector { get; set; }
        public int AmountOfViews { get; set; }
        public string FilmQuality { get; set; }

    }
}
