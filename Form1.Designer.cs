namespace TeXtatics
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_SaveResults = new System.Windows.Forms.Button();
            this.btn_ExitApplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_OpenFile.Location = new System.Drawing.Point(35, 12);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(157, 37);
            this.btn_OpenFile.TabIndex = 0;
            this.btn_OpenFile.Text = "Открыть файл";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_SaveResults
            // 
            this.btn_SaveResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_SaveResults.Location = new System.Drawing.Point(12, 64);
            this.btn_SaveResults.Name = "btn_SaveResults";
            this.btn_SaveResults.Size = new System.Drawing.Size(202, 37);
            this.btn_SaveResults.TabIndex = 1;
            this.btn_SaveResults.Text = "Сохранить результаты";
            this.btn_SaveResults.UseVisualStyleBackColor = true;
            this.btn_SaveResults.Visible = false;
            // 
            // btn_ExitApplication
            // 
            this.btn_ExitApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ExitApplication.Location = new System.Drawing.Point(35, 116);
            this.btn_ExitApplication.Name = "btn_ExitApplication";
            this.btn_ExitApplication.Size = new System.Drawing.Size(157, 37);
            this.btn_ExitApplication.TabIndex = 2;
            this.btn_ExitApplication.Text = "Выход";
            this.btn_ExitApplication.UseVisualStyleBackColor = true;
            this.btn_ExitApplication.Click += new System.EventHandler(this.btn_ExitApplication_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 172);
            this.ControlBox = false;
            this.Controls.Add(this.btn_ExitApplication);
            this.Controls.Add(this.btn_SaveResults);
            this.Controls.Add(this.btn_OpenFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TexTatics";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_SaveResults;
        private System.Windows.Forms.Button btn_ExitApplication;
    }
}

