using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
        private readonly int _score = 0;
        /// <summary>
        /// Максимально возможные баллы
        /// </summary>
        private readonly int _maxScore = 0;
        /// <summary>
        /// Временная переменная верных ответов
        /// </summary>
        private readonly int _tempScore = 0;
        /// <summary>
        /// Кол-во полных верных ответов на вопросы
        /// </summary>
        private readonly int _scoreQuestions = 0;
        /// <summary>
        /// Максимально возможное кол-во полных верных ответов на вопросы
        /// </summary>
        private readonly int _maxScoreQuestions = 0;
        
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
            // Кол-во полных верных ответов на вопросы пользователем
            _scoreQuestions = _tempScore;
            // Определяем максимально возможное кол-во полных верных ответов на вопросы
            _maxScoreQuestions = pages.Count;

            // Выводим сообщение о кол-ве набранных баллов пользователю
            MessageBox.Show($"Кол-во набранных баллов: {_score}/{_maxScore}\n" +
                            $"Процент: {Math.Round(Convert.ToDouble(_score) / Convert.ToDouble(_maxScore) * 100, 2)}%\n" +
                            $"Кол-во полных верных ответов на вопросы: {_scoreQuestions}/{_maxScoreQuestions}\n" +
                            $"Процент: {Math.Round(Convert.ToDouble(_scoreQuestions) / Convert.ToDouble(_maxScoreQuestions) * 100, 2)}%");
        }
    }
}