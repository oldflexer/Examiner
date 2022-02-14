using System.ComponentModel;

namespace Examiner.Forms
{
    partial class Tester
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tester));
            this.gTools = new System.Windows.Forms.GroupBox();
            this.bSaveAnswer = new MaterialSkin.Controls.MaterialButton();
            this.pbQuestions = new MaterialSkin.Controls.MaterialProgressBar();
            this.lQuestionNum = new MaterialSkin.Controls.MaterialLabel();
            this.bPrev = new MaterialSkin.Controls.MaterialButton();
            this.bNext = new MaterialSkin.Controls.MaterialButton();
            this.bEndTest = new MaterialSkin.Controls.MaterialButton();
            this.bBack = new MaterialSkin.Controls.MaterialButton();
            this.gData = new System.Windows.Forms.GroupBox();
            this.lAnswers = new MaterialSkin.Controls.MaterialLabel();
            this.lAnswer4 = new MaterialSkin.Controls.MaterialLabel();
            this.lAnswer2 = new MaterialSkin.Controls.MaterialLabel();
            this.lAnswer3 = new MaterialSkin.Controls.MaterialLabel();
            this.lAnswer1 = new MaterialSkin.Controls.MaterialLabel();
            this.cbFour = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbThree = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbTwo = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbOne = new MaterialSkin.Controls.MaterialCheckbox();
            this.lQuestion = new MaterialSkin.Controls.MaterialLabel();
            this.gTools.SuspendLayout();
            this.gData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gTools
            // 
            this.gTools.Controls.Add(this.bSaveAnswer);
            this.gTools.Controls.Add(this.pbQuestions);
            this.gTools.Controls.Add(this.lQuestionNum);
            this.gTools.Controls.Add(this.bPrev);
            this.gTools.Controls.Add(this.bNext);
            this.gTools.Controls.Add(this.bEndTest);
            this.gTools.Controls.Add(this.bBack);
            this.gTools.Location = new System.Drawing.Point(9, 505);
            this.gTools.Name = "gTools";
            this.gTools.Size = new System.Drawing.Size(942, 71);
            this.gTools.TabIndex = 0;
            this.gTools.TabStop = false;
            // 
            // bSaveAnswer
            // 
            this.bSaveAnswer.AutoSize = false;
            this.bSaveAnswer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bSaveAnswer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bSaveAnswer.Depth = 0;
            this.bSaveAnswer.HighEmphasis = true;
            this.bSaveAnswer.Icon = null;
            this.bSaveAnswer.Location = new System.Drawing.Point(724, 15);
            this.bSaveAnswer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bSaveAnswer.MouseState = MaterialSkin.MouseState.HOVER;
            this.bSaveAnswer.Name = "bSaveAnswer";
            this.bSaveAnswer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bSaveAnswer.Size = new System.Drawing.Size(142, 36);
            this.bSaveAnswer.TabIndex = 22;
            this.bSaveAnswer.TabStop = false;
            this.bSaveAnswer.Text = "Сохранить ответ";
            this.bSaveAnswer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bSaveAnswer.UseAccentColor = false;
            this.bSaveAnswer.UseVisualStyleBackColor = true;
            this.bSaveAnswer.Click += new System.EventHandler(this.bSaveAnswer_Click);
            // 
            // pbQuestions
            // 
            this.pbQuestions.Depth = 0;
            this.pbQuestions.Location = new System.Drawing.Point(278, 54);
            this.pbQuestions.MarqueeAnimationSpeed = 10;
            this.pbQuestions.Maximum = 1;
            this.pbQuestions.Minimum = 1;
            this.pbQuestions.MouseState = MaterialSkin.MouseState.HOVER;
            this.pbQuestions.Name = "pbQuestions";
            this.pbQuestions.Size = new System.Drawing.Size(370, 5);
            this.pbQuestions.Step = 1;
            this.pbQuestions.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbQuestions.TabIndex = 21;
            this.pbQuestions.Value = 1;
            // 
            // lQuestionNum
            // 
            this.lQuestionNum.Depth = 0;
            this.lQuestionNum.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lQuestionNum.Location = new System.Drawing.Point(278, 15);
            this.lQuestionNum.MouseState = MaterialSkin.MouseState.HOVER;
            this.lQuestionNum.Name = "lQuestionNum";
            this.lQuestionNum.Size = new System.Drawing.Size(370, 36);
            this.lQuestionNum.TabIndex = 20;
            this.lQuestionNum.Text = "Вопрос 1/1";
            this.lQuestionNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bPrev
            // 
            this.bPrev.AutoSize = false;
            this.bPrev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bPrev.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bPrev.Depth = 0;
            this.bPrev.HighEmphasis = true;
            this.bPrev.Icon = null;
            this.bPrev.Location = new System.Drawing.Point(654, 15);
            this.bPrev.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bPrev.MouseState = MaterialSkin.MouseState.HOVER;
            this.bPrev.Name = "bPrev";
            this.bPrev.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bPrev.Size = new System.Drawing.Size(64, 36);
            this.bPrev.TabIndex = 19;
            this.bPrev.TabStop = false;
            this.bPrev.Text = "<<<";
            this.bPrev.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bPrev.UseAccentColor = false;
            this.bPrev.UseVisualStyleBackColor = true;
            this.bPrev.Click += new System.EventHandler(this.bPrev_Click);
            // 
            // bNext
            // 
            this.bNext.AutoSize = false;
            this.bNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bNext.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bNext.Depth = 0;
            this.bNext.HighEmphasis = true;
            this.bNext.Icon = null;
            this.bNext.Location = new System.Drawing.Point(872, 15);
            this.bNext.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.bNext.Name = "bNext";
            this.bNext.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bNext.Size = new System.Drawing.Size(64, 36);
            this.bNext.TabIndex = 18;
            this.bNext.TabStop = false;
            this.bNext.Text = ">>>";
            this.bNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bNext.UseAccentColor = false;
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // bEndTest
            // 
            this.bEndTest.AutoSize = false;
            this.bEndTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bEndTest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bEndTest.Depth = 0;
            this.bEndTest.HighEmphasis = true;
            this.bEndTest.Icon = null;
            this.bEndTest.Location = new System.Drawing.Point(142, 15);
            this.bEndTest.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bEndTest.MouseState = MaterialSkin.MouseState.HOVER;
            this.bEndTest.Name = "bEndTest";
            this.bEndTest.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bEndTest.Size = new System.Drawing.Size(130, 36);
            this.bEndTest.TabIndex = 2;
            this.bEndTest.TabStop = false;
            this.bEndTest.Text = "Завершить тест";
            this.bEndTest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bEndTest.UseAccentColor = false;
            this.bEndTest.UseVisualStyleBackColor = true;
            this.bEndTest.Click += new System.EventHandler(this.bEndTest_Click);
            // 
            // bBack
            // 
            this.bBack.AutoSize = false;
            this.bBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bBack.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bBack.Depth = 0;
            this.bBack.HighEmphasis = true;
            this.bBack.Icon = null;
            this.bBack.Location = new System.Drawing.Point(6, 15);
            this.bBack.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.bBack.Name = "bBack";
            this.bBack.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bBack.Size = new System.Drawing.Size(130, 36);
            this.bBack.TabIndex = 1;
            this.bBack.TabStop = false;
            this.bBack.Text = "В главное меню";
            this.bBack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bBack.UseAccentColor = false;
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // gData
            // 
            this.gData.Controls.Add(this.lAnswers);
            this.gData.Controls.Add(this.lAnswer4);
            this.gData.Controls.Add(this.lAnswer2);
            this.gData.Controls.Add(this.lAnswer3);
            this.gData.Controls.Add(this.lAnswer1);
            this.gData.Controls.Add(this.cbFour);
            this.gData.Controls.Add(this.cbThree);
            this.gData.Controls.Add(this.cbTwo);
            this.gData.Controls.Add(this.cbOne);
            this.gData.Controls.Add(this.lQuestion);
            this.gData.Location = new System.Drawing.Point(9, 70);
            this.gData.Name = "gData";
            this.gData.Size = new System.Drawing.Size(942, 429);
            this.gData.TabIndex = 1;
            this.gData.TabStop = false;
            // 
            // lAnswers
            // 
            this.lAnswers.Depth = 0;
            this.lAnswers.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lAnswers.Location = new System.Drawing.Point(35, 148);
            this.lAnswers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lAnswers.MouseState = MaterialSkin.MouseState.HOVER;
            this.lAnswers.Name = "lAnswers";
            this.lAnswers.Size = new System.Drawing.Size(901, 64);
            this.lAnswers.TabIndex = 14;
            this.lAnswers.Text = "Выберите несколько верных вариантов ответа";
            // 
            // lAnswer4
            // 
            this.lAnswer4.Depth = 0;
            this.lAnswer4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lAnswer4.Location = new System.Drawing.Point(531, 322);
            this.lAnswer4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lAnswer4.MouseState = MaterialSkin.MouseState.HOVER;
            this.lAnswer4.Name = "lAnswer4";
            this.lAnswer4.Size = new System.Drawing.Size(405, 100);
            this.lAnswer4.TabIndex = 13;
            this.lAnswer4.Text = "Ответ4";
            // 
            // lAnswer2
            // 
            this.lAnswer2.Depth = 0;
            this.lAnswer2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lAnswer2.Location = new System.Drawing.Point(531, 222);
            this.lAnswer2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lAnswer2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lAnswer2.Name = "lAnswer2";
            this.lAnswer2.Size = new System.Drawing.Size(405, 100);
            this.lAnswer2.TabIndex = 12;
            this.lAnswer2.Text = "Ответ2";
            // 
            // lAnswer3
            // 
            this.lAnswer3.Depth = 0;
            this.lAnswer3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lAnswer3.Location = new System.Drawing.Point(73, 322);
            this.lAnswer3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lAnswer3.MouseState = MaterialSkin.MouseState.HOVER;
            this.lAnswer3.Name = "lAnswer3";
            this.lAnswer3.Size = new System.Drawing.Size(405, 100);
            this.lAnswer3.TabIndex = 11;
            this.lAnswer3.Text = "Ответ3";
            // 
            // lAnswer1
            // 
            this.lAnswer1.Depth = 0;
            this.lAnswer1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lAnswer1.Location = new System.Drawing.Point(73, 222);
            this.lAnswer1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lAnswer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lAnswer1.Name = "lAnswer1";
            this.lAnswer1.Size = new System.Drawing.Size(405, 100);
            this.lAnswer1.TabIndex = 10;
            this.lAnswer1.Text = "Ответ1";
            // 
            // cbFour
            // 
            this.cbFour.Depth = 0;
            this.cbFour.Location = new System.Drawing.Point(493, 312);
            this.cbFour.Margin = new System.Windows.Forms.Padding(0);
            this.cbFour.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbFour.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbFour.Name = "cbFour";
            this.cbFour.ReadOnly = false;
            this.cbFour.Ripple = true;
            this.cbFour.Size = new System.Drawing.Size(36, 39);
            this.cbFour.TabIndex = 9;
            this.cbFour.TabStop = false;
            this.cbFour.Tag = "4";
            this.cbFour.UseVisualStyleBackColor = true;
            // 
            // cbThree
            // 
            this.cbThree.Depth = 0;
            this.cbThree.Location = new System.Drawing.Point(35, 312);
            this.cbThree.Margin = new System.Windows.Forms.Padding(0);
            this.cbThree.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbThree.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbThree.Name = "cbThree";
            this.cbThree.ReadOnly = false;
            this.cbThree.Ripple = true;
            this.cbThree.Size = new System.Drawing.Size(36, 39);
            this.cbThree.TabIndex = 8;
            this.cbThree.TabStop = false;
            this.cbThree.Tag = "3";
            this.cbThree.UseVisualStyleBackColor = true;
            // 
            // cbTwo
            // 
            this.cbTwo.Depth = 0;
            this.cbTwo.Location = new System.Drawing.Point(493, 212);
            this.cbTwo.Margin = new System.Windows.Forms.Padding(0);
            this.cbTwo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbTwo.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbTwo.Name = "cbTwo";
            this.cbTwo.ReadOnly = false;
            this.cbTwo.Ripple = true;
            this.cbTwo.Size = new System.Drawing.Size(36, 39);
            this.cbTwo.TabIndex = 7;
            this.cbTwo.TabStop = false;
            this.cbTwo.Tag = "2";
            this.cbTwo.UseVisualStyleBackColor = true;
            // 
            // cbOne
            // 
            this.cbOne.Depth = 0;
            this.cbOne.Location = new System.Drawing.Point(35, 212);
            this.cbOne.Margin = new System.Windows.Forms.Padding(0);
            this.cbOne.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbOne.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbOne.Name = "cbOne";
            this.cbOne.ReadOnly = false;
            this.cbOne.Ripple = true;
            this.cbOne.Size = new System.Drawing.Size(36, 39);
            this.cbOne.TabIndex = 6;
            this.cbOne.TabStop = false;
            this.cbOne.Tag = "1";
            this.cbOne.UseVisualStyleBackColor = true;
            // 
            // lQuestion
            // 
            this.lQuestion.Depth = 0;
            this.lQuestion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lQuestion.Location = new System.Drawing.Point(35, 20);
            this.lQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lQuestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(901, 128);
            this.lQuestion.TabIndex = 5;
            this.lQuestion.Text = "*Вопрос*";
            // 
            // Tester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.gData);
            this.Controls.Add(this.gTools);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(960, 585);
            this.MinimumSize = new System.Drawing.Size(960, 585);
            this.Name = "Tester";
            this.Padding = new System.Windows.Forms.Padding(6, 52, 6, 6);
            this.Sizable = false;
            this.Text = "Экзаменатор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tester_FormClosed);
            this.gTools.ResumeLayout(false);
            this.gData.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private MaterialSkin.Controls.MaterialButton bSaveAnswer;

        private MaterialSkin.Controls.MaterialProgressBar pbQuestions;

        private MaterialSkin.Controls.MaterialButton bBack;
        private MaterialSkin.Controls.MaterialButton bEndTest;
        private MaterialSkin.Controls.MaterialButton bPrev;
        private MaterialSkin.Controls.MaterialButton bNext;
        private MaterialSkin.Controls.MaterialLabel lQuestionNum;

        private MaterialSkin.Controls.MaterialLabel lQuestion;
        private MaterialSkin.Controls.MaterialLabel lAnswers;
        private MaterialSkin.Controls.MaterialCheckbox cbOne;
        private MaterialSkin.Controls.MaterialCheckbox cbTwo;
        private MaterialSkin.Controls.MaterialCheckbox cbThree;
        private MaterialSkin.Controls.MaterialCheckbox cbFour;
        private MaterialSkin.Controls.MaterialLabel lAnswer1;
        private MaterialSkin.Controls.MaterialLabel lAnswer2;
        private MaterialSkin.Controls.MaterialLabel lAnswer3;
        private MaterialSkin.Controls.MaterialLabel lAnswer4;
        
        private System.Windows.Forms.GroupBox gTools;
        private System.Windows.Forms.GroupBox gData;

        #endregion
    }
}