using System;
using System.IO;

namespace ExamCreator.Classes
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
            // Загружаем файл теста .xml
            var myFile = File.ReadAllBytes(filename);
            // Зашифровываем файл
            var newFile = Crypt(myFile);
            // Определяем новое расширение
            var newFileName = NewFileName(filename);
            // Сохраняем зашифрованный файл с новым расширением
            File.WriteAllBytes(newFileName, newFile);
        }
        
        /// <summary>
        /// Функция шифрования XOR
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        private static byte[] Crypt(byte[] bytes)
        {
            double len = Buffer.ByteLength(bytes);
            while (len/256 >= 1)
            {
                len /= len/256+1;
            }

            var key = Convert.ToByte(Convert.ToInt32(len));
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] ^= key;
            }
            return bytes;
        }
        
        /// <summary>
        /// Функция определения нового расширения файла
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static string NewFileName(string fileName)
        {
            // Если файл уже с расширением .crypt, то возвращаем имя файла
            if (fileName.EndsWith(".crypt")) return fileName;
            fileName = Path.ChangeExtension(fileName, "crypt");
            return fileName;
        }
    }
}