using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

namespace Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string pattern = @"^(?<group>[A-Z][a-z\s+']+):(?<song>[A-Z\s]+)$";

                Match match = Regex.Match(input, pattern);
                if (!match.Success)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                string artist = match.Groups["group"].Value;
                string song = match.Groups["song"].Value;

                int encryptionKey = artist.Length;
                string encryptedSong = string.Empty;
                char resultChar = ' ';
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != ' ' && @input[i] != '\'' && input[i] != ':')
                    {
                        resultChar = (char)(input[i] + encryptionKey);
                        if (char.IsLower(input[i]) && resultChar > 122)
                        {
                            resultChar = (char)(resultChar - 26);
                        }
                        if (char.IsUpper(input[i]) && resultChar > 90)
                        {
                            resultChar = (char)(resultChar - 26);
                        }
                    }
                    else
                    {
                        resultChar = input[i];
                    }
                    encryptedSong += resultChar;
                    encryptedSong = encryptedSong.Replace(':', '@');
                }
                Console.WriteLine($"Successful encryption: {string.Join("@", encryptedSong)}");
                
            }
        }
    }
}
