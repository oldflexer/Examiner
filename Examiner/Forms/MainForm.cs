using System;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Examiner.Forms
{
    /// <summary>
    /// Главная форма (Главное меню)
    /// </summary>
    public partial class MainForm : MaterialForm
    {
        /// <summary>
        /// Переменная для отслеживания открытия теста
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
        /// Нажатие на кнопку "Открыть тест"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bOpen_Click(object sender, EventArgs e)
        {
            // Создаем экзаменатор для открытого теста
            _isOpening = true;
            var tester = new Tester(ref _isOpening);
            
            // Если открытие теста прервано, то ничего не происходит
            if (!_isOpening) return;
            
            // Отображаем экзаменатор, скрываем меню
            tester.Show();
            Hide();
        }

        /// <summary>
        /// Нажатие на кнопку "Выход"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}