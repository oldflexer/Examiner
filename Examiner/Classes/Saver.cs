using System;
using System.Collections.Generic;
using System.IO;
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
        private readonly double _score = 0;
        /// <summary>
        /// Максимально возможные баллы
        /// </summary>
        private readonly double _maxScore = 0;
        /// <summary>
        /// Временная переменная верных ответов
        /// </summary>
        private readonly double _tempScore = 0;
        /// <summary>
        /// Кол-во полных верных ответов на вопросы
        /// </summary>
        private readonly double _scoreQuestions = 0;
        /// <summary>
        /// Максимально возможное кол-во полных верных ответов на вопросы
        /// </summary>
        private readonly double _maxScoreQuestions = 0;
        /// <summary>
        /// Оценка за тест
        /// </summary>
        private readonly int _mark = 0;
        /// <summary>
        /// Объект MS Office Excel
        /// </summary>
        private readonly Excel.Application _excelApp;
        /// <summary>
        /// Объект состоящий из рабочих книг Excel
        /// </summary>
        private readonly Excel.Workbooks _excelAppWorkbooks;
        /// <summary>
        /// Объект - рабочая книга
        /// </summary>
        private readonly Excel.Workbook _excelAppWorkbook;
        /// <summary>
        /// Объект состоящий из страниц книги
        /// </summary>
        private readonly Excel.Sheets _excelSheets;
        /// <summary>
        /// Объект - текущая рабочая страница
        /// </summary>
        private readonly Excel.Worksheet _excelWorksheet;
        /// <summary>
        /// Объект - диапазон ячеек страницы
        /// </summary>
        private readonly Excel.Range _excelCells;
        /// <summary>
        /// Путь к папке "Мои документы"
        /// </summary>
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);



        /// <summary>
        /// Стандартный конструктор
        /// </summary>
        /// <param name="pages"></param>
        /// <param name="answers"></param>
        public Saver(List<Page> pages, IReadOnlyList<List<int>> answers)
        {
            // Подсчет максимально возможных баллов в тесте
            foreach (var page in pages)
            {
                foreach (var cb in page.Correct)
                {
                    _maxScore += 1;
                }
            }
            
            // Подсчет набранных баллов пользователем в тесте
            for (var i = 0; i < answers.Count; i++)
            {
                _tempScore = 0;
                for (var j = 1; j <= 4; j++)
                {
                    if (answers[i].Contains(j) && pages[i].Correct.Contains(j))
                    {
                        _tempScore += 1;
                    }
                    else
                    {
                        if (!answers[i].Contains(j) || pages[i].Correct.Contains(j)) continue;
                        _tempScore = 0;
                        break;
                    }
                }
                _score += _tempScore;
            }

            // Обнуляем временную переменную
            _tempScore = 0;
            // Подсчет кол-во полных верных ответов на вопросы пользователем в тесте
            for (var i = 0; i < answers.Count; i++)
            {
                _tempScore += 1;
                for (var j = 1; j <= 4; j++)
                {
                    if (answers[i].Contains(j) && pages[i].Correct.Contains(j) || !answers[i].Contains(j) && !pages[i].Correct.Contains(j))
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
            _maxScoreQuestions = pages.Count;
            // Кол-во полных верных ответов на вопросы пользователем, переводим в проценты
            _scoreQuestions = _tempScore;
            _tempScore = Math.Round(Convert.ToDouble(_scoreQuestions) / Convert.ToDouble(_maxScoreQuestions) * 100, 2);

            // Определяем оценку за тест
            if (_tempScore < 45)
            {
                _mark = 2;
            }
            else if (_tempScore < 70)
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

            _excelApp = new Excel.ApplicationClass();
            _excelApp.Visible = false;
            _excelApp.SheetsInNewWorkbook = 1;
            _excelApp.Workbooks.Add(Type.Missing);
            _excelApp.DisplayAlerts = false;
            
            _excelAppWorkbooks = _excelApp.Workbooks;
            _excelAppWorkbook = _excelAppWorkbooks[1];
            _excelAppWorkbook.Activate();
            
            _excelSheets = _excelAppWorkbook.Worksheets;
            _excelWorksheet = (Excel.Worksheet)_excelSheets.Item[1];
            
            _excelCells = _excelWorksheet.Range["A1", Type.Missing];
            _excelCells.Value2 = "Вопрос:";
            _excelCells = _excelWorksheet.Range["B1", Type.Missing];
            _excelCells.Value2 = "Ответ:";

            var row = 2;
            var table = 1;
            _excelCells = (Excel.Range)_excelWorksheet.Cells[row, table];
            for (var i = 0; i < pages.Count; i++)
            {
                _excelCells.Value2 = pages[i].Question;

                table += 1;
                _excelCells = (Excel.Range)_excelWorksheet.Cells[row, table];
                foreach (var pageAnswer in answers[i])
                {
                    switch (pageAnswer)
                    {
                        case 1:
                            _excelCells.Value2 += pages[i].Answer1 + @"; ";
                            break;
                        case 2:
                            _excelCells.Value2 += pages[i].Answer2 + @"; ";
                            break;
                        case 3:
                            _excelCells.Value2 += pages[i].Answer3 + @"; ";
                            break;
                        case 4:
                            _excelCells.Value2 += pages[i].Answer4 + @"; ";
                            break;
                    }
                }

                row += 1;
                table -= 1;
                _excelCells = (Excel.Range)_excelWorksheet.Cells[row, table];
            }

            _excelAppWorkbooks = _excelApp.Workbooks;
            _excelAppWorkbook = _excelAppWorkbooks[1];
            path += @"\Examiner";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            _excelAppWorkbook.SaveAs(path + @"\Results.xlsx");
            _excelApp.Quit();
            

            // Выводим сообщение о кол-ве набранных баллов пользователю
            MessageBox.Show($"Кол-во набранных баллов: {_score}/{_maxScore}\n" +
                            $"Процент: {Math.Round(Convert.ToDouble(_score) / Convert.ToDouble(_maxScore) * 100, 2)}%\n" +
                            $"Кол-во полных верных ответов на вопросы: {_scoreQuestions}/{_maxScoreQuestions}\n" +
                            $"Процент: {Math.Round(Convert.ToDouble(_scoreQuestions) / Convert.ToDouble(_maxScoreQuestions) * 100, 2)}%\n" +
                            $"Оценка: {_mark}");
        }
    }
}