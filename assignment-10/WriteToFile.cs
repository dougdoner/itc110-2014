using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace itc110_douglasdoner_assignment_10
{
    class WriteToFile
    {
        private StreamWriter writerObj;
        //constructor method instantiates the WriteToFile class
        public WriteToFile(string filePath)
        {
            writerObj = new StreamWriter(filePath, true);
        }
        public void AddLines(string lines)
        {
            writerObj.WriteLine(lines);
        }
        //closes current file, otherwise file can't be accessed.
        public void closeCurrentFile()
        {
            writerObj.Close();
        }
    }
}
