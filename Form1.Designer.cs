﻿namespace Pract2_Ivan
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.масивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.одновимірніМасивиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.двовимірніМасивиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.масивToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(645, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // масивToolStripMenuItem
            // 
            this.масивToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.одновимірніМасивиToolStripMenuItem,
            this.двовимірніМасивиToolStripMenuItem});
            this.масивToolStripMenuItem.Name = "масивToolStripMenuItem";
            this.масивToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.масивToolStripMenuItem.Text = "Масив";
            // 
            // одновимірніМасивиToolStripMenuItem
            // 
            this.одновимірніМасивиToolStripMenuItem.Name = "одновимірніМасивиToolStripMenuItem";
            this.одновимірніМасивиToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.одновимірніМасивиToolStripMenuItem.Text = "Одновимірні масиви";
            this.одновимірніМасивиToolStripMenuItem.Click += new System.EventHandler(this.arrayClick);
            // 
            // двовимірніМасивиToolStripMenuItem
            // 
            this.двовимірніМасивиToolStripMenuItem.Name = "двовимірніМасивиToolStripMenuItem";
            this.двовимірніМасивиToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.двовимірніМасивиToolStripMenuItem.Text = "Двовимірні масиви";
            this.двовимірніМасивиToolStripMenuItem.Click += new System.EventHandler(this.array2dClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 337);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem масивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem одновимірніМасивиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem двовимірніМасивиToolStripMenuItem;
    }
}

