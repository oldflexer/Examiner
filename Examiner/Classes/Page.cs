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

        // /// <summary>
        // /// Стандартный конструктор
        // /// </summary>
        // /// <param name="lQuestion"></param>
        // /// <param name="lAnswer1"></param>
        // /// <param name="lAnswer2"></param>
        // /// <param name="lAnswer3"></param>
        // /// <param name="lAnswer4"></param>
        // /// <param name="cbOne"></param>
        // /// <param name="cbTwo"></param>
        // /// <param name="cbThree"></param>
        // /// <param name="cbFour"></param>
        // /// <param name="gData"></param>
        // public Page(MaterialLabel lQuestion,
        //     MaterialLabel lAnswer1,
        //     MaterialLabel lAnswer2,
        //     MaterialLabel lAnswer3,
        //     MaterialLabel lAnswer4,
        //     MaterialCheckbox cbOne,
        //     MaterialCheckbox cbTwo,
        //     MaterialCheckbox cbThree,
        //     MaterialCheckbox cbFour,
        //     GroupBox gData)
        // {
        //     // Записываем значения из полей ввода в поля объекта
        //     Question = lQuestion.Text;
        //     Answer1 = lAnswer1.Text;
        //     Answer2 = lAnswer2.Text;
        //     Answer3 = lAnswer3.Text;
        //     Answer4 = lAnswer4.Text;
        //
        //     // Записываем значения из чекбоксов в список верных ответов
        //     foreach (var item in gData.Controls)
        //     {
        //         if (item is MaterialCheckbox cb && cb.Checked)
        //         {
        //             Correct.Add(Convert.ToInt32(cb.Tag));
        //         }
        //     }
        // }
    }
}