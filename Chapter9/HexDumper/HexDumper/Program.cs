using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexDumper
{
    class Program
    {
        static void Main(string[] args)
        {
            // We expect exactly one argument: a file to get a hex dump for.
            if (args.Length != 1)
            {
                Console.Error.WriteLine("usage: HexDumper file-to-dump");
                // The Exit() method quits the pogram. If it's passed an int,
                // then it will return that error code, which is useful when
                // writing command scripts and batch files.
                System.Environment.Exit(1);
            }
            // It's also a good idea to check if the file exists. If it
            // doesn't, then print a different message and return a different
            // error code.
            if (!File.Exists(args[0]))
            {
                Console.Error.WriteLine("File does not exist: {0}", args[0]);
                System.Environment.Exit(2);
            }

            // We won't need a StreamReader, we'll read bytes directly from the
            // stream.
            using (Stream input = File.OpenRead(args[0]))
            {
                int position = 0;
                byte[] buffer = new byte[16];
                while (position < input.Length)
                {
                    int charactersRead = input.Read(buffer, 0, buffer.Length);
                    if (charactersRead > 0)
                    {
                        Console.Write("{0}: ", String.Format("{0:x4}", position));
                        position += charactersRead;

                        for (int i = 0; i < 16; i++)
                        {
                            if (i < charactersRead)
                            {
                                string hex = String.Format("{0:x2}", (byte)buffer[i]);
                                Console.Write(hex + " ");
                            }
                            else
                            {
                                Console.Write("   ");
                            }
                            if (i == 7)
                            {
                                Console.Write("-- ");
                            }
                            if (buffer[i] < 32 || buffer[i] > 250)
                            {
                                buffer[i] = (byte)'.';
                            }
                        }
                        // This is an easy way to convert a byte array to a
                        // string. It's part of Encoding.UTF8 (or another
                        // Unicode encoding, or ASCII, or another encoding)
                        // because different encodings can map the same byte
                        // array to different strings.
                        string bufferContents = Encoding.UTF8.GetString(buffer);
                        Console.WriteLine("   " + bufferContents);
                    }
                }
            }
        }
    }
}
