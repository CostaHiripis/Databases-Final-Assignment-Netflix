using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            AddFilmOnce();
            GetFilmOnce();
            UpdateFilmOnce();
            DeleteFilmOnce();

            AddFilmOneThousandTimes();
            GetFilmOneThousandTimes();
            UpdateFilmOneThousandTimes();
            DeleteFilmOneThousandTimes();

            AddFilmOneHundredThousandTimes();
            GetFilmOneHundredThousandTimes();
            UpdateFilmOneHundredThousandTimes();
            DeleteFilmOneHundredThousandTimes();

            AddFilmFiveHundredThousandTimes();
            GetFilmFiveHundredThousandTimes();
            UpdateFilmFiveHundredThousandTimes();
            DeleteFilmFiveHundredThousandTimes();

            using (var dbContext = new DatabaseContext())
            {
                dbContext.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Films', RESEED, 0)");
            }


            Console.ReadLine();
        }

        private static void AddFilmOnce()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                using(var dbContext = new DatabaseContext())
                {
                    var film = new Film { FilmID = 1, FilmName = "Test", FilmDirector = "Test", AmountOfViews = 0, FilmQuality = "HD" };
                    dbContext.Films.Add(film);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Could not add Film");
            }
            stopwatch.Stop();
            Console.WriteLine("Insert into Film 1 time took {0}", stopwatch.ElapsedMilliseconds);
        }
        private static void GetFilmOnce()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var film = new Film { FilmID = 1};

            using (var dbContext = new DatabaseContext())
            {
                var filmFound = dbContext.Films.Find(film.FilmID);
                if(filmFound == null)
                {
                    Console.WriteLine("Could not find Film");
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Select Film 1 time took {0}", stopwatch.ElapsedMilliseconds);
        }
        private static void UpdateFilmOnce()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var newFilm = new Film { FilmID = 1, FilmName = "Test1", FilmDirector = "Test1", AmountOfViews = 1, FilmQuality = "SD" };

            using (var dbContext = new DatabaseContext())
            {

                var film = dbContext.Films.Find(newFilm.FilmID);
                if (film != null)
                {
                    dbContext.Entry(film).CurrentValues.SetValues(newFilm);
                    dbContext.SaveChanges();
                    
                }
                else
                {
                    Console.WriteLine("Could not find the film");
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Update Film 1 time took {0}", stopwatch.ElapsedMilliseconds);
        }
        private static void DeleteFilmOnce()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            try
            {
                using (var dbContext = new DatabaseContext())
                {
                    var filmToDelete = dbContext.Films.SingleOrDefault(film => film.FilmID == 1);

                    dbContext.Films.Remove(filmToDelete);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Could not delete Film");
            }
            stopwatch.Stop();
            Console.WriteLine("Delete Film 1 time took {0}", stopwatch.ElapsedMilliseconds);
        }

        private static void AddFilmOneThousandTimes()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 2; i < 1002; i++)
            {
                try
                {
                    using (var dbContext = new DatabaseContext())
                    {
                        
                        var film = new Film { FilmName = "Test", FilmDirector = "Test", AmountOfViews = 0, FilmQuality = "HD" };
                        dbContext.Films.Add(film);
                        dbContext.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Could not add Film");
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Insert into Film 1000 times took {0}", stopwatch.ElapsedMilliseconds);
        }
        private static void GetFilmOneThousandTimes()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 2; i < 1002; i++)
            {
                var film = new Film { FilmID = i };

                using (var dbContext = new DatabaseContext())
                {
                    var filmFound = dbContext.Films.Find(film.FilmID);
                    if (filmFound == null)
                    {
                        Console.WriteLine("Could not find Film");
                    }
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Select Film 1000 times took {0}", stopwatch.ElapsedMilliseconds);
        }
        private static void UpdateFilmOneThousandTimes()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 2; i < 1002; i++)
            {
                var newFilm = new Film { FilmID = i, FilmName = "Test1", FilmDirector = "Test1", AmountOfViews = 1, FilmQuality = "SD" };

                using (var dbContext = new DatabaseContext())
                {
                    var film = dbContext.Films.Find(newFilm.FilmID);
                    if (film != null)
                    {
                        dbContext.Entry(film).CurrentValues.SetValues(newFilm);
                        dbContext.SaveChanges();
                    }
                    else
                    {
                        Console.WriteLine("Could not find the film");
                    }
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Update Film 1000 times took {0}", stopwatch.ElapsedMilliseconds);
        }
        private static void DeleteFilmOneThousandTimes()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 2; i < 1002; i++)
            {
                try
                {
                    using (var dbContext = new DatabaseContext())
                    {
                        var filmToDelete = dbContext.Films.SingleOrDefault(film => film.FilmID == i);

                        dbContext.Films.Remove(filmToDelete);
                        dbContext.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Could not delete Film");
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Delete Film 1000 times took {0}", stopwatch.ElapsedMilliseconds);
        }

        private static void AddFilmOneHundredThousandTimes()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1002; i < 101002; i++)
            {
                try
                {
                    using (var dbContext = new DatabaseContext())
                    {

                        var film = new Film { FilmName = "Test", FilmDirector = "Test", AmountOfViews = 0, FilmQuality = "HD" };
                        dbContext.Films.Add(film);
                        dbContext.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Could not add Film");
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Insert into Film 100000 times took {0}", stopwatch.ElapsedMilliseconds);
        }
        private static void GetFilmOneHundredThousandTimes()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 1002; i < 101002; i++)
            {
                var film = new Film { FilmID = i };

                using (var dbContext = new DatabaseContext())
                {
                    var filmFound = dbContext.Films.Find(film.FilmID);
                    if (filmFound == null)
                    {
                        Console.WriteLine("Could not find Film");
                    }
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Select Film 100000 times took {0}", stopwatch.ElapsedMilliseconds);
        }
        private static void UpdateFilmOneHundredThousandTimes()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 1002; i < 101002; i++)
            {
                var newFilm = new Film { FilmID = i, FilmName = "Test1", FilmDirector = "Test1", AmountOfViews = 1, FilmQuality = "SD" };

                using (var dbContext = new DatabaseContext())
                {
                    var film = dbContext.Films.Find(newFilm.FilmID);
                    if (film != null)
                    {
                        dbContext.Entry(film).CurrentValues.SetValues(newFilm);
                        dbContext.SaveChanges();
                    }
                    else
                    {
                        Console.WriteLine("Could not find the film");
                    }
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Update Film 100000 times took {0}", stopwatch.ElapsedMilliseconds);
        }
        private static void DeleteFilmOneHundredThousandTimes()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 1002; i < 101002; i++)
            {
                try
                {
                    using (var dbContext = new DatabaseContext())
                    {
                        var filmToDelete = dbContext.Films.SingleOrDefault(film => film.FilmID == i);

                        dbContext.Films.Remove(filmToDelete);
                        dbContext.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Could not delete Film");
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Delete Film 100000 times took {0}", stopwatch.ElapsedMilliseconds);
        }

        private static void AddFilmFiveHundredThousandTimes()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 101002; i < 601002; i++)
            {
                try
                {
                    using (var dbContext = new DatabaseContext())
                    {

                        var film = new Film { FilmName = "Test", FilmDirector = "Test", AmountOfViews = 0, FilmQuality = "HD" };
                        dbContext.Films.Add(film);
                        dbContext.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Could not add Film");
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Insert into Film 500000 times took {0}", stopwatch.ElapsedMilliseconds);
        }
        private static void GetFilmFiveHundredThousandTimes()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 101002; i < 601002; i++)
            {
                var film = new Film { FilmID = i };

                using (var dbContext = new DatabaseContext())
                {
                    var filmFound = dbContext.Films.Find(film.FilmID);
                    if (filmFound == null)
                    {
                        Console.WriteLine("Could not find Film");
                    }
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Select Film 500000 times took {0}", stopwatch.ElapsedMilliseconds);
        }
        private static void UpdateFilmFiveHundredThousandTimes()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 101002; i < 601002; i++)
            {
                var newFilm = new Film { FilmID = i, FilmName = "Test1", FilmDirector = "Test1", AmountOfViews = 1, FilmQuality = "SD" };

                using (var dbContext = new DatabaseContext())
                {
                    var film = dbContext.Films.Find(newFilm.FilmID);
                    if (film != null)
                    {
                        dbContext.Entry(film).CurrentValues.SetValues(newFilm);
                        dbContext.SaveChanges();
                    }
                    else
                    {
                        Console.WriteLine("Could not find the film");
                    }
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Update Film 500000 times took {0}", stopwatch.ElapsedMilliseconds);
        }
        private static void DeleteFilmFiveHundredThousandTimes()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 101002; i < 601002; i++)
            {
                try
                {
                    using (var dbContext = new DatabaseContext())
                    {
                        var filmToDelete = dbContext.Films.SingleOrDefault(film => film.FilmID == i);

                        dbContext.Films.Remove(filmToDelete);
                        dbContext.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Could not delete Film");
                }
            }

            stopwatch.Stop();
            Console.WriteLine("Delete Film 500000 times took {0}", stopwatch.ElapsedMilliseconds);
        }
    }
}
