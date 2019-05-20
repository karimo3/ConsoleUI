using System;
using System.Collections.Generic;
using System.IO;
using System.Timers;
using System.Threading;
using System.Reflection;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {

        private static System.Timers.Timer aTimer;

        static void Main(string[] args)
        {

            //-----------------------------------------------------------------
            //this code displays a message to the console 
            #if (DEBUG)
                        Console.WriteLine("Entering debug mode...");
#else
                        Console.WriteLine("Entering release mode");
#endif
            //------------------------------------------------------------------
            //Console.WriteLine(CalculateYears(1000, 0.05, 0.18, 2000));
            Loops loops = new Loops();
            //loops.Exercise1();
            //loops.Exercise2();
            loops.Exercise3();

            
            //Environment.CurrentDirectory = Environment.GetEnvironmentVariable("TEMP");
            //DirectoryInfo info = new DirectoryInfo(".");

            //Console.WriteLine("Directory Info:  " + info.FullName);

            //float[] grades = new float[3];
            //grades[0] = 89.1f;
            //grades[1] = 96.3f;
            //grades[2] = 71.4f;

            //USING THREADS
            //bool stopped = false;


            //Thread t = new Thread(new ThreadStart(() =>
            //    {
            //        var c = 0;
            //        while (!stopped)
            //        {

            //            Console.WriteLine("Running... {0}", c);
            //            Thread.Sleep(2000);
            //            c++;
            //        }
            //}));
            //t.Start();
            //Console.WriteLine("Press any key to exit");
            //Console.ReadKey();
            //stopped = true;
            //t.Join();



            //while (true)
            //{
            //    Console.Write("Type your name: ");
            //    var input = Console.ReadLine();

            //    if (!String.IsNullOrWhiteSpace(input))
            //    {
            //        Console.WriteLine("@Echo: " + input);
            //        continue;
            //    }

            //    break;


            //}


            /*GENERATING RANDOM PASSWORD*/

            //var random = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write((char)random.Next(97, 122));
            //}
            //Console.ReadKey();


            //const int passwordLength = 10;
            //var buffer = new char[passwordLength];
            //for (int i = 0; i < passwordLength; i++)
            //{
            //    buffer[i] = (char)('a' + random.Next(0, 26));
            //}
            //var password = new string(buffer);
            //Console.WriteLine(password);
            //Console.ReadKey();

            /*GENERATING RANDOM PASSWORD*/

            //Exercise1();

            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //SetTimer();
            //Console.WriteLine("\nPress the Enter key to exit the application...\n");
            //Console.WriteLine("The application started at {0:HH:mm:ss.fff},", DateTime.Now);

            //Console.ReadLine();
            //aTimer.Stop();
            //aTimer.Dispose();
            //Console.WriteLine("Terminating the application");


            //double o = 4.0;
            //double p = 12.0;
            //Console.WriteLine("{0:.0}",o +p);
            //Console.WriteLine($"The number {o} plus {p} is equal to --> {o+p}.0");


            //ViewMetadata(@"C:\Users\obaidka\TestFolder\hello.txt");     


            //Comparing Nullable<T> Instances
            //int? i = 42;
            //int? j = 42;
            //bool areEqual = i == j;

            //Console.WriteLine($"i and j are equal? {areEqual}");

            PlayerCharacter[] players = new PlayerCharacter[]
            {
                new PlayerCharacter {Name = "Sarah"},
                new PlayerCharacter(), //Name = null
                null // PlayerCharacter = null
            };

            string p1 = players?[0]?.Name;
            string p2 = players?[1]?.Name;
            string p3 = players?[2]?.Name;

            Console.ReadLine();

            //if (player1.DaysSinceLastLogin.HasValue)
            //{
            //    Console.WriteLine(player1.DaysSinceLastLogin.Value);
            //}
            //else
            //{
            //    Console.WriteLine("No value for Days since last login");

            //}


            //////////////////////////////////////////////////////
            //int days = player1.DaysSinceLastLogin ?? -1;
            //int days = player1.DaysSinceLastLogin ?? -1;
            //int days = player1.DaysSinceLastLogin.HasValue ? player1.DaysSinceLastLogin.Value : -1;
            //Console.WriteLine($"{days} days since last login");

        }//Main()


        /*#################################################################################################*/
        /*#################################################################################################*/
        /*#################################################################################################*/
        /*#################################################################################################*/
        /*#################################################################################################*/
        /*#################################################################################################*/
        /*#################################################################################################*/
        /*##########################      |    METHODS   |  ###############################################*/
        /*##########################      |     AND      |  ###############################################*/
        /*##########################      v   CLASSES    v  ###############################################*/
        /*##########################      v              v  ###############################################*/
        /*#################################################################################################*/
        /*#################################################################################################*/
        /*#################################################################################################*/
        /*#################################################################################################*/
        /*#################################################################################################*/
        /*#################################################################################################*/
        /*#################################################################################################*/


     
        public static void ViewMetadata(string filePath)
        {
            var bytes = File.ReadAllBytes(filePath);
            try
            {
                Assembly.ReflectionOnlyLoad(bytes);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error loading assembly ", ex);
                Console.ReadKey();
            }
           
        }

        public static int CalculateYears(double Principle, double Interest, double Tax, double DesiredPrinciple)
        {
            var years = 0;
            while (Principle < DesiredPrinciple)
            {
                Principle += Principle * Interest * (1 - Tax);
                years++;
            }

            return years;
        }

        private static void SetTimer()
        {
            //Create a timer with a two second interval
            aTimer = new System.Timers.Timer(2000);

            //Hook up the Elapsed event for the timer
            aTimer.Elapsed += OnTimedEvent;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}", e.SignalTime);
        }


        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }


    }//Program class
}//namespace

