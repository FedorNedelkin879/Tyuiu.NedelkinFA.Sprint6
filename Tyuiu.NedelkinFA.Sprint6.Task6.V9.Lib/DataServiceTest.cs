using System.IO;
using Microsoft.Win32;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NedelkinFA.Sprint6.Task6.V9.Lib
{
    public class DataServiceTest : ISprint6Task6V9
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    var temp = line.Split(' ');

                    resStr += temp[^1] + " ";
                }
                return resStr.Trim();
            }
        }

        public string LoadFileToTextBox()
        {
            string filePath = "";

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                filePath = openFileDialog.FileName;
            }

            return CollectTextFromFile(filePath);
        }
    }
}
