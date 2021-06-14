using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace M10_2
{
    public class File
    {
        public static void ShowFrequency()
        {
            using (FileStream filestream =new  FileStream(@"D:\EPAM\test.txt", FileMode.Open))
            {
                byte[] array = new byte[filestream.Length];
                filestream.Read(array, 0, array.Length);
                string textFromFile = Encoding.Default.GetString(array);
                string helperText=null;
                foreach (var item in textFromFile.ToArray())
                {
                    helperText += item.ToString().ToLower();
                }
                var arrayWords = helperText.Split(' ', ',','.','!','?').Where(x=>x!="");
                var uniqueWords = arrayWords;
                uniqueWords=uniqueWords.Distinct().ToArray();
                foreach (var item in uniqueWords)
                {
                    Console.WriteLine($"Word:{item}; count:{arrayWords.Where(x => x == item).Count()}");
                }
            }
        }
    }
}
