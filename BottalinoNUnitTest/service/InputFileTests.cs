using Bottalino.model;
using Bottalino.utils;
using NUnit.Framework;
using System.IO;

namespace Bottalino.service
{
    [TestFixture]
    public class InputFileTests
    {
        static bool FileEquals(string path1, string path2)
        {
            byte[] file1 = File.ReadAllBytes(path1);
            byte[] file2 = File.ReadAllBytes(path2);
            if (file1.Length == file2.Length)
            {
                for (int i = 0; i < file1.Length; i++)
                {
                    if (file1[i] != file2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        [Test]
        public void InputFilegenerationExample1()
        {
                  

            string path = Directory.GetCurrentDirectory();
            string tmpFile = Utils.RandomString(10);
            string id = "0000000001";
            string absoluteFilename = path + "/" + tmpFile + ".dat";
            string testAbsoluteFilename = Path.Combine(NUnit.Framework.TestContext.CurrentContext.TestDirectory, "TestFiles", "ricetta01.dat");

            Ricetta ricetta = new Ricetta(id);
            ricetta.Speed = 20;
            ricetta.Temperature = 30;
            ricetta.Hours = 0;
            ricetta.Minutes = 50;
            ricetta.Seconds = 30;
            ricetta.NumberOfTimeCards = 5;
            InputFile.GenerateInputFile(absoluteFilename, ricetta);
            NUnit.Framework.Assert.IsTrue(FileEquals(testAbsoluteFilename, absoluteFilename));
            File.Delete(absoluteFilename);
        }
    }
}
