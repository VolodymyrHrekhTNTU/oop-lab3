namespace WinFormsArray2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Solution = new System.Windows.Forms.Button();
            this.Generation = new System.Windows.Forms.Button();
            this.Column = new System.Windows.Forms.NumericUpDown();
            this.Row = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewArray = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Column)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Row)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).BeginInit();
            this.SuspendLayout();
            // 
            // Solution
            // 
            this.Solution.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Solution.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Solution.Location = new System.Drawing.Point(647, 39);
            this.Solution.Name = "Solution";
            this.Solution.Size = new System.Drawing.Size(112, 81);
            this.Solution.TabIndex = 0;
            this.Solution.Text = "Solution";
            this.Solution.UseVisualStyleBackColor = false;
            this.Solution.Click += new System.EventHandler(this.Solution_Click);
            // 
            // Generation
            // 
            this.Generation.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Generation.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Generation.Location = new System.Drawing.Point(503, 39);
            this.Generation.Name = "Generation";
            this.Generation.Size = new System.Drawing.Size(138, 81);
            this.Generation.TabIndex = 1;
            this.Generation.Text = "Generation";
            this.Generation.UseVisualStyleBackColor = false;
            this.Generation.Click += new System.EventHandler(this.button2_Click);
            // 
            // Column
            // 
            this.Column.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Column.Location = new System.Drawing.Point(361, 39);
            this.Column.Name = "Column";
            this.Column.Size = new System.Drawing.Size(112, 38);
            this.Column.TabIndex = 2;
            // 
            // Row
            // 
            this.Row.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Row.Location = new System.Drawing.Point(361, 82);
            this.Row.Name = "Row";
            this.Row.Size = new System.Drawing.Size(112, 38);
            this.Row.TabIndex = 3;
            // 
            // dataGridViewArray
            // 
            this.dataGridViewArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArray.Location = new System.Drawing.Point(51, 126);
            this.dataGridViewArray.Name = "dataGridViewArray";
            this.dataGridViewArray.RowHeadersWidth = 51;
            this.dataGridViewArray.RowTemplate.Height = 29;
            this.dataGridViewArray.Size = new System.Drawing.Size(708, 262);
            this.dataGridViewArray.TabIndex = 4;
            this.dataGridViewArray.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(153, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Кількість стовпців:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(170, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Кільіксть рядків:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(634, 400);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 38);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(56, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(562, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Найменший елемент серед який знайти найбільший";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewArray);
            this.Controls.Add(this.Row);
            this.Controls.Add(this.Column);
            this.Controls.Add(this.Generation);
            this.Controls.Add(this.Solution);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Column)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Row)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Solution;
        private Button Generation;
        private NumericUpDown Column;
        private NumericUpDown Row;
        private DataGridView dataGridViewArray;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
    }
}