namespace Examplan
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
            this.Plan = new System.Windows.Forms.DataGridView();
            this.restore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Plan)).BeginInit();
            this.SuspendLayout();
            // 
            // Plan
            // 
            this.Plan.AllowUserToAddRows = false;
            this.Plan.ColumnHeadersHeight = 29;
            this.Plan.ColumnHeadersVisible = false;
            this.Plan.Location = new System.Drawing.Point(71, 40);
            this.Plan.Name = "Plan";
            this.Plan.RowHeadersVisible = false;
            this.Plan.RowHeadersWidth = 51;
            this.Plan.RowTemplate.Height = 24;
            this.Plan.Size = new System.Drawing.Size(518, 322);
            this.Plan.TabIndex = 0;
            // 
            // restore
            // 
            this.restore.Location = new System.Drawing.Point(521, 395);
            this.restore.Name = "restore";
            this.restore.Size = new System.Drawing.Size(75, 23);
            this.restore.TabIndex = 1;
            this.restore.Text = "保存";
            this.restore.UseVisualStyleBackColor = true;
            this.restore.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.restore);
            this.Controls.Add(this.Plan);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Plan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView Plan;
        private System.Windows.Forms.Button restore;
    }
}