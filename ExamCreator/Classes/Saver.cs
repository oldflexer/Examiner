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
        /// Список страниц теста
        /// </summary>
        private List<Page> _pages;
        
        /// <summary>
        /// Полное имя файла
        /// </summary>
        private string _filename;

        /// <summary>
        /// Переменная отслеживания сохранения теста
        /// </summary>
        private bool _isSaving;
        
        /// <summary>
        /// Стандартный конструктор
        /// </summary>
        /// <param name="pages"></param>
        public Saver(List<Page> pages)
        {
            _pages = pages;
            _filename = "";

            _isSaving = IsDialogCompleted();

            if (_isSaving)
            {
                Save();
            }
        }

        /// <summary>
        /// Функция диалогового окна
        /// </summary>
        /// <returns></returns>
        private bool IsDialogCompleted()
        {
            // Диалог с пользователем "Сохранить как"
            var saveDialog = new SaveFileDialog(); 
            saveDialog.Filter = @"Test file(*.xml)|*.xml|All files(*.*)|*.*";

            // Если пользователь прервал операцию, то выходим из конструктора
            if (saveDialog.ShowDialog() == DialogResult.Cancel)
            {
                return false;
            }

            // Полное имя файла
            _filename = saveDialog.FileName;

            return true;
        }

        /// <summary>
        /// Функция сохранения в файл
        /// </summary>
        private void Save()
        {
            // Сериализация xml (Сохраняем список страниц теста в xml файл)
            var formatter = new XmlSerializer(typeof(Page[]));
            using (var fs = new FileStream(_filename, FileMode.OpenOrCreate))
            {
                var temp = _pages.ToArray();
                formatter.Serialize(fs, temp);
            }
            
            // Шифрование файла теста
            var cryptographer = new Cryptographer(_filename);
        }
    }
}