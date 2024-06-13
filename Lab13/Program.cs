using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal class Program
    {
    static void Main(string[] args)
        {
           string[] lines = File.ReadAllLines("input.txt");
           string[] parameters = lines[0].Split(' ');
           int amplitude = int.Parse(parameters[0]);
           int period = int.Parse(parameters[1]);
           char fillChar = lines[1][0];
           string sinusoid = GenerateSinusoid(amplitude, period, fillChar);

           File.WriteAllText("output.txt", sinusoid);
           Console.WriteLine("Done");
        }
    static string GenerateSinusoid(int amplitude, int period, char fillChar)
        {
            string sinusoid = "";
            for (int y = -amplitude; y <= amplitude; y++)
            {
                for (int x = 0; x < period; x++)
                {
                    double functionValue = Math.Sin(2 * Math.PI * x / period) * amplitude;
                    if (Math.Round(functionValue) == y)
                    {
                        sinusoid += fillChar;
                    }
                    else
                    {
                        sinusoid += " ";
                    }
                }
                sinusoid += "\n";
            }
            return sinusoid;
        }

    }   
}
    

