using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace ExamCreator.Classes
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

        /// <summary>
        /// Стандартный конструктор
        /// </summary>
        /// <param name="boxQuestion"></param>
        /// <param name="boxAnswer1"></param>
        /// <param name="boxAnswer2"></param>
        /// <param name="boxAnswer3"></param>
        /// <param name="boxAnswer4"></param>
        /// <param name="cbOne"></param>
        /// <param name="cbTwo"></param>
        /// <param name="cbThree"></param>
        /// <param name="cbFour"></param>
        /// <param name="groupData"></param>
        public Page(Control boxQuestion,
            Control boxAnswer1,
            Control boxAnswer2,
            Control boxAnswer3,
            Control boxAnswer4,
            MaterialCheckbox cbOne,
            MaterialCheckbox cbTwo,
            MaterialCheckbox cbThree,
            MaterialCheckbox cbFour,
            Control groupData)
        {
            // Записываем значения из полей ввода в поля объекта
            Question = boxQuestion.Text;
            Answer1 = boxAnswer1.Text;
            Answer2 = boxAnswer2.Text;
            Answer3 = boxAnswer3.Text;
            Answer4 = boxAnswer4.Text;

            // Записываем значения из чекбоксов в список верных ответов
            foreach (var item in groupData.Controls)
            {
                if (item is MaterialCheckbox cb && cb.Checked)
                {
                    Correct.Add(Convert.ToInt32(cb.Tag));
                }
            }
        }
    }
}