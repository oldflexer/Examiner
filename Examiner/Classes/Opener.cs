using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using MaterialSkin.Controls;

namespace Examiner.Classes
{
    /// <summary>
    /// Класс открытия
    /// </summary>
    public class Opener
    {
        /// <summary>
        /// Стандартный конструктор
        /// </summary>
        /// <param name="pages"></param>
        /// <param name="labels"></param>
        /// <param name="checkBoxes"></param>
        /// <param name="opening"></param>
        public Opener(ref List<Page> pages, ref List<MaterialLabel> labels, ref List<MaterialCheckbox> checkBoxes, ref bool opening)
        {
            // Отчищаем список страниц
            pages.Clear();

            // Диалог с пользователем "Открыть"
            var openDialog = new OpenFileDialog();
            openDialog.Filter = @"Test file(*.crypt)|*.crypt|All files(*.*)|*.*";
            
            // Если пользователь прервал операцию, то вернемся в главное меню
            if (openDialog.ShowDialog() == DialogResult.Cancel)
            {
                opening = false;
                return;
            }

            // Полное имя файла
            var filename = openDialog.FileName;

            // Определяем шифровальщик и расшифровываем файл
            var cryptographer = new Cryptographer(filename);

            // Временный каталог хранения теста
            const string path = @"C:\temp\Examiner";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            // Полное имя файла
            filename = path + @"\tmp.xml";

            // Определим и загрузим открываемый xml файл
            var xDoc = new XmlDocument();
            xDoc.Load(filename);

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
                    pages.Add(page);
                }
            }
            // Иначе добавляем в список страниц пустую страницу
            else
            {
                pages.Add(new Page());
            }
            
            // Загружаем первую страницу в редактор
            var load = new Loader(pages, 0, ref labels, ref checkBoxes);
        }
    }
}