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
        /// Ключ шифрования
        /// </summary>
        private byte _key = 111;
        
        /// <summary>
        /// Стандартный конструктор
        /// </summary>
        /// <param name="filename"></param>
        public Cryptographer(string filename)
        {
            // Функция шифрования XOR
            byte[] Crypt(byte[] bytes)
            {
                for (var i = 0; i < bytes.Length; i++)
                {
                    bytes[i] ^= _key;
                    _key += 1;
                }
                return bytes;
            }
            
            // Функция определения нового расширения файла
            string NewFileName(string fileName)
            {
                // Если файл уже с расширением .crypt, то возвращаем имя файла
                if (fileName.EndsWith(".crypt")) return fileName;
                fileName = Path.ChangeExtension(fileName, "crypt");
                return fileName;
            }
            
            // Загружаем файл теста .xml
            var myFile = File.ReadAllBytes(filename);
            // Зашифровываем файл
            var newFile = Crypt(myFile);
            // Определяем новое расширение
            var newFileName = NewFileName(filename);
            // Сохраняем зашифрованный файл с новым расширением
            File.WriteAllBytes(newFileName, newFile);
        }
    }
}