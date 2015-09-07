using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DotNetUsesUnicode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("eureka.txt", "Eureka!");
            // The ReadAllBytes() method returns a reference to a new array of
            // bytes that contains all of the bytes that were read in from the
            // file.
            byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
            foreach (byte b in eurekaBytes)
            {
                Console.Write("{0} ", b);
            }
            Console.WriteLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText("eureka.txt", "Eureka!");
            // The ReadAllBytes() method returns a reference to a new array of
            // bytes that contains all of the bytes that were read in from the
            // file.
            byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
            foreach (byte b in eurekaBytes)
            {
                // This tells Write() to print paramter 0 as a two-caracter hex
                // code.
                Console.Write("{0:x2} ", b);
            }
            Console.WriteLine();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText("eureka.txt", "שלום", Encoding.Unicode);
            // The ReadAllBytes() method returns a reference to a new array of
            // bytes that contains all of the bytes that were read in from the
            // file.
            byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
            foreach (byte b in eurekaBytes)
            {
                // This tells Write() to print paramter 0 as a two-caracter hex
                // code.
                Console.Write("{0:x2} ", b);
            }
            Console.WriteLine();
        }
    }
}
