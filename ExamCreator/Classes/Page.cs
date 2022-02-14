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
        /// <param name="tQuestion"></param>
        /// <param name="tAnswer1"></param>
        /// <param name="tAnswer2"></param>
        /// <param name="tAnswer3"></param>
        /// <param name="tAnswer4"></param>
        /// <param name="cbOne"></param>
        /// <param name="cbTwo"></param>
        /// <param name="cbThree"></param>
        /// <param name="cbFour"></param>
        /// <param name="gData"></param>
        public Page(MaterialTextBox2 tQuestion,
            MaterialTextBox2 tAnswer1,
            MaterialTextBox2 tAnswer2,
            MaterialTextBox2 tAnswer3,
            MaterialTextBox2 tAnswer4,
            MaterialCheckbox cbOne,
            MaterialCheckbox cbTwo,
            MaterialCheckbox cbThree,
            MaterialCheckbox cbFour,
            GroupBox gData)
        {
            // Записываем значения из полей ввода в поля объекта
            Question = tQuestion.Text;
            Answer1 = tAnswer1.Text;
            Answer2 = tAnswer2.Text;
            Answer3 = tAnswer3.Text;
            Answer4 = tAnswer4.Text;

            // Записываем значения из чекбоксов в список верных ответов
            foreach (var item in gData.Controls)
            {
                if (item is MaterialCheckbox cb && cb.Checked)
                {
                    Correct.Add(Convert.ToInt32(cb.Tag));
                }
            }
        }
    }
}