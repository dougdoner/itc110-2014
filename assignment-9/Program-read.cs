using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace itc110_assignment9_part2
{
    class Program
    {
        /// <summary>
        /// This is for itc 110
        /// assignment-9 part 2
        /// 
        /// Reading from a text file, generated earlier using WriteToFile and tip classes
        /// </summary>
        /// 

        private StreamReader fileReader;
        static void Main(string[] args)
        {
            Program p = new Program();
            string awesome = p.ReturnTheFile();
            Console.WriteLine(awesome);
            Console.ReadKey();
        }

        public string ReturnTheFile()
        {
            string lines = null;

            try
            {
                fileReader = new StreamReader(@"C:\Users\me\Desktop\test-file.txt");
                lines = fileReader.ReadToEnd();

            }
            catch (FileNotFoundException fileNotFound)
            {
                throw fileNotFound;
            }
            catch (Exception except) 
            {
                throw except;
            }

            return lines;
        }
    }
}
