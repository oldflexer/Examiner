using System;
using System.Collections.Generic;
using System.Linq;
using MaterialSkin.Controls;

namespace Examiner.Classes
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
        /// Индекс текущего вопроса
        /// </summary>
        private readonly int _currentIndex;
        
        /// <summary>
        /// Список полей для ввода
        /// </summary>
        private readonly List<MaterialLabel> _labels;
        
        /// <summary>
        /// Список чекбоксов
        /// </summary>
        private readonly List<MaterialCheckbox> _checkBoxes;

        /// <summary>
        /// Массив ответов пользователя
        /// </summary>
        private readonly IReadOnlyList<List<int>> _answers;

        /// <summary>
        /// Стандартный конструктор
        /// </summary>
        /// <param name="pages"></param>
        /// <param name="currentIndex"></param>
        /// <param name="labels"></param>
        /// <param name="checkBoxes"></param>
        /// <param name="answers"></param>
        public Loader(IReadOnlyList<Page> pages, int currentIndex, ref List<MaterialLabel> labels, ref List<MaterialCheckbox> checkBoxes, IReadOnlyList<List<int>> answers = null)
        {
            _currentIndex = currentIndex;
            _labels = labels;
            _checkBoxes = checkBoxes;
            _answers = answers;
            // Определяем страницу теста под текущим индексом из списка страниц
            _page = pages[currentIndex];
            
            Load();
        }

        /// <summary>
        /// Функция загрузки страницы
        /// </summary>
        private void Load()
        {
            // Записываем данные со страницы в надписи экзаменатора и скрываем варианты ответа без вопроса
            for (var i = 0; i < _labels.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        _labels[i].Text = _page.Question;
                        break;
                    
                    case 1:
                        _labels[i].Visible = false;
                        _checkBoxes[i - 1].Visible = false;
                        if (_page.Answer1 != "")
                        {
                            _labels[i].Visible = true;
                            _checkBoxes[i - 1].Visible = true;
                            _labels[i].Text = _page.Answer1;
                        }
                        break;
                    
                    case 2:
                        _labels[i].Visible = false;
                        _checkBoxes[i - 1].Visible = false;
                        if (_page.Answer2 != "")
                        {
                            _labels[i].Visible = true;
                            _checkBoxes[i - 1].Visible = true;
                            _labels[i].Text = _page.Answer2;
                        }
                        break;
                    
                    case 3:
                        _labels[i].Visible = false;
                        _checkBoxes[i - 1].Visible = false;
                        if (_page.Answer3 != "")
                        {
                            _labels[i].Visible = true;
                            _checkBoxes[i - 1].Visible = true;
                            _labels[i].Text = _page.Answer3;
                        }
                        break;
                    
                    case 4:
                        _labels[i].Visible = false;
                        _checkBoxes[i - 1].Visible = false;
                        if (_page.Answer4 != "")
                        {
                            _labels[i].Visible = true;
                            _checkBoxes[i - 1].Visible = true;
                            _labels[i].Text = _page.Answer4;
                        }
                        break;
                    
                    case 5:
                        // Если количество правильных ответов больше одного, то выводим соответствующую надпись, иначе для одного ответа
                        _labels[i].Text = _page.Correct.Count > 1 ? "Выберите несколько верных вариантов ответа" : "Выберите верный вариант ответа";
                        break;
                }
            }
            
            // Отмечаем чекбоксы со страницы ответов пользователя в чекбоксы экзаменатора
            foreach (var cb in _checkBoxes)
            {
                // Сначала отчистим чекбокс
                cb.Checked = false;

                // Если пользователь еще не давал ответов на этот вопрос, то пропускаем итерацию
                if (_answers?[_currentIndex] == null) continue;
                
                // Выводим ответы пользователя и включаем отображение
                foreach (var answer in _answers[_currentIndex].Where(answer => Convert.ToInt32(cb.Tag) == answer))
                {
                    cb.Checked = true;
                }
            }
        }
    }
}