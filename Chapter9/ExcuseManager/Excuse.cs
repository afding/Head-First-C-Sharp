using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcuseManager
{
    public class Excuse
    {
        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath { get; set; }

        public Excuse()
        {
            ExcusePath = String.Empty;
        }

        public Excuse(string fileName)
        {
            OpenFile(fileName);
        }

        public Excuse(Random randomObject, string folder)
        {
            string[] fileNames = Directory.GetFiles(folder, "*.txt");
            OpenFile(fileNames[randomObject.Next(fileNames.Length)]);
        }

        public void OpenFile(string fileName)
        {
            this.ExcusePath = fileName;
            using (StreamReader sr = new StreamReader(fileName))
            {
                Description = sr.ReadLine();
                Results = sr.ReadLine();
                LastUsed = Convert.ToDateTime(sr.ReadLine());
            }
            return;
        }

        public void Save(string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine(Description);
                sw.WriteLine(Results);
                sw.WriteLine(LastUsed);
            }
            return;
        }

    }
}
