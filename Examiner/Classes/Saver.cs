using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Examiner.Classes
{
    /// <summary>
    /// Класс проверки теста
    /// </summary>
    public class Saver
    {
        /// <summary>
        /// Набранные баллы
        /// </summary>
        private double _score = 0;
        
        /// <summary>
        /// Максимально возможные баллы
        /// </summary>
        private double _maxScore = 0;
        
        /// <summary>
        /// Временная переменная верных ответов
        /// </summary>
        private double _tempScore = 0;
        
        /// <summary>
        /// Кол-во полных верных ответов на вопросы
        /// </summary>
        private double _scoreQuestions = 0;
        
        /// <summary>
        /// Максимально возможное кол-во полных верных ответов на вопросы
        /// </summary>
        private double _maxScoreQuestions = 0;
        
        /// <summary>
        /// Оценка за тест
        /// </summary>
        private int _mark = 0;
        
        /// <summary>
        /// Объект MS Office Excel
        /// </summary>
        private Excel.Application _excelApp;
        
        /// <summary>
        /// Объект состоящий из рабочих книг Excel
        /// </summary>
        private Excel.Workbooks _excelAppWorkbooks;
        
        /// <summary>
        /// Объект - рабочая книга
        /// </summary>
        private Excel.Workbook _excelAppWorkbook;
        
        /// <summary>
        /// Объект состоящий из страниц книги
        /// </summary>
        private Excel.Sheets _excelSheets;
        
        /// <summary>
        /// Объект - текущая рабочая страница
        /// </summary>
        private Excel.Worksheet _excelWorksheet;
        
        /// <summary>
        /// Объект - диапазон ячеек страницы
        /// </summary>
        private Excel.Range _excelCells;
        
        /// <summary>
        /// Путь к папке "Мои документы"
        /// </summary>
        private string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        /// <summary>
        /// Список вопросов теста
        /// </summary>
        private readonly List<Page> _pages;

        /// <summary>
        /// Список ответов пользователя
        /// </summary>
        private readonly IReadOnlyList<List<int>> _answers;

        /// <summary>
        /// Стандартный конструктор
        /// </summary>
        /// <param name="pages"></param>
        /// <param name="answers"></param>
        public Saver(List<Page> pages, IReadOnlyList<List<int>> answers)
        {
            _pages = pages;
            _answers = answers;
            
            CalculatingMark();
            SaveResults();
            ShowMark();
        }

        private void CalculatingMark()
        {
            // Подсчет максимально возможных баллов в тесте
            foreach (var page in from page in _pages from cb in page.Correct select page)
            {
                _maxScore += 1;
            }
            
            // Подсчет набранных баллов пользователем в тесте
            for (var i = 0; i < _answers.Count; i++)
            {
                _tempScore = 0;
                for (var j = 1; j <= 4; j++)
                {
                    if (_answers[i].Contains(j) && _pages[i].Correct.Contains(j))
                    {
                        _tempScore += 1;
                    }
                    else
                    {
                        if (!_answers[i].Contains(j) || _pages[i].Correct.Contains(j)) continue;
                        _tempScore = 0;
                        break;
                    }
                }
                _score += _tempScore;
            }

            // Обнуляем временную переменную
            _tempScore = 0;
            
            // Подсчет кол-во полных верных ответов на вопросы пользователем в тесте
            for (var i = 0; i < _answers.Count; i++)
            {
                _tempScore += 1;
                for (var j = 1; j <= 4; j++)
                {
                    if (_answers[i].Contains(j) && _pages[i].Correct.Contains(j) || !_answers[i].Contains(j) && !_pages[i].Correct.Contains(j))
                    {
                    }
                    else
                    {
                        _tempScore -= 1;
                        break;
                    }
                }
            }
            
            // Определяем максимально возможное кол-во полных верных ответов на вопросы
            _maxScoreQuestions = _pages.Count;
            
            // Кол-во полных верных ответов на вопросы пользователем
            _scoreQuestions = _tempScore;
            
            // Переводим в проценты набранные баллы из максимальных
            _tempScore = Math.Round(Convert.ToDouble(_score) / Convert.ToDouble(_maxScore) * 100, 2);

            // Определяем оценку за тест
            if (_tempScore < 50)
            {
                _mark = 2;
            }
            else if (_tempScore < 75)
            {
                _mark = 3;
            }
            else if (_tempScore < 90)
            {
                _mark = 4;
            }
            else if (_tempScore >= 90)
            {
                _mark = 5;
            }
        }

        private void SaveResults()
        {
            // Запуск приложения Excel
            // Visible - отображать работу, DisplayAlerts - отображать всплывающие окна
            _excelApp = new Excel.ApplicationClass();
            _excelApp.Visible = false;
            _excelApp.SheetsInNewWorkbook = 1;
            _excelApp.Workbooks.Add(Type.Missing); // Создаем рабочую книгу
            _excelApp.DisplayAlerts = false;
            
            // Переходим в рабочую книгу
            _excelAppWorkbooks = _excelApp.Workbooks;
            _excelAppWorkbook = _excelAppWorkbooks[1];
            _excelAppWorkbook.Activate();
            
            // Переходим в рабочий лист
            _excelSheets = _excelAppWorkbook.Worksheets;
            _excelWorksheet = (Excel.Worksheet)_excelSheets.Item[1];
            
            // Устанавливаем стандартные данные в ячейки
            _excelCells = _excelWorksheet.Range["A1", Type.Missing];
            _excelCells.Value2 = "Вопрос:";
            _excelCells = _excelWorksheet.Range["B1", Type.Missing];
            _excelCells.Value2 = "Ответ:";

            // Заполняем лист данными вопросов и данными ответов
            var row = 2;
            var table = 1;
            _excelCells = (Excel.Range)_excelWorksheet.Cells[row, table];
            for (var i = 0; i < _pages.Count; i++)
            {
                _excelCells.Value2 = _pages[i].Question;

                table += 1;
                _excelCells = (Excel.Range)_excelWorksheet.Cells[row, table];
                foreach (var pageAnswer in _answers[i])
                {
                    switch (pageAnswer)
                    {
                        case 1:
                            _excelCells.Value2 += _pages[i].Answer1 + @"; ";
                            break;
                        case 2:
                            _excelCells.Value2 += _pages[i].Answer2 + @"; ";
                            break;
                        case 3:
                            _excelCells.Value2 += _pages[i].Answer3 + @"; ";
                            break;
                        case 4:
                            _excelCells.Value2 += _pages[i].Answer4 + @"; ";
                            break;
                    }
                }

                row += 1;
                table -= 1;
                _excelCells = (Excel.Range)_excelWorksheet.Cells[row, table];
            }
            
            // Устанавливаем данные о оценке пользователя
            _excelCells = _excelWorksheet.Range["D2", Type.Missing];
            _excelCells.Value2 = $"Оценка: {_mark}";

            // Сохраняем рабочую книгу в папку "Мои документы\Examiner"
            _excelAppWorkbooks = _excelApp.Workbooks;
            _excelAppWorkbook = _excelAppWorkbooks[1];
            _path += @"\Examiner";
            if (!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
            }
            _excelAppWorkbook.SaveAs(_path + @"\Results.xlsx");
            _excelApp.Quit();
        }

        private void ShowMark()
        {
            // Выводим сообщение о кол-ве набранных баллов пользователю
            MessageBox.Show($"Кол-во набранных баллов: {_score}/{_maxScore}\n" +
                            $"Процент: {Math.Round(Convert.ToDouble(_score) / Convert.ToDouble(_maxScore) * 100, 2)}%\n" +
                            $"Кол-во полных верных ответов на вопросы: {_scoreQuestions}/{_maxScoreQuestions}\n" +
                            $"Процент: {Math.Round(Convert.ToDouble(_scoreQuestions) / Convert.ToDouble(_maxScoreQuestions) * 100, 2)}%\n" +
                            $"Оценка: {_mark}");
        }
    }
}