namespace delatform
{
    partial class MineForm
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
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PictureArea = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.Safe = new System.Windows.Forms.Button();
            this.FileNameListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureArea)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FileNameListBox);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 437);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.PictureArea);
            this.panel2.Location = new System.Drawing.Point(229, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 453);
            this.panel2.TabIndex = 1;
            // 
            // PictureArea
            // 
            this.PictureArea.Location = new System.Drawing.Point(11, 17);
            this.PictureArea.Name = "PictureArea";
            this.PictureArea.Size = new System.Drawing.Size(548, 291);
            this.PictureArea.TabIndex = 0;
            this.PictureArea.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.Controls.Add(this.Delete);
            this.panel3.Controls.Add(this.Edit);
            this.panel3.Controls.Add(this.Load);
            this.panel3.Controls.Add(this.Safe);
            this.panel3.Location = new System.Drawing.Point(0, 309);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(798, 138);
            this.panel3.TabIndex = 2;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(594, 44);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(103, 40);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(421, 45);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(96, 39);
            this.Edit.TabIndex = 2;
            this.Edit.Text = "Редактировать";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(244, 46);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(105, 38);
            this.Load.TabIndex = 1;
            this.Load.Text = "Загрузить";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Safe
            // 
            this.Safe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Safe.Location = new System.Drawing.Point(93, 47);
            this.Safe.Name = "Safe";
            this.Safe.Size = new System.Drawing.Size(104, 37);
            this.Safe.TabIndex = 0;
            this.Safe.Text = "Сохранить";
            this.Safe.UseVisualStyleBackColor = true;
            // 
            // FileNameListBox
            // 
            this.FileNameListBox.FormattingEnabled = true;
            this.FileNameListBox.Location = new System.Drawing.Point(11, 15);
            this.FileNameListBox.Name = "FileNameListBox";
            this.FileNameListBox.Size = new System.Drawing.Size(211, 277);
            this.FileNameListBox.TabIndex = 0;
            this.FileNameListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MineForm";
            this.Text = "MineForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureArea)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Safe;
        private System.Windows.Forms.PictureBox PictureArea;
        private System.Windows.Forms.ListBox FileNameListBox;
    }
}

