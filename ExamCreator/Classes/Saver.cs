using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ExamCreator.Classes
{
    /// <summary>
    /// Класс сохранения
    /// </summary>
    public class Saver
    {
        /// <summary>
        /// Стандартный конструктор
        /// </summary>
        /// <param name="pages"></param>
        public Saver(List<Page> pages)
        {
            // Диалог с пользователем "Сохранить как"
            var saveDialog = new SaveFileDialog(); 
            saveDialog.Filter = @"Test file(*.xml)|*.xml|All files(*.*)|*.*";

            // Если пользователь прервал операцию, то выходим из конструктора
            if (saveDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            // Полное имя файла
            var filename = saveDialog.FileName;
            
            // Сериализация xml (Сохраняем список страниц теста в xml файл)
            var formatter = new XmlSerializer(typeof(Page[]));
            using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                var temp = pages.ToArray();
                formatter.Serialize(fs, temp);
            }
            
            // Шифрование файла теста
            var cryptographer = new Cryptographer(filename);
        }
    }
}