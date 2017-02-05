using System;
using System.IO;

namespace ViceAdfDecrypt
{
    class Program
    {
        static void Usage()
        {
            Console.Error.WriteLine("ViceAdfDecrypt <input_radio_station.adf>");
            Environment.Exit(1);
        }

        static void Main(string[] args)
        {
            try
            {
                if (args.Length != 1)
                    Usage();

                string input = args[0];

                byte[] file_bytes = File.ReadAllBytes(input);
                for (int i = 0; i < file_bytes.Length; i++)
                {
                    file_bytes[i] ^= 0x22;
                }
                string output = Path.GetFileNameWithoutExtension(input) + ".mp3";
                File.WriteAllBytes(output, file_bytes);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("And error has occured:" + Environment.NewLine + e.Message);
                Environment.Exit(1);
            }
        }
    }
}
