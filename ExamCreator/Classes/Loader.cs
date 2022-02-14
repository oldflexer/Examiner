using System;
using System.Collections.Generic;
using System.Linq;
using MaterialSkin.Controls;

namespace ExamCreator.Classes
{
    /// <summary>
    /// Класс загрузчика
    /// </summary>
    public class Loader
    {
        /// <summary>
        /// Стандартный конструктор
        /// </summary>
        /// <param name="pages"></param>
        /// <param name="currentIndex"></param>
        /// <param name="textBoxes"></param>
        /// <param name="checkBoxes"></param>
        public Loader(IReadOnlyList<Page> pages, int currentIndex, ref List<MaterialTextBox2> textBoxes, ref List<MaterialCheckbox> checkBoxes)
        {
            // Определяем страницу теста под текущим индексом из списка страниц
            var page = pages[currentIndex];

            // Записываем данные со страницы в поля редактора
            for (var i = 0; i < textBoxes.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        textBoxes[i].Text = page.Question;
                        break;
                    case 1:
                        textBoxes[i].Text = page.Answer1;
                        break;
                    case 2:
                        textBoxes[i].Text = page.Answer2;
                        break;
                    case 3:
                        textBoxes[i].Text = page.Answer3;
                        break;
                    case 4:
                        textBoxes[i].Text = page.Answer4;
                        break;
                }
            }

            // Отмечаем чекбоксы со страницы в чекбоксы редактора
            foreach (var cb in checkBoxes)
            {
                // Сначала отчистим все
                cb.Checked = false;

                // Отметим верные
                foreach (var index in page.Correct.Where(index => Convert.ToInt32(cb.Tag) == index))
                {
                    cb.Checked = true;
                }
            }
        }
    }
}