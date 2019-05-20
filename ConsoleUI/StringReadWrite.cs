using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    public class StringReadWrite
    {

        StringBuilder sb = new StringBuilder();

        private int weight;

        public int Weight
        {
            get { return Weight; }
            set { Weight = value; }
        }



        public StringReadWrite()
        {
            WriteData();
            ReadData();
        }


        #region "using StringReader"
        public void ReadData()
        {
            StringReader sr = new StringReader(sb.ToString());

            Console.WriteLine("Reading the info...");

            while (sr.Peek() > -1)
            {
                Console.WriteLine($"{sr.ReadLine()}");
            }

            Console.WriteLine();
            Console.WriteLine("Thank you!");

            sr.Close();

        }
        #endregion



            #region "write data using StringWriter"
        public void WriteData()
        {
            StringWriter sw = new StringWriter(sb);
            
            Console.WriteLine("Please enter your first name...");
            string name = Console.ReadLine();

            sw.WriteLine($"Name: {name}");

            sw.Flush();
            sw.Close();
        }
        #endregion
    }
}
