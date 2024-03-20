
namespace Projeto2
{
    partial class telainicial
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
            this.telCliente = new System.Windows.Forms.Button();
            this.telVendedor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsairte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // telCliente
            // 
            this.telCliente.Location = new System.Drawing.Point(163, 34);
            this.telCliente.Name = "telCliente";
            this.telCliente.Size = new System.Drawing.Size(94, 66);
            this.telCliente.TabIndex = 0;
            this.telCliente.Text = "Produto";
            this.telCliente.UseVisualStyleBackColor = true;
            this.telCliente.Click += new System.EventHandler(this.telCliente_Click);
            // 
            // telVendedor
            // 
            this.telVendedor.Location = new System.Drawing.Point(163, 120);
            this.telVendedor.Name = "telVendedor";
            this.telVendedor.Size = new System.Drawing.Size(94, 67);
            this.telVendedor.TabIndex = 1;
            this.telVendedor.Text = "Vendas";
            this.telVendedor.UseVisualStyleBackColor = true;
            this.telVendedor.Click += new System.EventHandler(this.telVendedor_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 67);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pedidos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto2.Properties.Resources.download__21_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnsairte
            // 
            this.btnsairte.Location = new System.Drawing.Point(464, 267);
            this.btnsairte.Name = "btnsairte";
            this.btnsairte.Size = new System.Drawing.Size(75, 23);
            this.btnsairte.TabIndex = 5;
            this.btnsairte.Text = "Sair";
            this.btnsairte.UseVisualStyleBackColor = true;
            this.btnsairte.Click += new System.EventHandler(this.btnsairte_Click);
            // 
            // telainicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(542, 292);
            this.Controls.Add(this.btnsairte);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.telVendedor);
            this.Controls.Add(this.telCliente);
            this.Name = "telainicial";
            this.Text = "Tela inicial";
            this.Load += new System.EventHandler(this.telInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button telCliente;
        private System.Windows.Forms.Button telVendedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnsairte;
    }
}