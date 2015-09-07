using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ExcuseManager
{
    [Serializable]
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
            string[] fileNames = Directory.GetFiles(folder, "*.excuse");
            OpenFile(fileNames[randomObject.Next(fileNames.Length)]);
        }

        public void OpenFile(string fileName)
        {
            this.ExcusePath = fileName;
            BinaryFormatter bf = new BinaryFormatter();
            Excuse tempExcuse;
            using (Stream input = File.OpenRead(fileName))
            {
                tempExcuse = (Excuse)bf.Deserialize(input);                
            }
            Description = tempExcuse.Description;
            Results = tempExcuse.Results;
            LastUsed = tempExcuse.LastUsed;
            return;
        }

        public void Save(string fileName)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream output = File.OpenWrite(fileName))
            {
                bf.Serialize(output, this);
            }
            return;
        }

    }
}
