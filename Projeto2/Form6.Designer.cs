
namespace Projeto2
{
    partial class scroll
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
            this.boasvindas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boasvindas
            // 
            this.boasvindas.AutoSize = true;
            this.boasvindas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.boasvindas.Location = new System.Drawing.Point(198, 152);
            this.boasvindas.Name = "boasvindas";
            this.boasvindas.Size = new System.Drawing.Size(423, 25);
            this.boasvindas.TabIndex = 0;
            this.boasvindas.Text = "Para pedir ajuda, fale com XX-XXXX-XXXX";
            this.boasvindas.Click += new System.EventHandler(this.boasvindas_Click);
            // 
            // scroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boasvindas);
            this.Name = "scroll";
            this.Text = "Tela de Scroll";
            this.Load += new System.EventHandler(this.scroll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label boasvindas;
    }
}