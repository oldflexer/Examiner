using System;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ExamCreator.Forms
{
    /// <summary>
    /// Главная форма (Главное меню)
    /// </summary>
    public partial class MainForm : MaterialForm
    {
        /// <summary>
        /// Переменная открытия редактора
        /// </summary>
        private bool _isOpening;
        
        /// <summary>
        /// Конструктор главной формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // Настройка цветовой темы для окон
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue500,
                Primary.Blue800,
                Primary.Blue900,
                Accent.Blue700,
                TextShade.WHITE);
        }
        
        /// <summary>
        /// Нажатие на кнопку "Новый тест"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bNew_Click(object sender, EventArgs e)
        {
            _isOpening = false;
            // Создаем редактор для нового теста
            var editor = new Editor(_isOpening);
            
            // Отображаем редактор, скрываем меню
            editor.Show();
            Hide();
        }

        /// <summary>
        /// Нажатие на кнопку "Открыть тест"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bOpen_Click(object sender, EventArgs e)
        {
            _isOpening = true;
            // Создаем редактор для открытого теста
            var editor = new Editor(_isOpening);

            // Если пользователь прервал открытие, то выходим из функции
            if (!_isOpening)
            {
                return;
            }
            
            // Отображаем редактор, скрываем меню
            editor.Show();
            Hide();
        }

        /// <summary>
        /// Нажатие на кнопку "Выход"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bExit_Click(object sender, EventArgs e)
        {
            // Закрыть MainForm = закрыть все
            Close();
        }
    }
}