using Bottalino.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bottalino.service
{
    public static class InputFile
    {
        public static void GenerateInputFile(string absoluteFilename, Ricetta ricetta)
        {
            List<string> contentFile = new List<string>();
            string firstLine = ricetta.Id.PadLeft(10, '0') + ricetta.Speed.ToString().PadLeft(2, '0')
                + ricetta.Temperature.ToString().PadLeft(2, '0') + ricetta.Hours.ToString().PadLeft(2, '0') + ricetta.Minutes.ToString().PadLeft(2, '0') + ricetta.Seconds.ToString().PadLeft(2, '0');

            contentFile.Add(firstLine);
            int startingCards = 1111;
            for (int i = 0; i < ricetta.NumberOfTimeCards; i++)
            {
                int cards = startingCards + i;
                string line = cards.ToString().PadLeft(10, '0');
                contentFile.Add(line);
            }

            for (int i = 0; i < 100 - ricetta.NumberOfTimeCards; i++)
            {                
                contentFile.Add("0000000000");
            }
            string lastLine = contentFile.ElementAt(100);
            contentFile.RemoveAt(100);
            File.AppendAllLines(absoluteFilename, contentFile);
            File.AppendAllText(absoluteFilename, lastLine);
        }
    }
}
