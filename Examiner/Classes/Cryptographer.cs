using System;
using System.IO;

namespace Examiner.Classes
{
    /// <summary>
    /// Класс шифровальщик
    /// </summary>
    public class Cryptographer
    {
        /// <summary>
        /// Стандартный конструктор
        /// </summary>
        /// <param name="filename"></param>
        public Cryptographer(string filename)
        {
            // Собственная функция расшифровки XOR
            byte[] Crypt(byte[] bytes)
            {
                double len = Buffer.ByteLength(bytes);
                while (len/256 >= 1)
                {
                    len /= len/256+1;
                }

                byte key = Convert.ToByte(Convert.ToInt32(len));
                for (var i = 0; i < bytes.Length; i++)
                {
                    bytes[i] ^= key;
                }
                return bytes;
            }
            
            // Функция определения нового расширения файла
            string NewFileName(string fileName)
            {
                // Если файл уже с расширением .xml, то возвращаем имя файла
                if (fileName.EndsWith(".xml")) return fileName;
                fileName = Path.ChangeExtension(fileName, "xml");
                return fileName;
            }

            // Загружаем файл теста .crypt
            var myFile = File.ReadAllBytes(filename);
            // Расшифровываем файл
            var newFile = Crypt(myFile);
            // Временный каталог хранения расшифрованного теста
            const string path = @"C:\temp\Examiner";
            // Если каталога не существует, то
            if (!Directory.Exists(path))
            {
                // Создаем каталог
                Directory.CreateDirectory(path);
            }
            // Определяем новое расширение
            var newFileName = NewFileName(path + @"\tmp.xml");
            // Сохраняем расшифрованный файл с новым расширением
            File.WriteAllBytes(newFileName, newFile);
        }
    }
}