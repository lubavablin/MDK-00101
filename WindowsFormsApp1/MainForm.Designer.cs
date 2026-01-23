namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.BoxStudents = new System.Windows.Forms.ListBox();
            this.age = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.avg = new System.Windows.Forms.Label();
            this.numberBilet = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxStudents
            // 
            this.BoxStudents.FormattingEnabled = true;
            this.BoxStudents.Location = new System.Drawing.Point(419, 135);
            this.BoxStudents.Name = "BoxStudents";
            this.BoxStudents.Size = new System.Drawing.Size(369, 303);
            this.BoxStudents.TabIndex = 4;
            this.BoxStudents.SelectedIndexChanged += new System.EventHandler(this.BoxStudents_SelectedIndexChanged);
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(416, 48);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(35, 13);
            this.age.TabIndex = 5;
            this.age.Text = "label1";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(416, 18);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 6;
            this.name.Text = "label2";
            // 
            // avg
            // 
            this.avg.AutoSize = true;
            this.avg.Location = new System.Drawing.Point(416, 76);
            this.avg.Name = "avg";
            this.avg.Size = new System.Drawing.Size(35, 13);
            this.avg.TabIndex = 7;
            this.avg.Text = "label3";
            // 
            // numberBilet
            // 
            this.numberBilet.AutoSize = true;
            this.numberBilet.Location = new System.Drawing.Point(416, 106);
            this.numberBilet.Name = "numberBilet";
            this.numberBilet.Size = new System.Drawing.Size(35, 13);
            this.numberBilet.TabIndex = 8;
            this.numberBilet.Text = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(534, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 101);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numberBilet);
            this.Controls.Add(this.avg);
            this.Controls.Add(this.name);
            this.Controls.Add(this.age);
            this.Controls.Add(this.BoxStudents);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox BoxStudents;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label avg;
        private System.Windows.Forms.Label numberBilet;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

