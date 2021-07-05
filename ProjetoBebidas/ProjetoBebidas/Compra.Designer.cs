
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
            this.lstCarrinho = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDataCompra = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dgCodigos = new System.Windows.Forms.DataGridView();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxDinheiroRecebido = new System.Windows.Forms.TextBox();
            this.lblTroco = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNovaCompra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCodigos)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCarrinho
            // 
            this.lstCarrinho.FormattingEnabled = true;
            this.lstCarrinho.Location = new System.Drawing.Point(302, 38);
            this.lstCarrinho.Name = "lstCarrinho";
            this.lstCarrinho.Size = new System.Drawing.Size(301, 316);
            this.lstCarrinho.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o código da bebida: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(615, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data da compra: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(615, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor a pagar: ";
            // 
            // lblDataCompra
            // 
            this.lblDataCompra.AutoSize = true;
            this.lblDataCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCompra.Location = new System.Drawing.Point(615, 72);
            this.lblDataCompra.Name = "lblDataCompra";
            this.lblDataCompra.Size = new System.Drawing.Size(60, 24);
            this.lblDataCompra.TabIndex = 4;
            this.lblDataCompra.Text = "label4";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(615, 158);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 24);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "label5";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(44, 79);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(231, 20);
            this.txtCodigo.TabIndex = 6;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // dgCodigos
            // 
            this.dgCodigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCodigos.Location = new System.Drawing.Point(44, 122);
            this.dgCodigos.Name = "dgCodigos";
            this.dgCodigos.Size = new System.Drawing.Size(231, 299);
            this.dgCodigos.TabIndex = 7;
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Location = new System.Drawing.Point(619, 373);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(166, 56);
            this.btnFinalizarCompra.TabIndex = 8;
            this.btnFinalizarCompra.Text = "Finalizar compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(615, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dinheiro recebido";
            // 
            // txtBoxDinheiroRecebido
            // 
            this.txtBoxDinheiroRecebido.Location = new System.Drawing.Point(619, 250);
            this.txtBoxDinheiroRecebido.Name = "txtBoxDinheiroRecebido";
            this.txtBoxDinheiroRecebido.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDinheiroRecebido.TabIndex = 10;
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.Location = new System.Drawing.Point(615, 329);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(60, 24);
            this.lblTroco.TabIndex = 12;
            this.lblTroco.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(615, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Troco";
            // 
            // btnNovaCompra
            // 
            this.btnNovaCompra.Location = new System.Drawing.Point(351, 373);
            this.btnNovaCompra.Name = "btnNovaCompra";
            this.btnNovaCompra.Size = new System.Drawing.Size(166, 56);
            this.btnNovaCompra.TabIndex = 13;
            this.btnNovaCompra.Text = "Nova compra";
            this.btnNovaCompra.UseVisualStyleBackColor = true;
            this.btnNovaCompra.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNovaCompra);
            this.Controls.Add(this.lblTroco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxDinheiroRecebido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.dgCodigos);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDataCompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCarrinho);
            this.Name = "Compra";
            this.Text = "Compra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCodigos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCarrinho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDataCompra;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dgCodigos;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxDinheiroRecebido;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNovaCompra;
    }
}