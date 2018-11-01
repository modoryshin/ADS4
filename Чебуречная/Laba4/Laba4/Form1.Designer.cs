namespace Laba4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Mas = new System.Windows.Forms.DataGridView();
            this.Time_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Mas)).BeginInit();
            this.SuspendLayout();
            // 
            // Mas
            // 
            this.Mas.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Mas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Mas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time_1,
            this.Time_2});
            this.Mas.Location = new System.Drawing.Point(12, 12);
            this.Mas.Name = "Mas";
            this.Mas.Size = new System.Drawing.Size(251, 426);
            this.Mas.TabIndex = 0;
            // 
            // Time_1
            // 
            this.Time_1.HeaderText = "Time_1";
            this.Time_1.Name = "Time_1";
            // 
            // Time_2
            // 
            this.Time_2.HeaderText = "Time_2";
            this.Time_2.Name = "Time_2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Mas);
            this.Name = "Form1";
            this.Text = "Алгоритм Джонсона";
            ((System.ComponentModel.ISupportInitialize)(this.Mas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Mas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_2;
        private System.Windows.Forms.Button button1;
    }
}

