using WinFormsApp1.Models;
using System.Threading;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static async Task Main(string[] args)
        {
            new Thread(() =>
            {
                Random rnd = new Random();  

                Thread.CurrentThread.IsBackground = true;

                int TimeBetweenTriggers = 10;

                DateTime TriggerTime = DateTime.Now;

                while (true)
                {
                    DateTime dateTimeNow = DateTime.Now;

                    if (dateTimeNow > TriggerTime.AddSeconds(TimeBetweenTriggers))
                    {

                        using (DatabaseConnection connection = new DatabaseConnection())
                        {


                            for (int i = 0; i < 50; i++)
                            {
                                DateTime createdTime = DateTime.Now;

                                connection.collisionChecks.Add(new CollisionCheck()
                                {
                                    Meteor1X = rnd.Next(2000),
                                    Meteor1Y = rnd.Next(2000),
                                    Meteor2X = rnd.Next(2000),
                                    Meteor2Y = rnd.Next(2000),
                                    WhenCreated = createdTime,
                                });

                                connection.SaveChanges();
                            }


                        }

                        TriggerTime = DateTime.Now;
                    }
                    else
                    {
                        Thread.Sleep(100);
                    }

                }


            }).Start();

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                CollisionCheck[] collisions = null;

                using (DatabaseConnection connection = new DatabaseConnection())
                {

                    collisions = connection.collisionChecks
                        .Where(x =>
                        x.WhenCreated.AddMinutes(10) <= DateTime.Now
                        ).ToArray();

                    connection.collisionChecks.RemoveRange(collisions);

                    connection.SaveChanges();
                }



            }).Start();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}