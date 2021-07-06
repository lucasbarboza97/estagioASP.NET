
namespace ProjetoBebidas
{
    partial class Compra
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDataCompra = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dgCodigos = new System.Windows.Forms.DataGridView();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.btnNovaCompra = new System.Windows.Forms.Button();
            this.dgCarrinho = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.btnCarrinho = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVerificarTroco = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCodigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o código";
            // 
            // lblDataCompra
            // 
            this.lblDataCompra.AutoSize = true;
            this.lblDataCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCompra.Location = new System.Drawing.Point(265, 365);
            this.lblDataCompra.Name = "lblDataCompra";
            this.lblDataCompra.Size = new System.Drawing.Size(101, 15);
            this.lblDataCompra.TabIndex = 2;
            this.lblDataCompra.Text = "Data da compra: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(439, 365);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(85, 15);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total a pagar: ";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(6, 332);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(96, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // dgCodigos
            // 
            this.dgCodigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCodigos.Location = new System.Drawing.Point(6, 125);
            this.dgCodigos.Name = "dgCodigos";
            this.dgCodigos.Size = new System.Drawing.Size(245, 165);
            this.dgCodigos.TabIndex = 7;
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Location = new System.Drawing.Point(605, 376);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(143, 56);
            this.btnFinalizarCompra.TabIndex = 8;
            this.btnFinalizarCompra.Text = "Finalizar compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(265, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dinheiro recebido";
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.Location = new System.Drawing.Point(480, 417);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(44, 15);
            this.lblTroco.TabIndex = 12;
            this.lblTroco.Text = "Troco: ";
            // 
            // btnNovaCompra
            // 
            this.btnNovaCompra.Location = new System.Drawing.Point(68, 21);
            this.btnNovaCompra.Name = "btnNovaCompra";
            this.btnNovaCompra.Size = new System.Drawing.Size(166, 56);
            this.btnNovaCompra.TabIndex = 13;
            this.btnNovaCompra.Text = "Nova compra";
            this.btnNovaCompra.UseVisualStyleBackColor = true;
            this.btnNovaCompra.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dgCarrinho
            // 
            this.dgCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCarrinho.Location = new System.Drawing.Point(268, 125);
            this.dgCarrinho.Name = "dgCarrinho";
            this.dgCarrinho.Size = new System.Drawing.Size(480, 224);
            this.dgCarrinho.TabIndex = 16;
            this.dgCarrinho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Carrinho";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(124, 332);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(96, 20);
            this.txtQtd.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Digite a quantidade: ";
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Location = new System.Drawing.Point(268, 416);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(98, 20);
            this.txtDinheiro.TabIndex = 20;
            // 
            // btnCarrinho
            // 
            this.btnCarrinho.Location = new System.Drawing.Point(37, 379);
            this.btnCarrinho.Name = "btnCarrinho";
            this.btnCarrinho.Size = new System.Drawing.Size(166, 56);
            this.btnCarrinho.TabIndex = 22;
            this.btnCarrinho.Text = "Colocar no carrinho";
            this.btnCarrinho.UseVisualStyleBackColor = true;
            this.btnCarrinho.Click += new System.EventHandler(this.btnCarrinho_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "Bebidas";
            // 
            // btnVerificarTroco
            // 
            this.btnVerificarTroco.ImageKey = "(nenhum/a)";
            this.btnVerificarTroco.Location = new System.Drawing.Point(372, 394);
            this.btnVerificarTroco.Name = "btnVerificarTroco";
            this.btnVerificarTroco.Size = new System.Drawing.Size(54, 44);
            this.btnVerificarTroco.TabIndex = 24;
            this.btnVerificarTroco.Text = "Verificar Troco";
            this.btnVerificarTroco.UseVisualStyleBackColor = true;
            this.btnVerificarTroco.Click += new System.EventHandler(this.btnVerificarTroco_Click);
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerificarTroco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCarrinho);
            this.Controls.Add(this.txtDinheiro);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgCarrinho);
            this.Controls.Add(this.btnNovaCompra);
            this.Controls.Add(this.lblTroco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.dgCodigos);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDataCompra);
            this.Controls.Add(this.label1);
            this.Name = "Compra";
            this.Text = "Compra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCodigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarrinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDataCompra;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dgCodigos;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Button btnNovaCompra;
        private System.Windows.Forms.DataGridView dgCarrinho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.Button btnCarrinho;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVerificarTroco;
    }
}