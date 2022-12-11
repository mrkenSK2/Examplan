namespace Examplan
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.createButton = new System.Windows.Forms.Button();
            this.Startdaylabel = new System.Windows.Forms.Label();
            this.Dayslabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.daytextBox1 = new System.Windows.Forms.TextBox();
            this.subjects = new System.Windows.Forms.Label();
            this.subtextBox2 = new System.Windows.Forms.TextBox();
            this.openbutton = new System.Windows.Forms.Button();
            this.warn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(278, 202);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(92, 44);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "予定表作成";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Startdaylabel
            // 
            this.Startdaylabel.AutoSize = true;
            this.Startdaylabel.Location = new System.Drawing.Point(78, 118);
            this.Startdaylabel.Name = "Startdaylabel";
            this.Startdaylabel.Size = new System.Drawing.Size(52, 15);
            this.Startdaylabel.TabIndex = 2;
            this.Startdaylabel.Text = "開始日";
            // 
            // Dayslabel
            // 
            this.Dayslabel.AutoSize = true;
            this.Dayslabel.Location = new System.Drawing.Point(78, 148);
            this.Dayslabel.Name = "Dayslabel";
            this.Dayslabel.Size = new System.Drawing.Size(37, 15);
            this.Dayslabel.TabIndex = 3;
            this.Dayslabel.Text = "日数";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 111);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // daytextBox1
            // 
            this.daytextBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.daytextBox1.Location = new System.Drawing.Point(146, 145);
            this.daytextBox1.Name = "daytextBox1";
            this.daytextBox1.ShortcutsEnabled = false;
            this.daytextBox1.Size = new System.Drawing.Size(100, 22);
            this.daytextBox1.TabIndex = 5;
            this.daytextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.daytextBox1_KeyPress);
            // 
            // subjects
            // 
            this.subjects.AutoSize = true;
            this.subjects.Location = new System.Drawing.Point(78, 180);
            this.subjects.Name = "subjects";
            this.subjects.Size = new System.Drawing.Size(52, 15);
            this.subjects.TabIndex = 6;
            this.subjects.Text = "科目数";
            // 
            // subtextBox2
            // 
            this.subtextBox2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.subtextBox2.Location = new System.Drawing.Point(146, 174);
            this.subtextBox2.Name = "subtextBox2";
            this.subtextBox2.ShortcutsEnabled = false;
            this.subtextBox2.Size = new System.Drawing.Size(100, 22);
            this.subtextBox2.TabIndex = 7;
            this.subtextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.daytextBox1_KeyPress);
            // 
            // openbutton
            // 
            this.openbutton.Location = new System.Drawing.Point(81, 205);
            this.openbutton.Name = "openbutton";
            this.openbutton.Size = new System.Drawing.Size(100, 41);
            this.openbutton.TabIndex = 8;
            this.openbutton.Text = "ファイルを開く";
            this.openbutton.UseVisualStyleBackColor = true;
            this.openbutton.Click += new System.EventHandler(this.openbutton_Click);
            // 
            // warn
            // 
            this.warn.AutoSize = true;
            this.warn.Location = new System.Drawing.Point(265, 162);
            this.warn.Name = "warn";
            this.warn.Size = new System.Drawing.Size(189, 15);
            this.warn.TabIndex = 9;
            this.warn.Text = "(半角数字の直接入力のみ可)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.warn);
            this.Controls.Add(this.openbutton);
            this.Controls.Add(this.subtextBox2);
            this.Controls.Add(this.subjects);
            this.Controls.Add(this.daytextBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Dayslabel);
            this.Controls.Add(this.Startdaylabel);
            this.Controls.Add(this.createButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label Startdaylabel;
        private System.Windows.Forms.Label Dayslabel;
        public System.Windows.Forms.TextBox daytextBox1;
        private System.Windows.Forms.Label subjects;
        public System.Windows.Forms.TextBox subtextBox2;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button openbutton;
        private System.Windows.Forms.Label warn;
    }
}

