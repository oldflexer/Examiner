using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ExamCreator.Classes;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ExamCreator.Forms
{
    /// <summary>
    /// Форма "Редактор"
    /// </summary>
    public partial class Editor : MaterialForm
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
        /// Списки полей для ввода
        /// </summary>
        private List<MaterialTextBox2> _textBoxes = new List<MaterialTextBox2>();
        
        /// <summary>
        /// Список чекбоксов
        /// </summary>
        private List<MaterialCheckbox> _checkBoxes = new List<MaterialCheckbox>();

        /// <summary>
        /// Конструктор редактора
        /// </summary>
        public Editor(bool isOpening)
        {
            InitializeComponent();
            
            // Применяем тему с главной формы
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            // Добавляем поля ввода в список полей
            _textBoxes.Add(tQuestion);
            _textBoxes.Add(tAnswer1);
            _textBoxes.Add(tAnswer2);
            _textBoxes.Add(tAnswer3);
            _textBoxes.Add(tAnswer4);
            
            // добавляем чекбоксы в список
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
                    var open = new Opener(ref _pages, ref _textBoxes, ref _checkBoxes);

                    if (!open.isOpening)
                    {
                        goto case false;
                    }

                    // Обновляем полосу прогресса и надпись текущего вопроса
                    UpdateProgress(_pages.Count, 1);
                    break;
                }
                // Иначе происходит создание нового теста
                case false:
                {
                    // Создаем новую страницу и добавляем ее в список страниц
                    var page = new Page(tQuestion, tAnswer1, tAnswer2, tAnswer3, tAnswer4, cbOne, cbTwo, cbThree, cbFour, gData);
                    _pages.Add(page);
                
                    // Обновляем полосу прогресса и надпись текущего вопроса
                    UpdateProgress(_pages.Count, 1);
                    break;
                }
            }
        }

        /// <summary>
        /// Функция обновления прогресса
        /// </summary>
        /// <param name="maximum"></param>
        /// <param name="value"></param>
        private void UpdateProgress(int maximum, int value)
        {
            pbQuestions.Maximum = maximum;
            pbQuestions.Value = value;
            lQuestionNum.Text = $@"Вопрос {pbQuestions.Value}/{pbQuestions.Maximum}";
        }
        
        /// <summary>
        /// Функция триггер при закрытии редактора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Editor_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Переходим в главную форму
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
            // Закрыть редактор
            Close();
        }
        
        /// <summary>
        /// Нажатие кнопки "Сохранить тест"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSaveTest_Click(object sender, EventArgs e)
        {
            // Создаем объект класса сохранение
            var save = new Saver(_pages);
        }

        /// <summary>
        /// Нажатие кнопки "Сохранить вопрос"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSaveQuestion_Click(object sender, EventArgs e)
        {
            // Перезаписываем страницу теста информацией со страницы редактора
            var page = new Page(tQuestion, tAnswer1, tAnswer2, tAnswer3, tAnswer4, cbOne, cbTwo, cbThree, cbFour, gData);
            _pages[_currentIndex] = page;
        }

        /// <summary>
        /// Нажатие кнопки "Новый вопрос"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bNewQuestion_Click(object sender, EventArgs e)
        {
            // Отчищаем поля 
            foreach (var tb in _textBoxes)
            {
                tb.Text = null;
            }

            // Отчищаем чекбоксы
            foreach (var cb in _checkBoxes)
            {
                cb.Checked = false;
            }
            
            // Создаем новую страницу и добавляем ее в список страниц
            var page = new Page(tQuestion, tAnswer1, tAnswer2, tAnswer3, tAnswer4, cbOne, cbTwo, cbThree, cbFour, gData);
            _pages.Add(page);
            
            // Текущий индекс равен последней странице теста
            _currentIndex = _pages.Count - 1;

            // Обновляем полосу прогресса и надпись текущего вопроса
            UpdateProgress(+1, _pages.Count);
        }
        
        /// <summary>
        /// Нажатие на кнопку "Отчистить поля"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bClear_Click(object sender, EventArgs e)
        {
            // Отчищаем поля 
            foreach (var tb in _textBoxes)
            {
                tb.Text = null;
            }

            // Отчищаем чекбоксы
            foreach (var cb in _checkBoxes)
            {
                cb.Checked = false;
            }
        }

        /// <summary>
        /// Нажатие на кнопку "Удалить вопрос"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bDelQuestion_Click(object sender, EventArgs e)
        {
            // Отчищаем поля
            foreach (var tb in _textBoxes)
            {
                tb.Text = null;
            }

            // Отчищаем чекбоксы
            foreach (var cb in _checkBoxes)
            {
                cb.Checked = false;
            }

            // Если кол-во страниц = 1, то выходим из функции
            if (_pages.Count == 1) return;
            
            // Удаляем страницу из списка страниц
            _pages.RemoveAt(_currentIndex);

            // Обновляем полосу прогресса и надпись текущего вопроса
            UpdateProgress(-1, -1);
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
            var load = new Loader(_pages, _currentIndex, ref _textBoxes, ref _checkBoxes);
            
            // Обновляем полосу прогресса и надпись текущего вопроса
            UpdateProgress(_pages.Count, -1);
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
            var load = new Loader(_pages, _currentIndex, ref _textBoxes, ref _checkBoxes);
            
            // Обновляем полосу прогресса и надпись текущего вопроса
            UpdateProgress(_pages.Count, +1);
        }
    }
}