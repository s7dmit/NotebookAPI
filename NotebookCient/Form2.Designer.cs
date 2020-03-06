namespace NotebookCient
{
    partial class Form2
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
            this.txtBoxSourName = new System.Windows.Forms.TextBox();
            this.dtmpBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxSourName
            // 
            this.txtBoxSourName.Location = new System.Drawing.Point(180, 95);
            this.txtBoxSourName.Name = "txtBoxSourName";
            this.txtBoxSourName.Size = new System.Drawing.Size(200, 26);
            this.txtBoxSourName.TabIndex = 0;
            // 
            // dtmpBirthday
            // 
            this.dtmpBirthday.Location = new System.Drawing.Point(180, 148);
            this.dtmpBirthday.Name = "dtmpBirthday";
            this.dtmpBirthday.Size = new System.Drawing.Size(200, 26);
            this.dtmpBirthday.TabIndex = 1;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(180, 42);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(200, 26);
            this.txtBoxName.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(13, 47);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(40, 20);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Имя";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(13, 95);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(81, 20);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Фамилия";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(13, 148);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(128, 20);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Дата рождения";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(328, 192);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(90, 34);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "OK";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 227);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.dtmpBirthday);
            this.Controls.Add(this.txtBoxSourName);
            this.Name = "Form2";
            this.Text = "Ввод данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        public System.Windows.Forms.TextBox txtBoxSourName;
        public System.Windows.Forms.DateTimePicker dtmpBirthday;
        public System.Windows.Forms.TextBox txtBoxName;
        public System.Windows.Forms.Button btn1;
    }
}