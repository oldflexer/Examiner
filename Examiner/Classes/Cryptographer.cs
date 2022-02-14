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
        /// Ключ шифрования
        /// </summary>
        private byte _key = 111;

        /// <summary>
        /// Стандартный конструктор
        /// </summary>
        /// <param name="filename"></param>
        public Cryptographer(string filename)
        {
            // Функция расшифрования XOR
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