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
        /// Текущая страница
        /// </summary>
        private readonly Page _page;
        
        /// <summary>
        /// Список полей для ввода
        /// </summary>
        private readonly List<MaterialTextBox2> _textBoxes;
        
        /// <summary>
        /// Список чекбоксов
        /// </summary>
        private readonly List<MaterialCheckbox> _checkBoxes;
        
        /// <summary>
        /// Стандартный конструктор
        /// </summary>
        /// <param name="pages"></param>
        /// <param name="currentIndex"></param>
        /// <param name="textBoxes"></param>
        /// <param name="checkBoxes"></param>
        public Loader(IReadOnlyList<Page> pages, int currentIndex, ref List<MaterialTextBox2> textBoxes, ref List<MaterialCheckbox> checkBoxes)
        {
            _textBoxes = textBoxes;
            _checkBoxes = checkBoxes;
            // Определяем страницу теста под текущим индексом из списка страниц
            _page = pages[currentIndex];

            Load();
        }

        /// <summary>
        /// Функция загрузки страницы
        /// </summary>
        private void Load()
        {
            // Записываем данные со страницы в поля редактора
            for (var i = 0; i < _textBoxes.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        _textBoxes[i].Text = _page.Question;
                        break;
                    case 1:
                        _textBoxes[i].Text = _page.Answer1;
                        break;
                    case 2:
                        _textBoxes[i].Text = _page.Answer2;
                        break;
                    case 3:
                        _textBoxes[i].Text = _page.Answer3;
                        break;
                    case 4:
                        _textBoxes[i].Text = _page.Answer4;
                        break;
                }
            }

            // Отмечаем чекбоксы со страницы в чекбоксы редактора
            foreach (var cb in _checkBoxes)
            {
                // Сначала отчистим все
                cb.Checked = false;

                // Отметим верные
                foreach (var index in _page.Correct.Where(index => Convert.ToInt32(cb.Tag) == index))
                {
                    cb.Checked = true;
                }
            }
        }
    }
}