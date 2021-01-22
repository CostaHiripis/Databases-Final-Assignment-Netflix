using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases_Final_Assignment_Netflix
{
    class Program
    {
        static void Main(string[] args)
        {
            AdoDotNet();
            Console.ReadLine();
        }

        private static void AdoDotNet()
        {
            string connectionString = @"Server=.\COSTANDINOSERVER;Initial Catalog=Netflix;Integrated Security=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                InsertFilmDataOnce(connection);
                GetFilmDataOnce(connection);
                UpdateFilmDataOnce(connection);
                DeleteFilmDataOnce(connection);

                InsertFilmDataOneThousandTimes(connection);
                GetFilmDataOneThousandTimes(connection);
                UpdateFilmDataOneThousandTimes(connection);
                DeleteFilmDataOneThousandTimes(connection);

                InsertFilmDataOneHundredThousandTimes(connection);
                GetFilmDataOneHundredThousandTimes(connection);
                UpdateFilmDataOneHundredThousandTimes(connection);
                DeleteFilmDataOneHundredThousandTimes(connection);

                InsertFilmDataFiveHundredThousandTimes(connection);
                GetFilmDataFiveHundredThousandTimes(connection);
                UpdateFilmDataFiveHundredThousandTimes(connection);
                DeleteFilmDataFiveHundredThousandTimes(connection);
            }
        }

        private static void InsertFilmDataOnce(SqlConnection connection)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string queryString = "INSERT INTO Film (filmName, filmDirector, amountOfViews, subtitle, filmQuality) VALUES (@filmName, @filmDirector, @amountOfViews, @subtitle, @filmQuality)";

            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@filmName", "Test");
            command.Parameters.AddWithValue("@filmDirector", "Test");
            command.Parameters.AddWithValue("@amountOfViews", 123);
            command.Parameters.AddWithValue("@subtitle", "Test");
            command.Parameters.AddWithValue("@filmQuality", "HD");

            int affectedRows = command.ExecuteNonQuery();

            if (affectedRows == 0)
            {
                Console.WriteLine("No data was added");
            }
            stopwatch.Stop();
            Console.WriteLine("Insert into Film 1 time took {0}", stopwatch.ElapsedMilliseconds);
        }

        private static void InsertFilmDataOneThousandTimes(SqlConnection connection)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 2; i < 1002; i++)
            {
                string queryString = "INSERT INTO Film (filmName, filmDirector, amountOfViews, subtitle, filmQuality) VALUES (@filmName, @filmDirector, @amountOfViews, @subtitle, @filmQuality)";

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@filmName", "Test");
                command.Parameters.AddWithValue("@filmDirector", "Test");
                command.Parameters.AddWithValue("@amountOfViews", 123);
                command.Parameters.AddWithValue("@subtitle", "Test");
                command.Parameters.AddWithValue("@filmQuality", "HD");

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 0)
                {
                    Console.WriteLine("No data was added");
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Insert into Film 1000 times took {0}", stopwatch.ElapsedMilliseconds);
        }

        private static void InsertFilmDataOneHundredThousandTimes(SqlConnection connection)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1003; i < 101003; i++)
            {
                string queryString = "INSERT INTO Film (filmName, filmDirector, amountOfViews, subtitle, filmQuality) VALUES (@filmName, @filmDirector, @amountOfViews, @subtitle, @filmQuality)";

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@filmName", "Test");
                command.Parameters.AddWithValue("@filmDirector", "Test");
                command.Parameters.AddWithValue("@amountOfViews", 123);
                command.Parameters.AddWithValue("@subtitle", "Test");
                command.Parameters.AddWithValue("@filmQuality", "HD");

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 0)
                {
                    Console.WriteLine("No data was added");
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Insert into Film 100000 times took {0}", stopwatch.ElapsedMilliseconds);
        }

        private static void InsertFilmDataFiveHundredThousandTimes(SqlConnection connection)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 101004; i < 601004; i++)
            {
                string queryString = "INSERT INTO Film (filmName, filmDirector, amountOfViews, subtitle, filmQuality) VALUES (@filmName, @filmDirector, @amountOfViews, @subtitle, @filmQuality)";

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@filmName", "Test");
                command.Parameters.AddWithValue("@filmDirector", "Test");
                command.Parameters.AddWithValue("@amountOfViews", 123);
                command.Parameters.AddWithValue("@subtitle", "Test");
                command.Parameters.AddWithValue("@filmQuality", "HD");

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 0)
                {
                    Console.WriteLine("No data was added");
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Insert into Film 500000 times took {0}", stopwatch.ElapsedMilliseconds);
        }

        static void GetFilmDataOnce(SqlConnection connection)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string queryString = "SELECT * FROM Film WHERE filmID = @filmID";

            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@filmID", 1);

            SqlDataReader reader = command.ExecuteReader();
            reader.Close();

            stopwatch.Stop();
            Console.WriteLine("Get Film 1 times took {0}", stopwatch.ElapsedMilliseconds);
        }

        static void GetFilmDataOneThousandTimes(SqlConnection connection)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 2; i < 1002; i++)
            {
                string queryString = "SELECT * FROM Film WHERE filmID = @filmID";

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@filmID", i);

                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
            }
            
            stopwatch.Stop();
            Console.WriteLine("Get Film 1000 times took {0}", stopwatch.ElapsedMilliseconds);
        }

        static void GetFilmDataOneHundredThousandTimes(SqlConnection connection)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 1002; i < 101002; i++)
            {
                string queryString = "SELECT * FROM Film WHERE filmID = @filmID";

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@filmID", i);

                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
            }

            stopwatch.Stop();
            Console.WriteLine("Get Film 100000 times took {0}", stopwatch.ElapsedMilliseconds);
        }

        static void GetFilmDataFiveHundredThousandTimes(SqlConnection connection)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 101002; i < 601002; i++)
            {
                string queryString = "SELECT * FROM Film WHERE filmID = @filmID";

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@filmID", 1);

                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
            }

            stopwatch.Stop();
            Console.WriteLine("Get Film 500000 times took {0}", stopwatch.ElapsedMilliseconds);
        }

        private static void UpdateFilmDataOnce(SqlConnection connection)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string queryString = "Update Film SET filmName = @filmName, filmDirector = @filmDirector, amountOfViews = @amountOfViews, subtitle = @subtitle, filmQuality = @filmQuality WHERE filmID = @filmID";

            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@filmName", "Test1");
            command.Parameters.AddWithValue("@filmDirector", "Test");
            command.Parameters.AddWithValue("@amountOfViews", 123);
            command.Parameters.AddWithValue("@subtitle", "Test");
            command.Parameters.AddWithValue("@filmQuality", "HD");
            command.Parameters.AddWithValue("@filmID", 1);

            int affectedRows = command.ExecuteNonQuery();

            if (affectedRows == 0)
            {
                Console.WriteLine("No data was updated");
            }
            stopwatch.Stop();
            Console.WriteLine("Update Film 1 time took {0}", stopwatch.ElapsedMilliseconds);
        }

        private static void UpdateFilmDataOneThousandTimes(SqlConnection connection)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 2; i < 1002; i++)
            {
                string queryString = "Update Film SET filmName = @filmName, filmDirector = @filmDirector, amountOfViews = @amountOfViews, subtitle = @subtitle, filmQuality = @filmQuality WHERE filmID = @filmID";

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@filmName", "Test1");
                command.Parameters.AddWithValue("@filmDirector", "Test");
                command.Parameters.AddWithValue("@amountOfViews", 123);
                command.Parameters.AddWithValue("@subtitle", "Test");
                command.Parameters.AddWithValue("@filmQuality", "HD");
                command.Parameters.AddWithValue("@filmID", i);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 0)
                {
                    Console.WriteLine("No data was updated");
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Update Film 1000 times took {0}", stopwatch.ElapsedMilliseconds);
        }

        private static void UpdateFilmDataOneHundredThousandTimes(SqlConnection connection)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 1002; i < 101002; i++)
            {
                string queryString = "Update Film SET filmName = @filmName, filmDirector = @filmDirector, amountOfViews = @amountOfViews, subtitle = @subtitle, filmQuality = @filmQuality WHERE filmID = @filmID";

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@filmName", "Test1");
                command.Parameters.AddWithValue("@filmDirector", "Test");
                command.Parameters.AddWithValue("@amountOfViews", 123);
                command.Parameters.AddWithValue("@subtitle", "Test");
                command.Parameters.AddWithValue("@filmQuality", "HD");
                command.Parameters.AddWithValue("@filmID", i);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 0)
                {
                    Console.WriteLine("No data was updated");
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Update Film 100000 times took {0}", stopwatch.ElapsedMilliseconds);
        }

        private static void UpdateFilmDataFiveHundredThousandTimes(SqlConnection connection)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 101002; i < 601002; i++)
            {
                string queryString = "Update Film SET filmName = @filmName, filmDirector = @filmDirector, amountOfViews = @amountOfViews, subtitle = @subtitle, filmQuality = @filmQuality WHERE filmID = @filmID";

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@filmName", "Test1");
                command.Parameters.AddWithValue("@filmDirector", "Test");
                command.Parameters.AddWithValue("@amountOfViews", 123);
                command.Parameters.AddWithValue("@subtitle", "Test");
                command.Parameters.AddWithValue("@filmQuality", "HD");
                command.Parameters.AddWithValue("@filmID", i);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 0)
                {
                    Console.WriteLine("No data was updated");
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Update Film 500000 times took {0}", stopwatch.ElapsedMilliseconds);
        }

        private static void DeleteFilmDataOnce(SqlConnection connection)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

                string queryString = "Delete FROM ContentGenres where filmID = @filmID Delete FROM History where filmID = @filmID Delete FROM Film where filmID = @filmID";

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@filmID", 1);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 0)
                {
                    Console.WriteLine("No data was deleted");
                }

            stopwatch.Stop();
            Console.WriteLine("Delete Film 1 time took {0}", stopwatch.ElapsedMilliseconds);
        }

        private static void DeleteFilmDataOneThousandTimes(SqlConnection connection)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 2; i < 1002; i++)
            {
                string queryString = "Delete FROM ContentGenres where filmID = @filmID Delete FROM History where filmID = @filmID Delete FROM Film where filmID = @filmID";

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@filmID", i);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 0)
                {
                    Console.WriteLine("No data was deleted");
                }
            }

            stopwatch.Stop();
            Console.WriteLine("Delete Film 1000 times took {0}", stopwatch.ElapsedMilliseconds);
        }

        private static void DeleteFilmDataOneHundredThousandTimes(SqlConnection connection)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 1002; i < 101002; i++)
            {
                string queryString = "Delete FROM ContentGenres where filmID = @filmID Delete FROM History where filmID = @filmID Delete FROM Film where filmID = @filmID";

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@filmID", i);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 0)
                {
                    Console.WriteLine("No data was deleted");
                }
            }

            stopwatch.Stop();
            Console.WriteLine("Delete Film 100000 times took {0}", stopwatch.ElapsedMilliseconds);
        }

        private static void DeleteFilmDataFiveHundredThousandTimes(SqlConnection connection)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 101002; i < 601002; i++)
            {
                string queryString = "Delete FROM ContentGenres where filmID = @filmID Delete FROM History where filmID = @filmID Delete FROM Film where filmID = @filmID";

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@filmID", i);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 0)
                {
                    Console.WriteLine("No data was deleted");
                }
            }

            stopwatch.Stop();
            Console.WriteLine("Delete Film 500000 times took {0}", stopwatch.ElapsedMilliseconds);
        }
    }
}
