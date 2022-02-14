namespace Examiner.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lMainMenu = new MaterialSkin.Controls.MaterialLabel();
            this.bOpen = new MaterialSkin.Controls.MaterialButton();
            this.bExit = new MaterialSkin.Controls.MaterialButton();
            this.picEmblem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEmblem)).BeginInit();
            this.SuspendLayout();
            // 
            // lMainMenu
            // 
            this.lMainMenu.Depth = 0;
            this.lMainMenu.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lMainMenu.Location = new System.Drawing.Point(35, 120);
            this.lMainMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lMainMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.lMainMenu.Name = "lMainMenu";
            this.lMainMenu.Size = new System.Drawing.Size(364, 32);
            this.lMainMenu.TabIndex = 3;
            this.lMainMenu.Text = "Экзаменатор | Прохождение тестов";
            // 
            // bOpen
            // 
            this.bOpen.AutoSize = false;
            this.bOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bOpen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bOpen.Depth = 0;
            this.bOpen.HighEmphasis = true;
            this.bOpen.Icon = null;
            this.bOpen.Location = new System.Drawing.Point(35, 157);
            this.bOpen.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bOpen.MouseState = MaterialSkin.MouseState.HOVER;
            this.bOpen.Name = "bOpen";
            this.bOpen.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bOpen.Size = new System.Drawing.Size(216, 36);
            this.bOpen.TabIndex = 1;
            this.bOpen.TabStop = false;
            this.bOpen.Text = "Открыть тест";
            this.bOpen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bOpen.UseAccentColor = false;
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // bExit
            // 
            this.bExit.AutoSize = false;
            this.bExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bExit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bExit.Depth = 0;
            this.bExit.HighEmphasis = true;
            this.bExit.Icon = null;
            this.bExit.Location = new System.Drawing.Point(35, 203);
            this.bExit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.bExit.Name = "bExit";
            this.bExit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bExit.Size = new System.Drawing.Size(216, 36);
            this.bExit.TabIndex = 2;
            this.bExit.TabStop = false;
            this.bExit.Text = "Выход";
            this.bExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bExit.UseAccentColor = false;
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // picEmblem
            // 
            this.picEmblem.Image = global::Examiner.Properties.Resources.school20;
            this.picEmblem.ImageLocation = "";
            this.picEmblem.Location = new System.Drawing.Point(358, 155);
            this.picEmblem.Name = "picEmblem";
            this.picEmblem.Size = new System.Drawing.Size(336, 436);
            this.picEmblem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEmblem.TabIndex = 5;
            this.picEmblem.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.picEmblem);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bOpen);
            this.Controls.Add(this.lMainMenu);
            this.DrawerBackgroundWithAccent = true;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(6, 78, 6, 6);
            this.Sizable = false;
            this.Text = "Examiner";
            ((System.ComponentModel.ISupportInitialize)(this.picEmblem)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox picEmblem;

        private MaterialSkin.Controls.MaterialLabel lMainMenu;
        private MaterialSkin.Controls.MaterialButton bOpen;
        private MaterialSkin.Controls.MaterialButton bExit;

        #endregion
    }
}