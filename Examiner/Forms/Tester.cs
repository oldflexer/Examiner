using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Examiner.Classes;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Examiner.Forms
{
    /// <summary>
    /// Форма "Экзаменатор"
    /// </summary>
    public partial class Tester : MaterialForm
    {
        /// <summary>
        /// Список страниц теста
        /// </summary>
        private readonly List<Page> _pages = new List<Page>();
        /// <summary>
        /// Индекс текущей страницы
        /// </summary>
        private int _currentIndex;
        /// <summary>
        /// Список надписей
        /// </summary>
        private List<MaterialLabel> _labels = new List<MaterialLabel>();
        /// <summary>
        /// Список чекбоксов
        /// </summary>
        private List<MaterialCheckbox> _checkBoxes = new List<MaterialCheckbox>();
        /// <summary>
        /// Список из списков отмеченных ответов
        /// </summary>
        private readonly List<List<int>> _answers = new List<List<int>>();

        /// <summary>
        /// Стандартный конструктор
        /// </summary>
        /// <param name="isOpening"></param>
        public Tester(ref bool isOpening)
        {
            InitializeComponent();
            
            // Применяем тему с главной формы
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            // Добавляем надписи в список надписей
            _labels.Add(lQuestion);
            _labels.Add(lAnswer1);
            _labels.Add(lAnswer2);
            _labels.Add(lAnswer3);
            _labels.Add(lAnswer4);
            _labels.Add(lAnswers);
            
            // Добавляем чекбоксы в список чекбоксы
            _checkBoxes.Add(cbOne);
            _checkBoxes.Add(cbTwo);
            _checkBoxes.Add(cbThree);
            _checkBoxes.Add(cbFour);

            switch (isOpening)
            {
                // Если происходит открытие теста для редактирования, то
                case true:
                {
                    // Создаем объект класса открытия
                    var open = new Opener(ref _pages, ref _labels, ref _checkBoxes, ref isOpening);
                    
                    // Если пользователь прервал открытие, то выходим из функции
                    if (!isOpening)
                    {
                        return;
                    }
                }
            }
            
            // Если происходит открытие теста для прохождения, то
            if (isOpening)
            {
                
                
                
                // Обновляем полосу прогресса и надпись текущего вопроса
                pbQuestions.Maximum = _pages.Count;
                pbQuestions.Value = 1;
                lQuestionNum.Text = $@"Вопрос {pbQuestions.Value}/{pbQuestions.Maximum}";
                // Определяем длину списка ответов, основываясь на длине теста
                _answers = new List<List<int>>(_pages.Count);

                // Определяем все ответы сначала как отрицательные
                for (var i = 0; i < _answers.Capacity; i++)
                {
                    _answers.Add(new List<int>());
                }
            }
            // Иначе выводим ошибку
            else
            {
                MessageBox.Show("Ошибка в чтении файла!");
                Close();
            }
        }

        /// <summary>
        /// Функция триггер при закрытии экзаменатора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tester_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainForm = Application.OpenForms[0];
            mainForm.Show();
        }
        
        /// <summary>
        /// Нажатие кнопки "В главное меню"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bBack_Click(object sender, EventArgs e)
        {
            // Закрыть экзаменатор
            Close();
        }

        /// <summary>
        /// Нажатие кнопки "Завершить тест"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bEndTest_Click(object sender, EventArgs e)
        {
            // Создаем объект класса проверки теста
            var saver = new Saver(_pages, _answers);
            // Закрываем экзаменатор
            Close();
        }

        /// <summary>
        /// Нажатие кнопки "Предыдущий вопрос"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bPrev_Click(object sender, EventArgs e)
        {
            // Если пользователь на первой странице, то выходим из функции
            if (_currentIndex == 0) return;
            
            // Уменьшаем текущий индекс на 1
            _currentIndex -= 1;
            // Загружаем предыдущую страницу
            var load = new Loader(_pages, _currentIndex, ref _labels, ref _checkBoxes, _answers);
            
            // Обновляем полосу прогресса и надпись текущего вопроса
            pbQuestions.Value -= 1;
            lQuestionNum.Text = $@"Вопрос {pbQuestions.Value}/{pbQuestions.Maximum}";
        }

        /// <summary>
        /// Нажатие кнопки "Следующий вопрос"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bNext_Click(object sender, EventArgs e)
        {
            // Если пользователь на последней странице, то выходим из функции
            if (_currentIndex == _pages.Count - 1) return;
            
            // Увеличиваем текущий индекс на 1
            _currentIndex += 1;
            // Загружаем следующую страницу
            var load = new Loader(_pages, _currentIndex, ref _labels, ref _checkBoxes, _answers);
            
            // Обновляем полосу прогресса и надпись текущего вопроса
            pbQuestions.Value += 1;
            lQuestionNum.Text = $@"Вопрос {pbQuestions.Value}/{pbQuestions.Maximum}";
        }

        /// <summary>
        /// Нажатие на кнопку "Сохранить ответ"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSaveAnswer_Click(object sender, EventArgs e)
        {
            // Отчищаем текущие ответы на вопрос
            _answers[_currentIndex].Clear();
            
            // Сохраняем ответы со страницы экзаменатора
            foreach (var cb in _checkBoxes.Where(cb => cb.Checked))
            {
                _answers[_currentIndex].Add(Convert.ToInt32(cb.Tag));
            }
        }
    }
}