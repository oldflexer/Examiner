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
        /// Стандартный конструктор
        /// </summary>
        /// <param name="pages"></param>
        /// <param name="currentIndex"></param>
        /// <param name="labels"></param>
        /// <param name="checkBoxes"></param>
        /// <param name="answers"></param>
        public Loader(IReadOnlyList<Page> pages, int currentIndex, ref List<MaterialLabel> labels, ref List<MaterialCheckbox> checkBoxes, IReadOnlyList<List<int>> answers = null)
        {
            // Определяем страницу теста под текущим индексом из списка страниц
            var page = pages[currentIndex];

            // Записываем данные со страницы в надписи экзаменатора
            for (var i = 0; i < labels.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        labels[i].Text = page.Question;
                        break;
                    case 1:
                        labels[i].Text = page.Answer1;
                        break;
                    case 2:
                        labels[i].Text = page.Answer2;
                        break;
                    case 3:
                        labels[i].Text = page.Answer3;
                        break;
                    case 4:
                        labels[i].Text = page.Answer4;
                        break;
                    case 5:
                        // Если количество правильных ответов больше одного, то выводим соответствующую надпись, иначе для одного ответа
                        labels[i].Text = page.Correct.Count > 1 ? "Выберите несколько верных вариантов ответа" : "Выберите верный вариант ответа";
                        break;
                }
            }
            
            // Отмечаем чекбоксы со страницы ответов пользователя в чекбоксы экзаменатора
            foreach (var cb in checkBoxes)
            {
                // Сначала отчистим все
                cb.Checked = false;
                
                // Если пользователь еще не давал ответов на этот вопрос, то пропускаем итерацию
                if (answers?[currentIndex] == null) continue;
                // Выводим ответы пользователя
                foreach (var answer in answers[currentIndex].Where(answer => Convert.ToInt32(cb.Tag) == answer))
                {
                    cb.Checked = true;
                }
            }
        }
    }
}