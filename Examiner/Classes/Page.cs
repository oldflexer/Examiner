using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Examiner.Classes
{
    /// <summary>
    /// Класс страницы теста
    /// </summary>
    public class Page
    {
        /// <summary>
        /// Вопрос на странице
        /// </summary>
        public string Question;
        /// <summary>
        /// Ответ 1
        /// </summary>
        public string Answer1;
        /// <summary>
        /// Ответ 2
        /// </summary>
        public string Answer2;
        /// <summary>
        /// Ответ 3
        /// </summary>
        public string Answer3;
        /// <summary>
        /// Ответ 4
        /// </summary>
        public string Answer4;
        /// <summary>
        /// Список тэгов верных ответов
        /// </summary>
        public readonly List<int> Correct = new List<int>();
        
        /// <summary>
        /// Пустой конструктор для XmlSerializer
        /// </summary>
        public Page() {}
    }
}