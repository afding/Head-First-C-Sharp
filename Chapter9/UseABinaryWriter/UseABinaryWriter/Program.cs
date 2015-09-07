﻿using System;
using System.IO;

namespace UseABinaryWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up some data to write to a file.
            int intValue = 48769414;
            string stringValue = "Hello!";
            byte[] byteArray = { 47, 120, 0, 116 };
            float floatValue = 491.65F;
            char charValue = 'E';

            // To use a BinaryWriter, first open a stream with File.Create()
            using (FileStream output = File.Create("binarydata.dat"))
            {
                using (BinaryWriter writer = new BinaryWriter(output))
                {
                    writer.Write(intValue);
                    writer.Write(stringValue);
                    writer.Write(byteArray);
                    writer.Write(floatValue);
                    writer.Write(charValue);
                }
            }

            // Read in the file (bytes) that was just written.
            Console.WriteLine("Writing out bytes: ");
            byte[] dataWritten = File.ReadAllBytes("binarydata.dat");
            foreach (byte b in dataWritten)
            {
                Console.Write("{0:x2} ", b);
            }
            Console.WriteLine(" - {0} bytes", dataWritten.Length);
            Console.ReadKey();

            // Setup the FileStream and BinaryReader objects
            // Then tell BinaryReader what type of data to read by calling its
            // different methods.
            using (FileStream input = File.OpenRead("binarydata.dat"))
            {
                using (BinaryReader reader = new BinaryReader(input))
                {
                    int intRead = reader.ReadInt32();
                    string stringRead = reader.ReadString();
                    byte[] byteArrayRead = reader.ReadBytes(4);
                    float floatRead = reader.ReadSingle();
                    char charRead = reader.ReadChar();

                    // Read in the file (with context) that was just written.
                    Console.WriteLine("Writing out data: ");
                    Console.Write("int : {0} string: {1} bytes: ", intRead, stringRead);
                    foreach (byte b in byteArrayRead)
                    {
                        Console.Write("{0} ", b);
                    }
                    Console.Write(" float: {0} char: {1} ", floatRead, charRead);
                    Console.ReadKey();
                }
            }
        }
    }
}
