using Masks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FindInformation
{
    //Класс для работы с файлом
    public class FileEngine
    {
        //открыть файл
        public static List<Mask> OpenFile(string filePath)
        {
            List<string> masksInfo = new List<string>();
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        masksInfo.Add(line);
                    }
                };
            }
            catch
            {
                Console.WriteLine("File Not Found");
            }
            return ConvertTextToMasks(masksInfo);
        }
        public static List<Mask> ConvertTextToMasks(List<string> text)
        {
            List<Mask> masks = new List<Mask>();

            for (int i = 0; i < text.Count; i += 2)
            {
                Mask mask = new Mask
                {
                    name = text[i],
                    path =text[i+1]
                };
                masks.Add(mask);
            }
            return masks;
        }
    }
}
