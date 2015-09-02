using System.IO;

namespace StreamWriterMagnets
{
    class Flobbo
    {
        private string zap;

        public Flobbo(string zap)
        {
            this.zap = zap;
        }

        public StreamWriter Snobbo()
        {
            return new StreamWriter(@"macaw.txt");
        }

        public bool Blobbo(StreamWriter sw)
        {
            sw.WriteLine(zap);
            zap = "green purple";
            return false;
        }

        public bool Blobbo(bool already, StreamWriter sw)
        {
            if (already)
            {
                sw.WriteLine(zap);
                sw.Close();
                return false;
            }
            else
            {
                sw.WriteLine(zap);
                zap = "red orange";
                return true;
            }
        }
    }
}