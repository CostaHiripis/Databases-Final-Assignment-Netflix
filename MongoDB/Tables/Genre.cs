using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongoDB.Tables
{
    public class Genre
    {
        [BsonId]
        public int GenreID { get; set; }
        public string GenreName { get; set; }
    }
}
