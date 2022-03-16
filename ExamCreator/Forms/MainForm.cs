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
        /// Переменная для отслеживания открытия теста
        /// </summary>
        private bool _opening;
        
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
            // Создаем редактор для нового теста
            _opening = false;
            var editor = new Editor(ref _opening);
            
            // Отображаем едактор, скрываем меню
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
            // Создаем редактор для открытого теста
            _opening = true;
            var editor = new Editor(ref _opening);

            // Если пользователь прервал открытие, то выходим из функции
            if (!_opening)
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