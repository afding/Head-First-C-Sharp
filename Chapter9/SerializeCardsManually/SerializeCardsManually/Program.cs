using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializeCardsManually
{
    class Program
    {
        static void Main(string[] args)
        {
            // Serialize two Card objects to different files
            Card threeOfClubs = new Card(Suits.Clubs, Values.Three);
            Card sixOfHearts = new Card(Suits.Hearts, Values.Six);

            using (FileStream output = File.Create("three-c.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, threeOfClubs);
            }

            using (FileStream output = File.Create("six-h.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, sixOfHearts);
            }

            // Write a loop to compare the two binary files
            byte[] firstFile = File.ReadAllBytes("three-c.dat");
            byte[] secondFile = File.ReadAllBytes("six-h.dat");
            for (int i = 0; i < firstFile.Length; i++)
            {
                if (firstFile[i] != secondFile[i])
                {
                    Console.WriteLine("Byte #{0}: {1} versus {2}",
                        i, firstFile[i], secondFile[i]);
                }
            }
            // Take a look at the console output to see how the two files
            // differ.
            Console.ReadKey();

            // Write code to manually create a new file that contains the King
            // of Spades.
            // From above, byte 307 represents the suit and byte 364 represents
            // the value.
            firstFile[307] = (byte)Suits.Spades;
            firstFile[364] = (byte)Values.King;
            File.Delete("king-s.dat");
            File.WriteAllBytes("king-s.dat", firstFile);

            // Deserialize the card from king-s.dat and see if it's actually
            // the king of spades
            using (FileStream input = File.OpenRead("king-s.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Card mysteryCard = (Card)bf.Deserialize(input);
                Console.WriteLine("The deserialized card is: {0}", mysteryCard.Name);
            }
            Console.ReadKey();
        }
    }
}
