namespace Pract2_Ivan
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.nudN = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvArray = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArray)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(456, 363);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(154, 30);
            this.btnCalc.TabIndex = 12;
            this.btnCalc.Text = "Порахувати";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(403, 57);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(157, 30);
            this.btnFill.TabIndex = 13;
            this.btnFill.Text = "Заповнити масив";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // nudN
            // 
            this.nudN.Location = new System.Drawing.Point(456, 31);
            this.nudN.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudN.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudN.Name = "nudN";
            this.nudN.Size = new System.Drawing.Size(104, 20);
            this.nudN.TabIndex = 11;
            this.nudN.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(403, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "N:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvArray
            // 
            this.dgvArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArray.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x});
            this.dgvArray.Location = new System.Drawing.Point(12, 12);
            this.dgvArray.Name = "dgvArray";
            this.dgvArray.Size = new System.Drawing.Size(376, 381);
            this.dgvArray.TabIndex = 9;
            // 
            // x
            // 
            this.x.HeaderText = "Array";
            this.x.Name = "x";
            this.x.Width = 330;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 403);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.nudN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvArray);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArray)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.NumericUpDown nudN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvArray;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
    }
}