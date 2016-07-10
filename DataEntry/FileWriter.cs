using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEntry
{
    public class FileWriter
    {
        string _filePath;

        public FileWriter(string filePath)
        {
            this._filePath = filePath;
        }

        internal void SaveRecord(string familyID, string memberID, string action, string user)
        {
            string recordString = String.Format("{0},{1},{2},{3},{4}", DateTime.Today.ToShortDateString(), familyID, memberID, action, user);

            using (StreamWriter file = new System.IO.StreamWriter(this._filePath, true))
            {
                file.WriteLine(recordString);
            }
        }
    }
}
