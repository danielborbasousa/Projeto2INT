﻿namespace Projeto2
{
    partial class vendas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Jan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retornar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Jan,
            this.Fev,
            this.Mar});
            this.dataGridView1.Location = new System.Drawing.Point(232, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(340, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // Jan
            // 
            this.Jan.HeaderText = "Janeiro";
            this.Jan.Name = "Jan";
            // 
            // Fev
            // 
            this.Fev.HeaderText = "Fevereiro";
            this.Fev.Name = "Fev";
            // 
            // Mar
            // 
            this.Mar.HeaderText = "Março";
            this.Mar.Name = "Mar";
            // 
            // Retornar
            // 
            this.Retornar.Location = new System.Drawing.Point(530, 326);
            this.Retornar.Name = "Retornar";
            this.Retornar.Size = new System.Drawing.Size(75, 23);
            this.Retornar.TabIndex = 1;
            this.Retornar.Text = "Retornar";
            this.Retornar.UseVisualStyleBackColor = true;
            this.Retornar.Click += new System.EventHandler(this.rtn_Click);
            // 
            // vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Retornar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "vendas";
            this.Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mar;
        private System.Windows.Forms.Button Retornar;
    }
}