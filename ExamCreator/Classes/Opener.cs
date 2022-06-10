using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using MaterialSkin.Controls;

namespace ExamCreator.Classes
{
    /// <summary>
    /// Класс открытия
    /// </summary>
    public class Opener
    {
        /// <summary>
        /// Список страниц теста
        /// </summary>
        private List<Page> _pages;
        
        /// <summary>
        /// Список полей для ввода
        /// </summary>
        private List<MaterialTextBox2> _textBoxes;
        
        /// <summary>
        /// Список чекбоксов
        /// </summary>
        private List<MaterialCheckbox> _checkBoxes;

        /// <summary>
        /// Полное имя файла
        /// </summary>
        private string _filename;
        
        /// <summary>
        /// Переменная отслеживания открытия теста
        /// </summary>
        public readonly bool isOpening;

        /// <summary>
        /// Стандартный конструктор
        /// </summary>
        /// <param name="pages"></param>
        /// <param name="textBoxes"></param>
        /// <param name="checkBoxes"></param>
        public Opener(ref List<Page> pages, ref List<MaterialTextBox2> textBoxes, ref List<MaterialCheckbox> checkBoxes)
        {
            _pages = pages;
            _textBoxes = textBoxes;
            _checkBoxes = checkBoxes;
            _filename = "";
            
            isOpening = IsDialogCompleted();

            if (isOpening)
            {
                Open();
            }
        }

        /// <summary>
        /// Функция диалогового окна
        /// </summary>
        /// <returns></returns>
        private bool IsDialogCompleted()
        {
            // Диалог с пользователем "Открыть"
            var openDialog = new OpenFileDialog();
            openDialog.Filter = @"Test file(*.xml)|*.xml|All files(*.*)|*.*";
            
            // Если пользователь прервал операцию, то вернемся в главное меню
            if (openDialog.ShowDialog() == DialogResult.Cancel)
            {
                return false;
            }
            
            // Полное имя файла
            _filename = openDialog.FileName;
            
            return true;
        }
        
        /// <summary>
        /// Функция чтения файла
        /// </summary>
        private void Open()
        {
            // Отчищаем список страниц
            _pages.Clear();

            // Определим и загрузим открываемый xml файл
            var xDoc = new XmlDocument();
            xDoc.Load(_filename);

            // Определим корневой элемент xml файла
            var xRoot = xDoc.DocumentElement;
            // Если xml-файл не пустой, то перебираем файл
            if (xRoot != null)
            {
                foreach (XmlElement xNode in xRoot)
                {
                    // Определяем новую страницу теста
                    var page = new Page();

                    foreach (XmlNode cNode in xNode.ChildNodes)
                    {
                        switch (cNode.Name)
                        {
                            case "Question":
                                page.Question = cNode.InnerText;
                                break;
                            case "Answer1":
                                page.Answer1 = cNode.InnerText;
                                break;
                            case "Answer2":
                                page.Answer2 = cNode.InnerText;
                                break;
                            case "Answer3":
                                page.Answer3 = cNode.InnerText;
                                break;
                            case "Answer4":
                                page.Answer4 = cNode.InnerText;
                                break;
                            case "Correct":
                            {
                                foreach (XmlElement cNodeCorrect in cNode.ChildNodes)
                                {
                                    page.Correct.Add(Convert.ToInt32(cNodeCorrect.InnerText));
                                }

                                break;
                            }
                        }
                    }

                    // Добавляем страницу в список страниц
                    _pages.Add(page);
                }
            }
            // Иначе добавляем в список страниц пустую страницу
            else
            {
                _pages.Add(new Page());
            }
            
            // Загружаем первую страницу в редактор
            var loader = new Loader(_pages, 0, ref _textBoxes, ref _checkBoxes);
        }
    }
}