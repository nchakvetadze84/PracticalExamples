using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System;

namespace PracticalExamples
{
    class MyFile
    {
        public static void SimpleFileIO()
        {
            Console.WriteLine("***** Simple IO with the File Type *****\n");
            try
            {
                string[] myTasks = {
                    "Fix bathroom sink", "Call Dave",
                    "Call Mom and Dad", "Play Xbox 360"};

                // Write out all data to file on C drive.
                File.WriteAllLines(@"C:\Logs\tasks.txt", myTasks);

                // Read it all back and print out.
                foreach (string task in File.ReadAllLines(@"C:\\Logs\tasks.txt"))
                {
                    Console.WriteLine("TODO: {0}", task);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void StreamWriterReaderApp()
        {
            Console.WriteLine("***** Fun with StreamWriter / StreamReader *****\n");

            // Get a StreamWriter and write string data.
            using (StreamWriter writer = File.CreateText("reminders.txt"))
            {
                writer.WriteLine("Don't forget Mother's Day this year...");
                writer.WriteLine("Don't forget Father's Day this year...");
                writer.WriteLine("Don't forget these numbers:");
                for (int i = 0; i < 10; i++)
                    writer.Write(i + " ");

                // Insert a new line.
                writer.Write(writer.NewLine);
            }

            Console.WriteLine("Created file and wrote some thoughts...");

            // Now read data from file.
            Console.WriteLine("Here are your thoughts:\n");
            using (StreamReader sr = File.OpenText("reminders.txt"))
            {
                string input = null;
                while ((input = sr.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
            }

            Console.ReadLine();
        }

        public static void BinaryWriterReader()
        {
            Console.WriteLine("***** Fun with Binary Writers / Readers *****\n");

            // Open a binary writer for a file.
            using (var f = new FileStream("BinFile.dat", FileMode.Create, FileAccess.Write))
            {
                using (var bw = new BinaryWriter(f))
                {
                    // Print out the type of BaseStream.
                    // (System.IO.FileStream in this case).
                    Console.WriteLine("Base stream is: {0}", bw.BaseStream);

                    // Create some data to save in the file
                    double aDouble = 1234.67;
                    int anInt = 34567;
                    string aString = "A, B, C";

                    // Write the data
                    bw.Write(aDouble);
                    bw.Write(anInt);
                    bw.Write(aString);
                }

                Console.WriteLine("Done!");
                using (var input = new FileStream("BinFile.dat", FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader br = new BinaryReader(input))
                    {
                        Console.WriteLine(br.ReadDouble());
                        Console.WriteLine(br.ReadInt32());
                        Console.WriteLine(br.ReadString());
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
