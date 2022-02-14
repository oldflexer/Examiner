using System.ComponentModel;

namespace ExamCreator.Forms
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.bBack = new MaterialSkin.Controls.MaterialButton();
            this.gTools = new System.Windows.Forms.GroupBox();
            this.bClear = new MaterialSkin.Controls.MaterialButton();
            this.bSaveQuestion = new MaterialSkin.Controls.MaterialButton();
            this.bSaveTest = new MaterialSkin.Controls.MaterialButton();
            this.bNewQuestion = new MaterialSkin.Controls.MaterialButton();
            this.bDelQuestion = new MaterialSkin.Controls.MaterialButton();
            this.gData = new System.Windows.Forms.GroupBox();
            this.lQuestionNum = new MaterialSkin.Controls.MaterialLabel();
            this.bNext = new MaterialSkin.Controls.MaterialButton();
            this.pbQuestions = new MaterialSkin.Controls.MaterialProgressBar();
            this.bPrev = new MaterialSkin.Controls.MaterialButton();
            this.cbFour = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbThree = new MaterialSkin.Controls.MaterialCheckbox();
            this.tAnswer4 = new MaterialSkin.Controls.MaterialTextBox2();
            this.tAnswer3 = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbTwo = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbOne = new MaterialSkin.Controls.MaterialCheckbox();
            this.tAnswer2 = new MaterialSkin.Controls.MaterialTextBox2();
            this.tAnswer1 = new MaterialSkin.Controls.MaterialTextBox2();
            this.lAnswers = new MaterialSkin.Controls.MaterialLabel();
            this.lQuestion = new MaterialSkin.Controls.MaterialLabel();
            this.tQuestion = new MaterialSkin.Controls.MaterialTextBox2();
            this.gTools.SuspendLayout();
            this.gData.SuspendLayout();
            this.SuspendLayout();
            // 
            // bBack
            // 
            this.bBack.AutoSize = false;
            this.bBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bBack.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bBack.Depth = 0;
            this.bBack.HighEmphasis = true;
            this.bBack.Icon = null;
            this.bBack.Location = new System.Drawing.Point(5, 464);
            this.bBack.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.bBack.Name = "bBack";
            this.bBack.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bBack.Size = new System.Drawing.Size(216, 36);
            this.bBack.TabIndex = 0;
            this.bBack.TabStop = false;
            this.bBack.Text = "В главное меню";
            this.bBack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bBack.UseAccentColor = false;
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // gTools
            // 
            this.gTools.Controls.Add(this.bClear);
            this.gTools.Controls.Add(this.bSaveQuestion);
            this.gTools.Controls.Add(this.bSaveTest);
            this.gTools.Controls.Add(this.bNewQuestion);
            this.gTools.Controls.Add(this.bDelQuestion);
            this.gTools.Controls.Add(this.bBack);
            this.gTools.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gTools.Location = new System.Drawing.Point(8, 70);
            this.gTools.Margin = new System.Windows.Forms.Padding(2);
            this.gTools.Name = "gTools";
            this.gTools.Padding = new System.Windows.Forms.Padding(2);
            this.gTools.Size = new System.Drawing.Size(226, 507);
            this.gTools.TabIndex = 1;
            this.gTools.TabStop = false;
            // 
            // bClear
            // 
            this.bClear.AutoSize = false;
            this.bClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bClear.Depth = 0;
            this.bClear.HighEmphasis = true;
            this.bClear.Icon = null;
            this.bClear.Location = new System.Drawing.Point(5, 112);
            this.bClear.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.bClear.Name = "bClear";
            this.bClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bClear.Size = new System.Drawing.Size(216, 36);
            this.bClear.TabIndex = 18;
            this.bClear.TabStop = false;
            this.bClear.Text = "Отчистить поля";
            this.bClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bClear.UseAccentColor = false;
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bSaveQuestion
            // 
            this.bSaveQuestion.AutoSize = false;
            this.bSaveQuestion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bSaveQuestion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bSaveQuestion.Depth = 0;
            this.bSaveQuestion.HighEmphasis = true;
            this.bSaveQuestion.Icon = null;
            this.bSaveQuestion.Location = new System.Drawing.Point(5, 66);
            this.bSaveQuestion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bSaveQuestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.bSaveQuestion.Name = "bSaveQuestion";
            this.bSaveQuestion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bSaveQuestion.Size = new System.Drawing.Size(216, 36);
            this.bSaveQuestion.TabIndex = 17;
            this.bSaveQuestion.TabStop = false;
            this.bSaveQuestion.Text = "Сохранить вопрос";
            this.bSaveQuestion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bSaveQuestion.UseAccentColor = false;
            this.bSaveQuestion.UseVisualStyleBackColor = true;
            this.bSaveQuestion.Click += new System.EventHandler(this.bSaveQuestion_Click);
            // 
            // bSaveTest
            // 
            this.bSaveTest.AutoSize = false;
            this.bSaveTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bSaveTest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bSaveTest.Depth = 0;
            this.bSaveTest.HighEmphasis = true;
            this.bSaveTest.Icon = null;
            this.bSaveTest.Location = new System.Drawing.Point(5, 204);
            this.bSaveTest.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bSaveTest.MouseState = MaterialSkin.MouseState.HOVER;
            this.bSaveTest.Name = "bSaveTest";
            this.bSaveTest.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bSaveTest.Size = new System.Drawing.Size(216, 36);
            this.bSaveTest.TabIndex = 2;
            this.bSaveTest.TabStop = false;
            this.bSaveTest.Text = "Сохранить тест как";
            this.bSaveTest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bSaveTest.UseAccentColor = false;
            this.bSaveTest.UseVisualStyleBackColor = true;
            this.bSaveTest.Click += new System.EventHandler(this.bSaveTest_Click);
            // 
            // bNewQuestion
            // 
            this.bNewQuestion.AutoSize = false;
            this.bNewQuestion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bNewQuestion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bNewQuestion.Depth = 0;
            this.bNewQuestion.HighEmphasis = true;
            this.bNewQuestion.Icon = null;
            this.bNewQuestion.Location = new System.Drawing.Point(5, 20);
            this.bNewQuestion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bNewQuestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.bNewQuestion.Name = "bNewQuestion";
            this.bNewQuestion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bNewQuestion.Size = new System.Drawing.Size(216, 36);
            this.bNewQuestion.TabIndex = 14;
            this.bNewQuestion.TabStop = false;
            this.bNewQuestion.Text = "Новый вопрос";
            this.bNewQuestion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bNewQuestion.UseAccentColor = false;
            this.bNewQuestion.UseVisualStyleBackColor = true;
            this.bNewQuestion.Click += new System.EventHandler(this.bNewQuestion_Click);
            // 
            // bDelQuestion
            // 
            this.bDelQuestion.AutoSize = false;
            this.bDelQuestion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bDelQuestion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bDelQuestion.Depth = 0;
            this.bDelQuestion.HighEmphasis = true;
            this.bDelQuestion.Icon = null;
            this.bDelQuestion.Location = new System.Drawing.Point(5, 158);
            this.bDelQuestion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bDelQuestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.bDelQuestion.Name = "bDelQuestion";
            this.bDelQuestion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bDelQuestion.Size = new System.Drawing.Size(216, 36);
            this.bDelQuestion.TabIndex = 2;
            this.bDelQuestion.TabStop = false;
            this.bDelQuestion.Text = "Удалить вопрос";
            this.bDelQuestion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bDelQuestion.UseAccentColor = false;
            this.bDelQuestion.UseVisualStyleBackColor = true;
            this.bDelQuestion.Click += new System.EventHandler(this.bDelQuestion_Click);
            // 
            // gData
            // 
            this.gData.Controls.Add(this.lQuestionNum);
            this.gData.Controls.Add(this.bNext);
            this.gData.Controls.Add(this.pbQuestions);
            this.gData.Controls.Add(this.bPrev);
            this.gData.Controls.Add(this.cbFour);
            this.gData.Controls.Add(this.cbThree);
            this.gData.Controls.Add(this.tAnswer4);
            this.gData.Controls.Add(this.tAnswer3);
            this.gData.Controls.Add(this.cbTwo);
            this.gData.Controls.Add(this.cbOne);
            this.gData.Controls.Add(this.tAnswer2);
            this.gData.Controls.Add(this.tAnswer1);
            this.gData.Controls.Add(this.lAnswers);
            this.gData.Controls.Add(this.lQuestion);
            this.gData.Controls.Add(this.tQuestion);
            this.gData.Location = new System.Drawing.Point(239, 69);
            this.gData.Margin = new System.Windows.Forms.Padding(2);
            this.gData.Name = "gData";
            this.gData.Padding = new System.Windows.Forms.Padding(2);
            this.gData.Size = new System.Drawing.Size(712, 507);
            this.gData.TabIndex = 2;
            this.gData.TabStop = false;
            // 
            // lQuestionNum
            // 
            this.lQuestionNum.Depth = 0;
            this.lQuestionNum.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lQuestionNum.Location = new System.Drawing.Point(105, 453);
            this.lQuestionNum.MouseState = MaterialSkin.MouseState.HOVER;
            this.lQuestionNum.Name = "lQuestionNum";
            this.lQuestionNum.Size = new System.Drawing.Size(506, 36);
            this.lQuestionNum.TabIndex = 18;
            this.lQuestionNum.Text = "Вопрос 1/1";
            this.lQuestionNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bNext
            // 
            this.bNext.AutoSize = false;
            this.bNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bNext.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bNext.Depth = 0;
            this.bNext.HighEmphasis = true;
            this.bNext.Icon = null;
            this.bNext.Location = new System.Drawing.Point(617, 453);
            this.bNext.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.bNext.Name = "bNext";
            this.bNext.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bNext.Size = new System.Drawing.Size(64, 36);
            this.bNext.TabIndex = 17;
            this.bNext.TabStop = false;
            this.bNext.Text = ">>>";
            this.bNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bNext.UseAccentColor = false;
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // pbQuestions
            // 
            this.pbQuestions.Depth = 0;
            this.pbQuestions.Location = new System.Drawing.Point(4, 496);
            this.pbQuestions.Margin = new System.Windows.Forms.Padding(2);
            this.pbQuestions.MarqueeAnimationSpeed = 10;
            this.pbQuestions.Maximum = 1;
            this.pbQuestions.Minimum = 1;
            this.pbQuestions.MouseState = MaterialSkin.MouseState.HOVER;
            this.pbQuestions.Name = "pbQuestions";
            this.pbQuestions.Size = new System.Drawing.Size(704, 5);
            this.pbQuestions.Step = 1;
            this.pbQuestions.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbQuestions.TabIndex = 16;
            this.pbQuestions.Value = 1;
            // 
            // bPrev
            // 
            this.bPrev.AutoSize = false;
            this.bPrev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bPrev.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bPrev.Depth = 0;
            this.bPrev.HighEmphasis = true;
            this.bPrev.Icon = null;
            this.bPrev.Location = new System.Drawing.Point(35, 453);
            this.bPrev.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bPrev.MouseState = MaterialSkin.MouseState.HOVER;
            this.bPrev.Name = "bPrev";
            this.bPrev.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bPrev.Size = new System.Drawing.Size(64, 36);
            this.bPrev.TabIndex = 15;
            this.bPrev.TabStop = false;
            this.bPrev.Text = "<<<";
            this.bPrev.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bPrev.UseAccentColor = false;
            this.bPrev.UseVisualStyleBackColor = true;
            this.bPrev.Click += new System.EventHandler(this.bPrev_Click);
            // 
            // cbFour
            // 
            this.cbFour.Depth = 0;
            this.cbFour.Location = new System.Drawing.Point(373, 246);
            this.cbFour.Margin = new System.Windows.Forms.Padding(0);
            this.cbFour.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbFour.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbFour.Name = "cbFour";
            this.cbFour.ReadOnly = false;
            this.cbFour.Ripple = true;
            this.cbFour.Size = new System.Drawing.Size(36, 39);
            this.cbFour.TabIndex = 13;
            this.cbFour.TabStop = false;
            this.cbFour.Tag = "4";
            this.cbFour.UseVisualStyleBackColor = true;
            // 
            // cbThree
            // 
            this.cbThree.Depth = 0;
            this.cbThree.Location = new System.Drawing.Point(35, 246);
            this.cbThree.Margin = new System.Windows.Forms.Padding(0);
            this.cbThree.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbThree.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbThree.Name = "cbThree";
            this.cbThree.ReadOnly = false;
            this.cbThree.Ripple = true;
            this.cbThree.Size = new System.Drawing.Size(36, 39);
            this.cbThree.TabIndex = 12;
            this.cbThree.TabStop = false;
            this.cbThree.Tag = "3";
            this.cbThree.UseVisualStyleBackColor = true;
            // 
            // tAnswer4
            // 
            this.tAnswer4.AnimateReadOnly = false;
            this.tAnswer4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tAnswer4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tAnswer4.Depth = 0;
            this.tAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tAnswer4.HideSelection = true;
            this.tAnswer4.LeadingIcon = null;
            this.tAnswer4.Location = new System.Drawing.Point(411, 246);
            this.tAnswer4.Margin = new System.Windows.Forms.Padding(2);
            this.tAnswer4.MaxLength = 32767;
            this.tAnswer4.MouseState = MaterialSkin.MouseState.OUT;
            this.tAnswer4.Name = "tAnswer4";
            this.tAnswer4.PasswordChar = '\0';
            this.tAnswer4.PrefixSuffixText = null;
            this.tAnswer4.ReadOnly = false;
            this.tAnswer4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tAnswer4.SelectedText = "";
            this.tAnswer4.SelectionLength = 0;
            this.tAnswer4.SelectionStart = 0;
            this.tAnswer4.ShortcutsEnabled = true;
            this.tAnswer4.Size = new System.Drawing.Size(270, 48);
            this.tAnswer4.TabIndex = 11;
            this.tAnswer4.TabStop = false;
            this.tAnswer4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tAnswer4.TrailingIcon = null;
            this.tAnswer4.UseSystemPasswordChar = false;
            // 
            // tAnswer3
            // 
            this.tAnswer3.AnimateReadOnly = false;
            this.tAnswer3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tAnswer3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tAnswer3.Depth = 0;
            this.tAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tAnswer3.HideSelection = true;
            this.tAnswer3.LeadingIcon = null;
            this.tAnswer3.Location = new System.Drawing.Point(74, 246);
            this.tAnswer3.Margin = new System.Windows.Forms.Padding(2);
            this.tAnswer3.MaxLength = 32767;
            this.tAnswer3.MouseState = MaterialSkin.MouseState.OUT;
            this.tAnswer3.Name = "tAnswer3";
            this.tAnswer3.PasswordChar = '\0';
            this.tAnswer3.PrefixSuffixText = null;
            this.tAnswer3.ReadOnly = false;
            this.tAnswer3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tAnswer3.SelectedText = "";
            this.tAnswer3.SelectionLength = 0;
            this.tAnswer3.SelectionStart = 0;
            this.tAnswer3.ShortcutsEnabled = true;
            this.tAnswer3.Size = new System.Drawing.Size(270, 48);
            this.tAnswer3.TabIndex = 10;
            this.tAnswer3.TabStop = false;
            this.tAnswer3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tAnswer3.TrailingIcon = null;
            this.tAnswer3.UseSystemPasswordChar = false;
            // 
            // cbTwo
            // 
            this.cbTwo.Depth = 0;
            this.cbTwo.Location = new System.Drawing.Point(373, 192);
            this.cbTwo.Margin = new System.Windows.Forms.Padding(0);
            this.cbTwo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbTwo.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbTwo.Name = "cbTwo";
            this.cbTwo.ReadOnly = false;
            this.cbTwo.Ripple = true;
            this.cbTwo.Size = new System.Drawing.Size(36, 39);
            this.cbTwo.TabIndex = 9;
            this.cbTwo.TabStop = false;
            this.cbTwo.Tag = "2";
            this.cbTwo.UseVisualStyleBackColor = true;
            // 
            // cbOne
            // 
            this.cbOne.Depth = 0;
            this.cbOne.Location = new System.Drawing.Point(35, 192);
            this.cbOne.Margin = new System.Windows.Forms.Padding(0);
            this.cbOne.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbOne.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbOne.Name = "cbOne";
            this.cbOne.ReadOnly = false;
            this.cbOne.Ripple = true;
            this.cbOne.Size = new System.Drawing.Size(36, 39);
            this.cbOne.TabIndex = 8;
            this.cbOne.TabStop = false;
            this.cbOne.Tag = "1";
            this.cbOne.UseVisualStyleBackColor = true;
            // 
            // tAnswer2
            // 
            this.tAnswer2.AnimateReadOnly = false;
            this.tAnswer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tAnswer2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tAnswer2.Depth = 0;
            this.tAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tAnswer2.HideSelection = true;
            this.tAnswer2.LeadingIcon = null;
            this.tAnswer2.Location = new System.Drawing.Point(411, 192);
            this.tAnswer2.Margin = new System.Windows.Forms.Padding(2);
            this.tAnswer2.MaxLength = 32767;
            this.tAnswer2.MouseState = MaterialSkin.MouseState.OUT;
            this.tAnswer2.Name = "tAnswer2";
            this.tAnswer2.PasswordChar = '\0';
            this.tAnswer2.PrefixSuffixText = null;
            this.tAnswer2.ReadOnly = false;
            this.tAnswer2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tAnswer2.SelectedText = "";
            this.tAnswer2.SelectionLength = 0;
            this.tAnswer2.SelectionStart = 0;
            this.tAnswer2.ShortcutsEnabled = true;
            this.tAnswer2.Size = new System.Drawing.Size(270, 48);
            this.tAnswer2.TabIndex = 7;
            this.tAnswer2.TabStop = false;
            this.tAnswer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tAnswer2.TrailingIcon = null;
            this.tAnswer2.UseSystemPasswordChar = false;
            // 
            // tAnswer1
            // 
            this.tAnswer1.AnimateReadOnly = false;
            this.tAnswer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tAnswer1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tAnswer1.Depth = 0;
            this.tAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tAnswer1.HideSelection = true;
            this.tAnswer1.LeadingIcon = null;
            this.tAnswer1.Location = new System.Drawing.Point(74, 192);
            this.tAnswer1.Margin = new System.Windows.Forms.Padding(2);
            this.tAnswer1.MaxLength = 32767;
            this.tAnswer1.MouseState = MaterialSkin.MouseState.OUT;
            this.tAnswer1.Name = "tAnswer1";
            this.tAnswer1.PasswordChar = '\0';
            this.tAnswer1.PrefixSuffixText = null;
            this.tAnswer1.ReadOnly = false;
            this.tAnswer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tAnswer1.SelectedText = "";
            this.tAnswer1.SelectionLength = 0;
            this.tAnswer1.SelectionStart = 0;
            this.tAnswer1.ShortcutsEnabled = true;
            this.tAnswer1.Size = new System.Drawing.Size(270, 48);
            this.tAnswer1.TabIndex = 6;
            this.tAnswer1.TabStop = false;
            this.tAnswer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tAnswer1.TrailingIcon = null;
            this.tAnswer1.UseSystemPasswordChar = false;
            // 
            // lAnswers
            // 
            this.lAnswers.Depth = 0;
            this.lAnswers.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lAnswers.Location = new System.Drawing.Point(35, 136);
            this.lAnswers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lAnswers.MouseState = MaterialSkin.MouseState.HOVER;
            this.lAnswers.Name = "lAnswers";
            this.lAnswers.Size = new System.Drawing.Size(634, 54);
            this.lAnswers.TabIndex = 5;
            this.lAnswers.Text = "Введите варианты ответов и отметьте верный(ые):";
            // 
            // lQuestion
            // 
            this.lQuestion.Depth = 0;
            this.lQuestion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lQuestion.Location = new System.Drawing.Point(35, 20);
            this.lQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lQuestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(646, 32);
            this.lQuestion.TabIndex = 4;
            this.lQuestion.Text = "Введите вопрос:";
            // 
            // tQuestion
            // 
            this.tQuestion.AnimateReadOnly = false;
            this.tQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tQuestion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tQuestion.Depth = 0;
            this.tQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tQuestion.HideSelection = true;
            this.tQuestion.LeadingIcon = null;
            this.tQuestion.Location = new System.Drawing.Point(35, 54);
            this.tQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.tQuestion.MaxLength = 32767;
            this.tQuestion.MouseState = MaterialSkin.MouseState.OUT;
            this.tQuestion.Name = "tQuestion";
            this.tQuestion.PasswordChar = '\0';
            this.tQuestion.PrefixSuffixText = null;
            this.tQuestion.ReadOnly = false;
            this.tQuestion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tQuestion.SelectedText = "";
            this.tQuestion.SelectionLength = 0;
            this.tQuestion.SelectionStart = 0;
            this.tQuestion.ShortcutsEnabled = true;
            this.tQuestion.Size = new System.Drawing.Size(646, 48);
            this.tQuestion.TabIndex = 0;
            this.tQuestion.TabStop = false;
            this.tQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tQuestion.TrailingIcon = null;
            this.tQuestion.UseSystemPasswordChar = false;
            // 
            // Editor
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
            this.Name = "Editor";
            this.Padding = new System.Windows.Forms.Padding(6, 52, 6, 6);
            this.Sizable = false;
            this.Text = "Редактор тестов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Editor_FormClosed);
            this.gTools.ResumeLayout(false);
            this.gData.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private MaterialSkin.Controls.MaterialButton bNewQuestion;
        private MaterialSkin.Controls.MaterialButton bSaveQuestion;
        private MaterialSkin.Controls.MaterialButton bClear;
        private MaterialSkin.Controls.MaterialButton bDelQuestion;
        private MaterialSkin.Controls.MaterialButton bSaveTest;
        private MaterialSkin.Controls.MaterialButton bBack;
        
        private MaterialSkin.Controls.MaterialLabel lQuestion;
        private MaterialSkin.Controls.MaterialTextBox2 tQuestion;
        
        private MaterialSkin.Controls.MaterialLabel lAnswers;
        private MaterialSkin.Controls.MaterialCheckbox cbOne;
        private MaterialSkin.Controls.MaterialCheckbox cbTwo;
        private MaterialSkin.Controls.MaterialCheckbox cbThree;
        private MaterialSkin.Controls.MaterialCheckbox cbFour;
        private MaterialSkin.Controls.MaterialTextBox2 tAnswer1;
        private MaterialSkin.Controls.MaterialTextBox2 tAnswer2;
        private MaterialSkin.Controls.MaterialTextBox2 tAnswer3;
        private MaterialSkin.Controls.MaterialTextBox2 tAnswer4;
        
        private MaterialSkin.Controls.MaterialLabel lQuestionNum;
        private MaterialSkin.Controls.MaterialButton bPrev;
        private MaterialSkin.Controls.MaterialButton bNext;
        private MaterialSkin.Controls.MaterialProgressBar pbQuestions;
        
        private System.Windows.Forms.GroupBox gTools;
        private System.Windows.Forms.GroupBox gData;

        #endregion
    }
}