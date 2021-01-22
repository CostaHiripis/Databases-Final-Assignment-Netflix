using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Tables;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB
{
    class Program
    {
        static void Main(string[] args)
        {

            MongoDB mongoDB = new MongoDB("Databases2");

            mongoDB.InsertFilmOnce();
            mongoDB.GetFilmOnce();
            mongoDB.UpdateFilmOnce();
            mongoDB.DeleteFilmOnce();

            mongoDB.InsertFilmOneThousandTimes();
            mongoDB.GetFilmOneThousandTimes();
            mongoDB.UpdateFilmOneThousandTimes();
            mongoDB.DeleteFilmOneThousandTimes();

            mongoDB.InsertFilmOneHundredThousandTimes();
            mongoDB.GetFilmOneHundredThousandTimes();
            mongoDB.UpdateFilmOneHundredThousandTimes();
            mongoDB.DeleteFilmOneHundredThousandTimes();

            mongoDB.InsertFilmFiveHundredThousandTimes();
            mongoDB.GetFilmFiveHundredThousandTimes();
            mongoDB.UpdateFilmFiveHundredThousandTimes();
            mongoDB.DeleteFilmFiveHundredThousandTimes();

            Console.ReadLine();
        }

        public class MongoDB
        {
            private IMongoDatabase db;

            public MongoDB(string database)
            {
                var client = new MongoClient("mongodb://localhost:27017");
                db = client.GetDatabase(database);
            }

            public void InsertFilmOnce()
            {
                var collection = db.GetCollection<Film>("netflix");
                Film film = new Film { FilmID = 1, FilmName = "test", FilmDirector = "test", AmountOfViews = 0, FilmQuality = "HD" };

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                collection.InsertOne(film);
                stopwatch.Stop();
                Console.WriteLine("Insert Film once took " + stopwatch.ElapsedMilliseconds);
            }
            public void GetFilmOnce()
            {
                var collection = db.GetCollection<Film>("netflix");
                var filter = Builders<Film>.Filter.Eq("FilmID", 1);

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                collection.Find(filter).First();
                stopwatch.Stop();
                Console.WriteLine("Select Film once took " + stopwatch.ElapsedMilliseconds);
            }
            public void UpdateFilmOnce()
            {
                var collection = db.GetCollection<Film>("netflix");
                var filter = Builders<Film>.Filter.Eq("FilmID", 1);
                var update = Builders<Film>.Update.Set("FilmName", "Test1");

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                collection.UpdateOne(filter, update);
                stopwatch.Stop();
                Console.WriteLine("Update Film once took " + stopwatch.ElapsedMilliseconds);
            }
            public void DeleteFilmOnce()
            {
                var collection = db.GetCollection<Film>("netflix");
                var filter = Builders<Film>.Filter.Eq("FilmID", 1);

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                collection.DeleteOne(filter);
                stopwatch.Stop();
                Console.WriteLine("Delete Film once took " + stopwatch.ElapsedMilliseconds);
            }

            public void InsertFilmOneThousandTimes()
            {
                var collection = db.GetCollection<Film>("netflix");

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (int i = 2; i < 1002; i++)
                {
                    Film film = new Film { FilmID = i, FilmName = "test", FilmDirector = "test", AmountOfViews = 0, FilmQuality = "HD" };
                    collection.InsertOne(film);
                }
                stopwatch.Stop();
                Console.WriteLine("Insert Film one thousand times took " + stopwatch.ElapsedMilliseconds);
            }
            public void GetFilmOneThousandTimes()
            {
                var collection = db.GetCollection<Film>("netflix");
                
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (int i = 2; i < 1002; i++)
                {
                    var filter = Builders<Film>.Filter.Eq("FilmID", i);
                    collection.Find(filter).First();
                }
                stopwatch.Stop();
                Console.WriteLine("Select Film one thousand times took " + stopwatch.ElapsedMilliseconds);
            }
            public void UpdateFilmOneThousandTimes()
            {
                var collection = db.GetCollection<Film>("netflix");
                
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (int i = 2; i < 1002; i++)
                {
                    var filter = Builders<Film>.Filter.Eq("FilmID", i);
                    var update = Builders<Film>.Update.Set("FilmName", "Test" + i);
                    collection.UpdateOne(filter, update);
                }
                stopwatch.Stop();
                Console.WriteLine("Update Film one thousand times took " + stopwatch.ElapsedMilliseconds);
            }
            public void DeleteFilmOneThousandTimes()
            {
                var collection = db.GetCollection<Film>("netflix");
                

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (int i = 2; i < 1002; i++)
                {
                    var filter = Builders<Film>.Filter.Eq("FilmID", i);
                    collection.DeleteOne(filter);
                }
                stopwatch.Stop();
                Console.WriteLine("Delete Film one thousand times took " + stopwatch.ElapsedMilliseconds);
            }

            public void InsertFilmOneHundredThousandTimes()
            {
                var collection = db.GetCollection<Film>("netflix");

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (int i = 1002; i < 101002; i++)
                {
                    Film film = new Film { FilmID = i, FilmName = "test", FilmDirector = "test", AmountOfViews = 0, FilmQuality = "HD" };
                    collection.InsertOne(film);
                }
                stopwatch.Stop();
                Console.WriteLine("Insert Film one hundred thousand times took " + stopwatch.ElapsedMilliseconds);
            }
            public void GetFilmOneHundredThousandTimes()
            {
                var collection = db.GetCollection<Film>("netflix");

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (int i = 1002; i < 101002; i++)
                {
                    var filter = Builders<Film>.Filter.Eq("FilmID", i);
                    collection.Find(filter).First();
                }
                stopwatch.Stop();
                Console.WriteLine("Select Film one hundred thousand times took " + stopwatch.ElapsedMilliseconds);
            }
            public void UpdateFilmOneHundredThousandTimes()
            {
                var collection = db.GetCollection<Film>("netflix");

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (int i = 1002; i < 101002; i++)
                {
                    var filter = Builders<Film>.Filter.Eq("FilmID", i);
                    var update = Builders<Film>.Update.Set("FilmName", "Test" + i);
                    collection.UpdateOne(filter, update);
                }
                stopwatch.Stop();
                Console.WriteLine("Update Film one hundred thousand times took " + stopwatch.ElapsedMilliseconds);
            }
            public void DeleteFilmOneHundredThousandTimes()
            {
                var collection = db.GetCollection<Film>("netflix");


                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (int i = 1002; i < 101002; i++)
                {
                    var filter = Builders<Film>.Filter.Eq("FilmID", i);
                    collection.DeleteOne(filter);
                }
                stopwatch.Stop();
                Console.WriteLine("Delete Film one hundred thousand times took " + stopwatch.ElapsedMilliseconds);
            }

            public void InsertFilmFiveHundredThousandTimes()
            {
                var collection = db.GetCollection<Film>("netflix");

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (int i = 101002; i < 601002; i++)
                {
                    Film film = new Film { FilmID = i, FilmName = "test", FilmDirector = "test", AmountOfViews = 0, FilmQuality = "HD" };
                    collection.InsertOne(film);
                }
                stopwatch.Stop();
                Console.WriteLine("Insert Film five hundred thousand times took " + stopwatch.ElapsedMilliseconds);
            }
            public void GetFilmFiveHundredThousandTimes()
            {
                var collection = db.GetCollection<Film>("netflix");

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (int i = 101002; i < 601002; i++)
                {
                    var filter = Builders<Film>.Filter.Eq("FilmID", i);
                    collection.Find(filter).First();
                }
                stopwatch.Stop();
                Console.WriteLine("Select Film five hundred thousand times took " + stopwatch.ElapsedMilliseconds);
            }
            public void UpdateFilmFiveHundredThousandTimes()
            {
                var collection = db.GetCollection<Film>("netflix");

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (int i = 101002; i < 601002; i++)
                {
                    var filter = Builders<Film>.Filter.Eq("FilmID", i);
                    var update = Builders<Film>.Update.Set("FilmName", "Test" + i);
                    collection.UpdateOne(filter, update);
                }
                stopwatch.Stop();
                Console.WriteLine("Update Film five hundred thousand times took " + stopwatch.ElapsedMilliseconds);
            }
            public void DeleteFilmFiveHundredThousandTimes()
            {
                var collection = db.GetCollection<Film>("netflix");


                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (int i = 101002; i < 601002; i++)
                {
                    var filter = Builders<Film>.Filter.Eq("FilmID", i);
                    collection.DeleteOne(filter);
                }
                stopwatch.Stop();
                Console.WriteLine("Delete Film five hundred thousand times took " + stopwatch.ElapsedMilliseconds);
            }
        }
    }
}
