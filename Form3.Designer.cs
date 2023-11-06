namespace Pract2_Ivan
{
    partial class Form3
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
            this.dgvArray = new System.Windows.Forms.DataGridView();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArray)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArray
            // 
            this.dgvArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArray.Location = new System.Drawing.Point(12, 12);
            this.dgvArray.Name = "dgvArray";
            this.dgvArray.Size = new System.Drawing.Size(368, 375);
            this.dgvArray.TabIndex = 10;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(459, 357);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(154, 30);
            this.btnCalc.TabIndex = 16;
            this.btnCalc.Text = "Порахувати";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(386, 187);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(157, 30);
            this.btnFill.TabIndex = 17;
            this.btnFill.Text = "Заповнити масив";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 399);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.dgvArray);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArray)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArray;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnFill;
    }
}